
using DemoLibrary;


public class Program
{
    static void Main()
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

    private static List<PhysicalProductModel> AddSampleData()
    {
        List<PhysicalProductModel> output = new List<PhysicalProductModel>();

        output.Add(new PhysicalProductModel { Title = "RTX 3090" });
        output.Add(new PhysicalProductModel { Title = "Dublin T-Shirt" });
        output.Add(new PhysicalProductModel { Title = "SSD 1Tb" });
        output.Add(new PhysicalProductModel { Title = "iPhone 15 Pro 5Tb" });

        return output;
    }
}
