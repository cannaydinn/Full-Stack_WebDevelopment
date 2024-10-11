namespace CodeFirstRelation.Entities
{
    public class UserEntity
    {
        private int id;
        private string userName;
        private string email;

        // Relational Property
        private List<PostEntity> posts;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public List<PostEntity> Posts
        {
            get { return posts; }
            set { posts = value; }
        }
    }
}
