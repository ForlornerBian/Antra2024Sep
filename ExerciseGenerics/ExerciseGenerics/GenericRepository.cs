namespace ExerciseGenerics;

using System;
using System.Collections.Generic;
using System.Linq;

public class GenericRepository<T> : IRepository<T> where T : Entity
{
    private List<T> _items = new List<T>();

    // Add an item to the repository
    public void Add(T item)
    {
        _items.Add(item);
    }

    // Remove an item from the repository
    public void Remove(T item)
    {
        _items.Remove(item);
    }

    // Simulate saving the repository (e.g., to a database)
    public void Save()
    {
        Console.WriteLine("Data has been saved.");
    }

    // Get all items in the repository
    public IEnumerable<T> GetAll()
    {
        return _items;
    }

    // Find an item by its ID
    public T GetById(int id)
    {
        return _items.FirstOrDefault(item => item.Id == id);
    }
}
