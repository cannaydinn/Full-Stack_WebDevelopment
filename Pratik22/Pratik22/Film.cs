using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik22
{
    public class Film
    {
        // Sınıfın fiedları
        private double imdbPuani;
        private string filmAdi;

        // Özelliklerin get/set metotları
        public double ImdbPuani
        {
            get { return imdbPuani; }
            set { imdbPuani = value; }
        }

        public string FilmAdi
        {
            get { return filmAdi; }
            set { filmAdi = value; }
        }


        // Metot tanımlama
        public void FilmGetir()
        {
            Console.WriteLine($"Film: {FilmAdi}, IMDb Puanı: {ImdbPuani}");
        }


        // İstenilen koşula göre metot tanımlama
        public void IMDBPuani()
        {
            if( ImdbPuani >= 4 && ImdbPuani <=9)
            {
                Console.WriteLine($"Film: {FilmAdi}, IMDb Puanı: {ImdbPuani}");
            }
        }


        // İstenilen koşula göre metot tanımlama
        public void BaslangicHarfiA()
        {
            if (FilmAdi.ToLower().StartsWith("a"))
                Console.WriteLine($"Film: {FilmAdi}, IMDb Puanı: {ImdbPuani}");

        }
    }
}
