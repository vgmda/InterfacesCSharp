
using DemoLibrary;


public class Program
{
    static void Main()
    {
        // Input more than one type of data (Multiple classes)
        List<IProductModel> cart = AddSampleData();
        CustomerModel customer = GetCustomer();

        foreach (IProductModel prod in cart)
        {
            prod.ShipItem(customer);

            // If IProduct Model also implements IDigitalProductModel
            if (prod is IDigitalProductModel digital)
            {
                Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads left.");

            }
        }

        Console.ReadLine();
    }

    private static CustomerModel GetCustomer()
    {
        return new CustomerModel
        {
            FirstName = "Test",
            LastName = "Tester",
            City = "Dublin",
            EmailAddress = "tester@hmail.com",
            PhoneNumber = "0892291111"
        };
    }

    private static List<IProductModel> AddSampleData()
    {
        List<IProductModel> output = new List<IProductModel>();

        // Physical Products
        output.Add(new PhysicalProductModel { Title = "RTX 3090" });
        output.Add(new PhysicalProductModel { Title = "Dublin T-Shirt" });
        output.Add(new PhysicalProductModel { Title = "SSD 1Tb" });
        output.Add(new PhysicalProductModel { Title = "iPhone 15 Pro 5Tb" });

        // Digital Products
        output.Add(new DigitalProductModel { Title = "Lesson Source Code" });
        output.Add(new DigitalProductModel { Title = "Game Key Activation" });
        output.Add(new DigitalProductModel { Title = "Monthly Subscription Key" });

        // Course Products
        output.Add(new CourseProductModel { Title = "Programming For Beginners" });


        return output;
    }
}
