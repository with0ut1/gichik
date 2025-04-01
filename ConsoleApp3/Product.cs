namespace ClassProduct
{
    class Product
    {
        public string Name;
        public int Quantity;
        public double Price;

        public Product(string name, int quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public double GetTotalPrice()
        {
            return Quantity * Price;
        }
    }
}