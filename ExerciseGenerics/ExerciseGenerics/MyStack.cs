namespace ExerciseGenerics;

using System;
using System.Collections.Generic;

public class MyStack<T>
{
    private List<T> _stack = new List<T>();

    // Return the number of elements in the stack
    public int Count()
    {
        return _stack.Count;
    }

    // Remove and return the top element of the stack
    public T Pop()
    {
        if (_stack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T item = _stack[_stack.Count - 1];
        _stack.RemoveAt(_stack.Count - 1);
        return item;
    }

    // Push an element onto the stack
    public void Push(T item)
    {
        _stack.Add(item);
    }
}
