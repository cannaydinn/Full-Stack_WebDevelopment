using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik28
{
    public class Author
    {
        // Sınıfın fieldları
        private int authorID;
        private string name;


        // Constructor
        public Author(int authorID, string name)
        {
            this.authorID = authorID;
            this.name = name;
        }


        // Fieldların get/set metotları
        public int AuthorID
        {
            get { return authorID; }
            set { authorID = value; }
        }

        public string Name
        {
            get { return name; }
            set {  name = value; }
        }
    }
}
