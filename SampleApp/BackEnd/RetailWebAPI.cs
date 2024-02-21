using System;
using System.Collections.Generic;

// Product interface
interface IStore
{
    void Sell(string item);
}

// Concrete product
class BookStore : IStore
{
    public void Sell(string item)
    {
        Console.WriteLine($"Selling {item} at the book store.");
    }
}

// Concrete product
class ClothingStore : IStore
{
    public void Sell(string item)
    {
        Console.WriteLine($"Selling {item} at the clothing store.");
    }
}

// Factory interface
interface IStoreFactory
{
    IStore CreateStore();
}

// Concrete factory
class BookStoreFactory : IStoreFactory
{
    public IStore CreateStore()
    {
        return new BookStore();
    }
}

// Concrete factory
class ClothingStoreFactory : IStoreFactory
{
    public IStore CreateStore()
    {
        return new ClothingStore();
    }
}

// Client class
class RetailStore
{
    static void Main(string[] args)
    {
        // List of store factories
        List<IStoreFactory> storeFactories = new List<IStoreFactory>
        {
            new BookStoreFactory(),
            new ClothingStoreFactory()
        };

        // Create and operate multiple stores
        foreach (var factory in storeFactories)
        {
            IStore store = factory.CreateStore();
            store.Sell("item");
        }
    }
}
