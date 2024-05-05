
using Strategy_Pattern;
using Strategy_Pattern.Core;
using Strategy_Pattern.Core.DiscountStrategy;
using System.Net.WebSockets;
using System.Numerics;


var dataReader = new CustomerDataReader();
var customers = dataReader.GetCustomers();

while (true)
{
    Console.WriteLine("Customer List : [1] Badr [2] Mohamed ");
    Console.WriteLine("Enter Customer Id : ");
    var customerId = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Item Quantity : ");
    var quantity = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter Unit price : ");
    var unitprice = double.Parse(Console.ReadLine());

    var customer = customers.First(x => x.id == customerId);
    var invoicmaneger = new InvoicwManeger();
    ICustomerDiscountStrategy customerDiscountStrategy = new CustomerDiscountStrategyFactory().CreateCustomerDiscountStrategy(customer.Category);
    invoicmaneger.SetDiscountStrategy(customerDiscountStrategy);
    var invoice = invoicmaneger.CreateInvoice(customer, quantity, unitprice);
    Console.WriteLine($"Invoice Created For Customer {customer.name}  With Total Price:{invoice.Totalprice}");
    Console.WriteLine(invoice.Netprice);
    Console.WriteLine("press Any Key to Created another invoice ");
    Console.ReadKey();
    Console.WriteLine("---------------------------------------------------------------------------");
}