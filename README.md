# InterfacesCSharp

> An interface is a contract between itself and any class that implements it. This contract states that any class that implements the interface will implement the interface's properties, methods and/or events. An interface contains no implementation, only the signatures of the functionality the interface provides. An interface can contain signatures of methods, properties, indexers, and events. 

Using interface-based design concepts provides loose coupling, component-based programming, easier maintainability, makes your code base more scalable and makes code reuse much more accessible because the implementation is separated from the interface.

### Example

The code below loads sample data that I created into the interfaces called IProductModel. There are two types of products, physycal and digital. 
I then instantiate a class called Customer 

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