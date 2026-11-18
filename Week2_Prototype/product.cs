class Product
{
    public string ProductName { get; }
    public int StockQuantity { get; private set; }
    public decimal Price { get; private set; }

    public Product(string productName, int initialStock, decimal price)
    {
        ProductName = productName;
        StockQuantity = initialStock < 0 ? 0 : initialStock;
        Price = price;
    }

    public bool DeductStock(int quantity)
    {
        if (quantity <= 0 || quantity > StockQuantity)
        {
            return false;
        }
        StockQuantity -= quantity;
        return true;
    }

    public void Restock(int quantity)
    {
        if (quantity > 0)
        {
            StockQuantity += quantity;
        }
    }
}