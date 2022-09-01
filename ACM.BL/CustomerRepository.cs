namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);

            if (customer.CustomerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.com";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
