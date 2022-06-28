
using DemoLibrary;

class Program
{
    static void Main(string[] args)
    {
        List<PhysicalProductModel> cart = AddSampleData();
        CustomerModel customer = GetCustomer();

        foreach (PhysicalProductModel prod in cart)
        {
            prod.ShipItem(customer);
        }

        Console.ReadLine();
    }

    private static CustomerModel GetCustomer()
    {
        return new CustomerModel
        {
            FirstName = "Test",
            LastName = "Test 2",
            City = "Dublin",
            EmailAddress = "test@test.com",
            PhoneNumber = "3123123"
        };
    }
}
