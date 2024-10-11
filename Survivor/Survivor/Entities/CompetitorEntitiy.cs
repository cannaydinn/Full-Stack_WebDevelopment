namespace Survivor.Entities
{
    public class CompetitorEntitiy : BaseEntity
    {
        private string firstName;
        private string lastName;

        private int categoryId;
        private CategoryEntitiy category;

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

        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        public CategoryEntitiy Category
        {
            get { return category; }
            set { category = value; }
        }
    }
}
