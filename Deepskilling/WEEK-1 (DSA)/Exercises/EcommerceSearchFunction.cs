using System;

class Product
{
    public int ProductId;
    public string ProductName;

    public Product(int id, string name)
    {
        ProductId = id;
        ProductName = name;
    }
}

class EcommerceSearchFunction
{
    static int BinarySearch(Product[] products, int targetId)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (products[mid].ProductId == targetId)
                return mid;

            if (products[mid].ProductId < targetId)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    static void Main()
    {
        Product[] products =
        {
            new Product(101, "Laptop"),
            new Product(102, "Mobile"),
            new Product(103, "Keyboard"),
            new Product(104, "Mouse"),
            new Product(105, "Monitor")
        };

        int index = BinarySearch(products, 103);

        if (index != -1)
            Console.WriteLine(products[index].ProductName);
        else
            Console.WriteLine("Product not found");
    }
}
