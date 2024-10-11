namespace ExerciseGenerics;

using System;
using System.Collections.Generic;

public class MyList<T>
{
    private List<T> _list = new List<T>();

    // Add an element to the list
    public void Add(T element)
    {
        _list.Add(element);
    }

    // Remove the element at the specified index
    public T Remove(int index)
    {
        if (index < 0 || index >= _list.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range.");
        }

        T item = _list[index];
        _list.RemoveAt(index);
        return item;
    }

    // Check if the list contains the specified element
    public bool Contains(T element)
    {
        return _list.Contains(element);
    }

    // Clear the list
    public void Clear()
    {
        _list.Clear();
    }

    // Insert an element at the specified index
    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > _list.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range.");
        }

        _list.Insert(index, element);
    }

    // Delete the element at the specified index
    public void DeleteAt(int index)
    {
        if (index < 0 || index >= _list.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range.");
        }

        _list.RemoveAt(index);
    }

    // Find and return the element at the specified index
    public T Find(int index)
    {
        if (index < 0 || index >= _list.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range.");
        }

        return _list[index];
    }
}
