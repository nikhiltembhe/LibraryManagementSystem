using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    internal class Book:System.IComparable
    {
        private int BookID;

        private static int BookIDCounter;

        static Book()
        {
            Book.BookIDCounter = 0;
        }

        public Book()
        {
            this.BookID = ++Book.BookIDCounter;
        }

        //private int productId;
        public int _BookID
        {
            get
            {
                return BookID;
            }
        }


        public string BookName { get; set; }

        public float BookPrice { get; set; }

        public int BookCount { get; set; }

        public override string ToString()
        {
            return $"{BookID,5} {BookName,-20} {BookPrice,5}/- {BookCount,15}";
        }

        //System.IComparable members
        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return 1;
            }
            else
            {
                Book prdOther = obj as Book;
                return this.BookName.CompareTo(prdOther.BookName);      // ASC order of EmployeeID
                // return prdOther.BookName.CompareTo(this.BookName);   // DESC order of EmployeeID
            }
        }

    }
}
