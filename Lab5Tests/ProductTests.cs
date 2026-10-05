using Lab5;

namespace Lab5Tests
{
    public class ProductTests
    {
        [Fact]
        public void Constructor_CreatesProduct()
        {
            Product product = new Product("Laptop", 1200m, 2);

            Assert.Equal("Laptop", product.Name);
            Assert.Equal(1200m, product.Price);
            Assert.Equal(2, product.Quantity);
        }

        [Fact]
        public void GetTotalPrice_ReturnsCorrectValue()
        {
            Product product = new Product("Laptop", 1200m, 2);

            decimal result = product.GetTotalPrice();

            Assert.Equal(2400m, result);
        }

        [Fact]
        public void Constructor_ThrowsException_WhenPriceIsNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                new Product("Laptop", -100m, 2));
        }

        [Fact]
        public void Constructor_ThrowsException_WhenNameIsEmpty()
        {
            Assert.Throws<ArgumentException>(() =>
                new Product("", 1200m, 2));
        }

        [Fact]
        public void AddQuantity_IncreasesQuantity()
        {
            Product product = new Product("Laptop", 1200m, 2);

            product.AddQuantity(3);

            Assert.Equal(5, product.Quantity);
        }

        [Fact]
        public void Equals_ReturnsTrue_ForEqualProducts()
        {
            Product firstProduct = new Product("Laptop", 1200m, 2);
            Product secondProduct = new Product("Laptop", 1200m, 2);

            Assert.True(firstProduct.Equals(secondProduct));
        }
    }
}