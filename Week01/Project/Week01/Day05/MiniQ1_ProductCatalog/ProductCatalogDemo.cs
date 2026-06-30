namespace Week01.Day05.MiniQ1_ProductCatalog;

public static class ProductCatalogDemo
{
    public static void Run()
    {
        List<Product> products = new()
        {
            new Product
            {
                Name = "Laptop",
                Price = 65000,
                Category = Category.Electronics
            },

            new Product
            {
                Name = "Mobile",
                Price = 25000,
                Category = Category.Electronics
            },

            new Product
            {
                Name = "Rice",
                Price = 60,
                Category = Category.Grocery
            },

            new Product
            {
                Name = "T-Shirt",
                Price = 700,
                Category = Category.Clothing
            },

            new Product
            {
                Name = "Sugar",
                Price = 45,
                Category = Category.Grocery
            }
        };

        Console.WriteLine("===== Product Catalog =====");

        foreach (Category category in Enum.GetValues<Category>())
        {
            Console.WriteLine($"\n{category}");

            foreach (Product product in products)
            {
                if (product.Category == category)
                {
                    Console.WriteLine($"{product.Name} - ₹{product.Price}");
                }
            }
        }

        // Explanation:
        // Products are grouped based on their Category enum.
    }
}