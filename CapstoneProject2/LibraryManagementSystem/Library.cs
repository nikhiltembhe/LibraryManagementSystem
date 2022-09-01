using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace LibraryManagementSystem
{
    internal class Library
    {
        public ArrayList books;

        public ArrayList borrower;

        public string LibraryName;//{ get; private set; }

        public Library(string name)
        {
            this.LibraryName = name;
            books = new ArrayList();
            borrower = new ArrayList();
        }

        public void AddBook()
        {
            Book book = new Book();

            Console.WriteLine();
            Console.WriteLine("Enter the details of the books:");
            Console.WriteLine("Book ID: "+book._BookID);
            Console.Write("Book Name: ");
            book.BookName=Console.ReadLine();
            Console.Write("Book Price: ");
            book.BookPrice = float.Parse(Console.ReadLine());
            Console.Write("Book Quantity:");
            book.BookCount = int.Parse(Console.ReadLine());

            this.books.Add(book);
            Console.WriteLine();
            Console.WriteLine("Book Added successfully");
        }

        public void RemoveBook()
        {
            this.DisplayAllBooks();
            Console.WriteLine();
            Console.Write("Enter Book ID to remove that book:");
            int id = int.Parse(Console.ReadLine());

            for(int i = 0; i < books.Count; i++)
            {
                Book b = (Book)books[i];
                if(b._BookID == id)
                {
                    books.RemoveAt(i);
                    break;
                }
            }
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine();
            Console.WriteLine($"List of all Books in {LibraryName}:");  //.ToUpper()
            Console.WriteLine("{0,5}{1,-20}{2,5}{3,15}","Book ID","Book Name","Book Price","No. of Books");
            foreach(Book b in this.books)
            {
                Console.WriteLine(b);
            }
        }

        public void SortBook()
        {
            books.Sort();
            Console.WriteLine("All the Books sorted in ascending order according to Name");
        }

        public void SearchBook()
        {
            Console.WriteLine();
            Console.WriteLine("Enter Id of the Book");
            int id = int.Parse(Console.ReadLine());

            bool flag = false;

            for(int i = 0; i < books.Count; i++)
            {
                Book b = (Book)books[i];
                if(b._BookID == id)
                {
                    Console.WriteLine("{0,5}{1,-20}{2,5}{3,15}", "Book ID", "Book Name", "Book Price", "No. of Books");
                    Console.WriteLine(b);
                    flag = true;
                    break;
                }
            }

            if (flag == false)
            {
                Console.WriteLine("Book is not there in the library");
            }
            
        }

        public void BorrowBook()
        {
            Borrow borrow = new Borrow();

            Console.WriteLine();
            Console.WriteLine("Borrow ID: " + borrow._BorrowID);
            Console.Write("Borrow's Name: ");
            borrow.BorrowName = Console.ReadLine();
            Console.Write("Borrow's Address: ");
            borrow.BorrowAddress = Console.ReadLine();

            Console.WriteLine("Enter Book ID you want to issue: ");
            int id = int.Parse(Console.ReadLine());

            for(int i=0; i < books.Count; i++)
            {
                Book book = (Book)books[i];
                if(book._BookID == id)
                {
                    if(book.BookCount == 0)
                    {
                        Console.WriteLine($"ID:{book._BookID} Name: {book.BookName} is not available as number of books present is:{book.BookCount}");
                        break;
                    }
                    else
                    {
                        borrow.BorrowBookId = book._BookID;
                        borrow.BorrowBookCount = borrow.BorrowBookCount + 1;

                        book.BookCount = book.BookCount - 1;
                        //this.borrower.Add(book);
                        
                    }
                    
                }

                //Borrow b = (Borrow)books[i];
            }
            
            this.borrower.Add(borrow);
            Console.WriteLine();
            Console.WriteLine("Book Borrowed successfully");

        }

        public void ReturnBook()
        {
            Console.Write("Enter Borrower ID:");
            int brid = int.Parse(Console.ReadLine());
            bool flag = false;

            for(int i=0; i < borrower.Count; i++)
            {
                Borrow borrow = (Borrow)borrower[i];
                if(borrow._BorrowID == brid)
                {
                    Console.Write("Enter Book ID you want to return:");
                    int bkid = int.Parse(Console.ReadLine());
                    if(borrow._BorrowID == brid && borrow.BorrowBookId == bkid)
                    {
                        borrow.BorrowBookCount--;
                        Book book = (Book)books[bkid-1];
                        book.BookCount++;
                        flag = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Book with {bkid} not issued by Borrower ID{brid}");

                    }
                }
                
            }

            if (flag == false)
            {
                Console.WriteLine("No Borrower with this ID");
            }
            if (flag == true)
            {
                Console.WriteLine("Book returned successfully");
            }
            

            /*Console.Write("Enter Book ID to return that book:");
            int id = int.Parse(Console.ReadLine());*/

        }

        public void DisplayAllBorrower()
        {
            Console.WriteLine($"List of all Borrower in {LibraryName}:");
            Console.WriteLine("{0,5}{1,-20}{2,5}{3,15}{4,10}", "Borrow ID", "Borrow Name", "Borrow Address", "Borrow Book ID", "Borrow Book Count");
            foreach (Borrow bo in this.borrower)
            {
                Console.WriteLine(bo);
            }
        }

    }
}
