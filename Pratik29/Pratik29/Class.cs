using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik29
{
    public class Class
    {

        // Sınıfın fieldları
        private int classID;
        private string className;


        // Constructor
        public Class(int classID, string className)
        {
            this.classID = classID;
            this.className = className;
        }


        // fieldların get/set metotları
        public int ClassID
        {
            get { return classID; }
            set { classID = value; }
        }

        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }
    }
}
