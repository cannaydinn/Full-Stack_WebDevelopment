namespace JWTProject.Dtos
{
    public class UserLoginDto
    {
        private string email;
        private string password;

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
    }
}
