using System;
using System.Collections.Generic;

/*
Authored By -Srikanth Chaganti 
Design Pattern considered - Factory 
IStore is an interface and example considered for 2 sample functions(Categories) Clothes and Books 
*/

// Product interface - Has a Generic method Sell() to be implemented in the derived classes
interface IStore
{
    void Sell(string item);
}

// Concrete product Called Book Store - COntains Books 
class BookStore : IStore
{
    public void Sell(string item)
    {
        Console.WriteLine($"Selling {item} at the book store.");
    }
}

// Concrete product Clothes - Contains Clothes for selling
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

// Concrete factory : derived class for Book store
class BookStoreFactory : IStoreFactory
{
    public IStore CreateStore()
    {
        //To be implemented - CRUD operations for the entire child class functions
        return new BookStore();
    }
}

// Concrete factory - derived class for Clothing store 
class ClothingStoreFactory : IStoreFactory
{
    public IStore CreateStore()
    {
        //To be implemented - CRUD operations for the entire child class functions
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
