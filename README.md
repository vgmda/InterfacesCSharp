# InterfacesCSharp

> An interface is a contract between itself and any class that implements it. This contract states that any class that implements the interface will implement the interface's properties, methods and/or events. An interface contains no implementation, only the signatures of the functionality the interface provides. An interface can contain signatures of methods, properties, indexers, and events. 

Using interface-based design concepts provides loose coupling, component-based programming, easier maintainability, makes your code base more scalable and makes code reuse much more accessible because the implementation is separated from the interface.

### Example

The code below loads sample data that I created into the interfaces called IProductModel. There are two types of products, physical and digital. 
I then create a class object called Customer and populate it with test data. The purpose of the foreach is to loop through each product within the cart and execute ShipItem() which simulates the shipping by outputting a message.
```c#
static void Main()
{
    List<IProductModel> cart = AddSampleData();
    CustomerModel customer = GetCustomer();

    foreach (IProductModel prod in cart)
    {
        prod.ShipItem(customer);
    }
}
```

### Importance of interfaces

`PhysicalProductModel` consists of signatures that are implemented from `IProductModel` but then are expanded. 

```c#
public class PhysicalProductModel : IProductModel
{
    public string Title { get; set; }

    public bool HasOrderBeenCompleted { get; private set; }

    public void ShipItem(CustomerModel customer)
    {
        if (HasOrderBeenCompleted == false)
        {
            Console.WriteLine($"Simulating shipping {Title} to {customer.FirstName} in {customer.City}");
            HasOrderBeenCompleted = true;
        }
    }
}
```
`DigitalProductModel` consists of signatures that are implemented from `IDigitalProductModel` but then are expanded.

```c#
public class DigitalProductModel : IDigitalProductModel
{
    public string Title { get; set; }

    public bool HasOrderBeenCompleted { get; private set; }

    public int TotalDownloadsLeft { get; private set; } = 5;

    public void ShipItem(CustomerModel customer)
    {
        if (HasOrderBeenCompleted == false)
        {

            Console.WriteLine($"Simulating emailing {Title} to {customer.EmailAddress}");
            TotalDownloadsLeft -= 1;
            if (TotalDownloadsLeft < 1)
            {
                HasOrderBeenCompleted = true;
                TotalDownloadsLeft = 0;
            }
        }
    }
}
```

Both models are implementing an interface according to their product type. 

Within `Program.cs` I populate the `List<IProductModel>`:
```c#
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
```
This allows us to distinguish between different types of products. (e.g Physical, Digital, Course)
Each product has its own Model: `PhysicalProductModel.cs`, `DigitalProductModel`, `CourseProductModel`, therefore each model implements a corresponding interface in order to inherit signatures that are required for each product model to function.
