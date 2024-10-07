using System.ComponentModel.DataAnnotations;

namespace MyFirstDb.Entities
{
    public class MovieEntity
    {
        private int id;
        private string title;
        private string genre;
        private int releaseYear;

        [Key]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int ReleaseYear
        {
            get { return releaseYear; }
            set { releaseYear = value; }
        }
    }
}
