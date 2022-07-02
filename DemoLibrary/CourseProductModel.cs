using System;
namespace DemoLibrary;

public class CourseProductModel : IProductModel
{
    public string Title { get; set; }

    public bool HasOrderBeenCompleted { get; private set; }

    public void ShipItem(CustomerModel customer)
    {
        if (!HasOrderBeenCompleted)
        {
            Console.WriteLine($"Added the {Title} course to {customer.FirstName}'s account.");
            HasOrderBeenCompleted = true;
        }
    }
}

