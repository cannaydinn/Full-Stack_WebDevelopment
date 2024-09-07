namespace BasicMVCProject.Models
{
    public class Order
    {
        private int id;
        private string productNmae;
        private decimal price;
        private int quantity;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string ProductName
        {
            get { return productNmae; }
            set { productNmae = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
