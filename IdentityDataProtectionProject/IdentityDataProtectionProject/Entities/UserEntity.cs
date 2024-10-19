namespace IdentityDataProtectionProject.Entities
{
    public class UserEntity
    {
        private int id;
        private string email;
        private string password;
        private DateTime createdDate;
        private bool isDeleted;

        public UserEntity() 
        {
            CreatedDate = DateTime.Now;
        } 

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        public bool IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }



    }
}
