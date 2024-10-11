using System.Data;

namespace Survivor.Entities
{
    public class BaseEntity
    {
        private int id;
        private bool isDeleted;
        private DateTime createdDate;
        private DateTime modifiedDate;

        public BaseEntity() 
        {
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        } 
        public int Id 
        { 
            get { return id; } 
            set { id = value; }
        }    

        public bool IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        public DateTime ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }

    }
}
