using System;
namespace DemoLibrary;


// Interface (Contract) - not inheritance
public interface IProductModel
{

    // Signatures
    string Title { get; set; }

    bool HasOrderBeenCompleted { get; }

    void ShipItem(CustomerModel customer);
}

