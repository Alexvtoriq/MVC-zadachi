using (var db = new GroceryStoreContext())
{
    db.Products.Add(new Product
    {
        Name = "Apple",
        Price = 1.50m,
        UnitType = "kilogram"
    });

    db.SaveChanges();

    foreach (var product in db.Products)
    {
        Console.WriteLine($"{product.Name} - {product.Price} per {product.UnitType}");
    }
}
