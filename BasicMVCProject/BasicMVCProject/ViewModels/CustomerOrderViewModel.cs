using BasicMVCProject.Models;

namespace BasicMVCProject.ViewModels
{
    public class CustomerOrderViewModel
    {
        private Customer customer;
        private List<Order> orders;

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public List<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }
    }
}
