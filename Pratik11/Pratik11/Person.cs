using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik11
{
    internal class Person
    {

        // özelliklerin tanımlanması
        private string ad;
        private string soyad;
        private string dogumTarihi;


        // özelliklerin public property'leri
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }  
        }

        public string DogumTarihi
        {
            get { return dogumTarihi; }
            set { dogumTarihi = value; }
        }

    }
}
