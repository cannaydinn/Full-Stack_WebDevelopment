using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik29
{
    public class Student
    {
        // Sınıfın fieldları
        private int studentID;
        private string studentName;
        private int classID;


        // Constructor
        public Student(int studentID, string studentName, int classID)
        {
            this.studentID = studentID;
            this.studentName = studentName;
            this.classID = classID;
        }


        // Fieldların get/set metotları
        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public int ClassID
        {
            get { return classID; }
            set { classID = value; }
        }
    }
}

