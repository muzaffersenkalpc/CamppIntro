// See https://aka.ms/new-console-template for more information



using ClassMetotDemo1;

Customer customer = new Customer();
customer.Name = "Muzo";
customer.Surname = "senkal";
customer.Id = 1;
Customer customer2 = new Customer();
customer2.Name = "Ahmet";
customer2.Surname = "gg";
customer2.Id = 2;

Customer[] customers = new Customer[] { customer, customer2 };

foreach (Customer x in customers)
{
    Console.WriteLine(x.Name);

}

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer2);