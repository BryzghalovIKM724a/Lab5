using Lab5;

Product product = new Product("Laptop", 1200m, 2);

Console.WriteLine(product);
Console.WriteLine($"Total price: {product.GetTotalPrice()}");

product.AddQuantity(1);

Console.WriteLine(product);
Console.WriteLine($"Total price: {product.GetTotalPrice()}");