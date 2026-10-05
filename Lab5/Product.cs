namespace Lab5
{
    public class Product
    {
        private string name;
        private decimal price;
        private int quantity;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                name = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                price = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                quantity = value;
            }
        }

        public Product()
        {
            Name = "Unknown";
            Price = 0;
            Quantity = 0;
        }

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public decimal GetTotalPrice()
        {
            return Price * Quantity;
        }

        public void AddQuantity(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            Quantity += amount;
        }

        public override string ToString()
        {
            return $"{Name}, Price: {Price}, Quantity: {Quantity}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Product product)
            {
                return Name == product.Name &&
                       Price == product.Price &&
                       Quantity == product.Quantity;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price, Quantity);
        }
    }
}