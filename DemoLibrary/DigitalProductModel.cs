using System;
namespace DemoLibrary;

public class DigitalProductModel
{
    public string Title { get; set; }

    public void ShipItem(CustomerModel customer)
    {
        Console.WriteLine($"Simulating emailing {Title} to {customer.EmailAddress}");
    }
}

