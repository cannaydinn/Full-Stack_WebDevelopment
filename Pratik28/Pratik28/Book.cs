using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik28
{
    public class Book
    {
        // Sınıfın fieldları
        private int bookID;
        private string title;
        private int authorID;

        // Consturctor
        public Book(int bookID, string title, int authorID)
        {
            this.bookID = bookID;
            this.title = title;
            this.authorID = authorID;
        }


        // Fieldların get/set metotları
        public int BookID
        {
            get { return bookID; }
            set { bookID = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int AuthorID
        {
            get { return authorID; }
            set { authorID = value; }
        }

    }
}
