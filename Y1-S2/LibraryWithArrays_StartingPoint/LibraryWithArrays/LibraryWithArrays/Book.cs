using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace LibraryWithArrays
{
    public class Book
    {
        private static int nextID = 1;
        private string author;
        public string Author { get { return author; } }
        private int id;
        private string title;
        private string isbn;
        //private Copy[] copies;
        private int numCopies;

        public Book(string author, string isbn,string title) { 
            this.title = title;
            this.author = author;
            this.isbn = isbn;
        }
        //public void AddCopy(Copy[] c) { 
        //    copies = c;
        //}


    }
}
