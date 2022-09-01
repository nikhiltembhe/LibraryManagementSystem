using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    internal class Borrow
    {
        private int BorrowID;

        private static int BorrowIDCounter;

        static Borrow()
        {
            Borrow.BorrowIDCounter = 0;
        }

        public Borrow()
        {
            this.BorrowID = ++Borrow.BorrowIDCounter;
        }

        public int _BorrowID
        {
            get
            {
                return BorrowID;
            }
        }


        public string BorrowName { get; set; }
        public string BorrowAddress { get; set; }
        public int BorrowBookId { get; set; }
        public int BorrowBookCount { get; set; }

        /*public void BorrowBook()
        {

        }*/

        public override string ToString()
        {
            return $"{BorrowID,5} {BorrowName,-20} {BorrowAddress,5} {BorrowBookId,15} {BorrowBookCount,10}";
        }
    }
}
