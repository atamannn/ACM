namespace ACM.BL
{
    public class Customer
    {
        public Customer() {}

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }
        public string EmailAddress { get;  set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }

        public string FullName {
            get
            {
                var fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }
       
        

        public bool Validate()
        {
            var isValid = true;

            var fdf = string.IsNullOrWhiteSpace(FirstName);
            var fedf = !string.IsNullOrWhiteSpace(FirstName);

            if (string.IsNullOrWhiteSpace(FirstName)) { isValid = false; };
            if (string.IsNullOrWhiteSpace(LastName)) { isValid = false; };

            return isValid;
        }
    }
}   