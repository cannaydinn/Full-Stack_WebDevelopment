using System.ComponentModel.DataAnnotations;

namespace JWTProject.Entities
{
    public class UserEntity
    {
        private int id;
        private string email;
        private string password;

        [Key]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Required]
        [EmailAddress]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [Required]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
