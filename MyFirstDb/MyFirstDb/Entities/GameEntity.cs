using System.ComponentModel.DataAnnotations;

namespace MyFirstDb.Entities
{
    public class GameEntity
    {
        private int id;
        private string name;
        private string platform;
        private decimal rating;

        [Key]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Platform
        {
            get { return platform; }
            set { platform = value; }
        }

        [Range(0, 10)]
        public decimal Rating
        {
            get { return rating; }
            set { rating = value; }
        }
    }
}
