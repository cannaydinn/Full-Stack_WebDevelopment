namespace CodeFirstRelation.Entities
{
    public class PostEntity
    {
        private int id;
        private string title;
        private string content;

        // Relational Property
        private int userId;
        private UserEntity user;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public UserEntity User
        {
            get { return user; }
            set { user = value; }
        }

    }
}
