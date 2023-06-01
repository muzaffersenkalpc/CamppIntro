// See https://aka.ms/new-console-template for more information



using Methods;
using System.ComponentModel;

string productName = "Apple";
double price = 15;
string detail = "Amasya's Apple";

//Property - ozellik
Product product1 = new Product();
product1.Name = "Apple";
product1.Price = 15;
product1.Detail = "Amasya";

Product product2 = new Product();
product2.Name = "Watermelon";
product2.Price = 20;
product2.Detail = "Diyarbakir's watermelon";

Product[] products = new Product[] { product1, product2 };
//type safe -- tip guvenli
foreach (Product product in products)
{
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.Detail);
    Console.WriteLine("---------------");
}


Console.WriteLine("--------Methods-------");

//instance - ornek
SepetManager sepetManager = new SepetManager();
sepetManager.Add(product1);


Console.WriteLine("Hello, World!");



//Dont repeat yourself  - DRY - Clean Code - Best Practice