using System.Diagnostics.Eventing.Reader;

namespace CrazyMusicians.Entities
{
    public class MusicianEntity
    {
        private int id;
        private string fullName;
        private string profession;
        private string entertainingTrait;
        private bool isDeleted;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }

        public string EntertainingTrait
        {
            get { return entertainingTrait; }
            set { entertainingTrait = value; }
        }

        public bool IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }
    }
}
