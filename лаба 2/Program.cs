using System.ComponentModel;
using лаба_2;

class Program
{
    static void Main(string[] args)
    {
        var eggs = new Eggs()
        {
            Category = "C0",
            Quantity = 3,
            PricePerDozen = 150,
        };

        var milk = new Milk()
        {
            FatContent = 2.5,
            Quantity = 3,
            PricePerPacket = 100,
        };

        var bread = new Bread()
        {
            Type = "ржаной",
            Quantity = 1,
            PricePerLoaf = 40,
        };
        
        var ShoppingList = new ShopingList { eggs, milk, bread };   
        Console.WriteLine($"Цена за десяток яиц: {eggs.PricePerDozen}");
        Console.WriteLine($"Цена за пакет молока: {milk.PricePerPacket}");
        Console.WriteLine($"Цена за батон хлеба: {bread.PricePerLoaf}");
        Console.WriteLine($"Общая стоимость покупки: {ShoppingList.TotalPrice()}");
    }
}