using DependencyInjectionProject.Services;

namespace DependencyInjectionProject.Entities
{
    public class Teacher : ITeacher
    {
        private int id;
        private string firstName;
        private string lastName;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string GetInfo()
        {
            return $"{firstName} {LastName}";
        }

    }
}
