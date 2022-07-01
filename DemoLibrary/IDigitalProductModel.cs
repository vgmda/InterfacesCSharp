using System;
namespace DemoLibrary;

public interface IDigitalProductModel : IProductModel
{
    int TotalDownloadsLeft { get; }
}

