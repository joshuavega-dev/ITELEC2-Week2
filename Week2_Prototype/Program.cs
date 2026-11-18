var firstItem = new Product("Wireless Mouse", 10, 450.00m);
var secondItem = new Product ("Mechanical Keyboard", 5, 1500m);

Console.WriteLine(firstItem.DeductStock(4));
Console.WriteLine(firstItem.DeductStock(8));
Console.WriteLine(firstItem.StockQuantity);
Console.WriteLine(secondItem.DeductStock(2));
