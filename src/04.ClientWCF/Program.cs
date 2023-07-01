// See https://aka.ms/new-console-template for more information
using ServiceReference1;

CustomerServiceClient customerServiceClient = new();

var listCustomers = await customerServiceClient.ListCustomersAsync(new ListCustomersRequest());

foreach (var listCustomer in listCustomers.ListCustomersResult)
{
    Console.WriteLine($"listCustomer: {listCustomer}");
}

customerServiceClient.Close();