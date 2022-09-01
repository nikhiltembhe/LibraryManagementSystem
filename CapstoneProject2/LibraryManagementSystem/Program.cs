using System;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Library lib = new Library("Estate Library");


            int menu = 4;

            while (menu != 0)
            {
                Console.WriteLine("\tLibrary Management System");
                Console.WriteLine();
                Console.WriteLine("1. Lirarian");
                Console.WriteLine("2. Borrower");
                Console.WriteLine("0. EXIT");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine();
                int.TryParse(input, out menu);

                switch (menu)
                {
                    case 0:
                        Console.WriteLine();
                        Console.WriteLine("....Exiting, Thank You");
                        break;

                    case 1:
                        int libmenu = 4;
                        while (libmenu != 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("\tLibrarian");
                            Console.WriteLine("1. Add a Book");
                            Console.WriteLine("2. Display all Books");
                            Console.WriteLine("3. Remove a Book");
                            Console.WriteLine("4. Sort books in ascending A-Z order");
                            Console.WriteLine("5. Display all Borrower");
                            Console.WriteLine("0  EXIT");
                            Console.Write("Enter your choice: ");

                            string libinput = Console.ReadLine();
                            int.TryParse(libinput, out libmenu);

                            switch (libmenu)
                            {
                                case 0:
                                    Console.WriteLine();
                                    Console.WriteLine("....Exiting, Back to Main Menu");
                                    break;
                                case 1:
                                    Console.WriteLine();
                                    //Console.WriteLine("Add your book:");
                                    lib.AddBook();

                                    break;
                                case 2:
                                    Console.WriteLine();
                                    //Console.WriteLine("Showing All Books");
                                    lib.DisplayAllBooks();
                                    break;
                                case 3:
                                    Console.WriteLine();
                                    //Console.WriteLine("Enter name to ID book:");
                                    lib.RemoveBook();
                                    break;
                                case 4:
                                    Console.WriteLine();
                                    lib.SortBook();
                                    break;

                                case 5:
                                    Console.WriteLine();
                                    lib.DisplayAllBorrower();
                                    break;

                                default:
                                    Console.WriteLine();
                                    Console.WriteLine("Invalid Input");
                                    break;
                            }

                        }

                        
                        break;

                    case 2:
                        int brwmenu = 4;
                        while(brwmenu != 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("\tBorrower");
                            Console.WriteLine("1. Search Book");
                            Console.WriteLine("2. Borrow Book");
                            Console.WriteLine("3. Return Book");
                            Console.WriteLine("0  EXIT");
                            Console.Write("Enter your choice: ");

                            string brwinput = Console.ReadLine();
                            int.TryParse(brwinput, out brwmenu);

                            switch (brwmenu)
                            {
                                case 0:
                                    Console.WriteLine();
                                    Console.WriteLine("....Exiting, Back to Main Menu");
                                    break;
                                    
                                case 1:
                                    Console.WriteLine();
                                    lib.SearchBook();
                                    break;     

                                case 2:
                                    Console.WriteLine();
                                    lib.BorrowBook();
                                    break;

                                case 3:
                                    Console.WriteLine();
                                    lib.ReturnBook();
                                    break;

                                default:
                                    Console.WriteLine();
                                    Console.WriteLine("Invalid Input");
                                    break;

                            }
                        }
                        break;



                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
