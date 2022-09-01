namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem() { }
        public OrderItem(int orderItemId)
        {
            OrderItmeId = orderItemId;
        }

        public int OrderItmeId { get; private set; }
        public int ProductItem { get; private set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductItem <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
