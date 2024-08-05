using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik13
{
    internal class Kitap
    {
        private string kitapAdi;
        private string yazarAd;
        private string yazarSoyad;
        private int sayfaSayisi;
        private string yayinEvi;
        private DateTime kayitTarihi;

        
        public Kitap()
        {
            kayitTarihi = DateTime.Now;
        }

        public Kitap(string kitapAdi, string yazarAd, string yazarSoyad, int sayfaSayisi, string yayinEvi)
        {
            this.kitapAdi = kitapAdi;
            this.yazarAd = yazarAd;
            this.yazarSoyad = yazarSoyad;
            this.sayfaSayisi = sayfaSayisi;
            this.yayinEvi = yayinEvi;
            kayitTarihi = DateTime.Now;
        }

        public string KitapAdi
        {
            get{ return kitapAdi; }
            set { kitapAdi = value; }
        }

        public string YazarAd
        {
            get { return yazarAd; }
            set { yazarAd = value; }
        }

        public string YazarSoyad
        {
            get { return yazarSoyad; }
            set { yazarSoyad = value; }
        }

        public int SayfaSayisi
        {
            get { return sayfaSayisi; }
            set { sayfaSayisi = value; }
        }

        public string YayinEvi
        {
            get { return yayinEvi; }
            set { yayinEvi = value; }
        }

        public DateTime KayitTarihi
        {
            get { return kayitTarihi; }
            set { kayitTarihi = value; }
        }

        public void Show()
        {
            Console.WriteLine(yazarAd + " " + yazarSoyad + " adlı yazarın " + sayfaSayisi + " sayfalık " + yayinEvi + " tarafından çıkarılan " + kitapAdi + " adlı kitabı " +kayitTarihi +" tarihinde kütüphaneye eklendi");
        }
    }
}
