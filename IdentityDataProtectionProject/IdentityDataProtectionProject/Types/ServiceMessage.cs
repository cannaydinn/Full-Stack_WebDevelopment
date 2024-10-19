namespace IdentityDataProtectionProject.Types
{
    public class ServiceMessage
    {
        private bool isSucceed;
        private string message;

        public bool IsSucceed
        {
            get { return isSucceed; }
            set { isSucceed = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

    }
}
