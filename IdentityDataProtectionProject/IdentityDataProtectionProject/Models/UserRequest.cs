using System.ComponentModel.DataAnnotations;

namespace IdentityDataProtectionProject.Models
{
    public class UserRequest
    {
        private string email;
        private string password;

        [Required]
        [EmailAddress]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [Required]
        [MinLength(8)]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
