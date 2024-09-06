using System.ComponentModel.DataAnnotations;

namespace Pratik30.Models
{
    public class User
    {
        [Required]
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}
