### Test Your Knowledge

#### 1. Describe the problem generics address.
Generics address the problem of **type safety** and **code reuse** by allowing you to define classes, methods, and data structures that work with any data type without sacrificing performance or safety. Generics reduce the need for type casting and eliminate the risk of runtime errors related to type mismatches, while avoiding code duplication for different types.

#### 2. How would you create a list of strings, using the generic `List` class?
```csharp
List<string> myStringList = new List<string>();
```

#### 3. How many generic type parameters does the `Dictionary` class have?
The `Dictionary` class has **two** generic type parameters: one for the key type and one for the value type. Example:
```csharp
Dictionary<TKey, TValue>
```

#### 4. **True**/False. When a generic class has multiple type parameters, they must all match.
**False**. Multiple generic type parameters can represent different types. For example, in `Dictionary<TKey, TValue>`, the `TKey` and `TValue` can be different types.

#### 5. What method is used to add items to a `List` object?
The `Add` method is used to add items to a `List`. Example:
```csharp
myStringList.Add("Hello");
```

#### 6. Name two methods that cause items to be removed from a `List`.
- **`Remove(item)`**: Removes the first occurrence of the specified item.
- **`RemoveAt(index)`**: Removes the item at the specified index.

#### 7. How do you indicate that a class has a generic type parameter?
You indicate a generic type parameter by using angle brackets (`<>`) after the class name. Example:
```csharp
public class MyClass<T>
{
    // Class definition using the generic type T
}
```

#### 8. True/**False**. Generic classes can only have one generic type parameter.
**False**. A generic class can have multiple generic type parameters. Example:
```csharp
public class MyClass<T1, T2>
{
    // Class with two generic type parameters
}
```

#### 9. **True**/False. Generic type constraints limit what can be used for the generic type.
**True**. Generic type constraints restrict the types that can be used as arguments for the generic type. For example:
```csharp
public class MyClass<T> where T : IComparable
{
    // T must implement IComparable
}
```

#### 10. **True**/False. Constraints let you use the methods of the thing you are constraining to.
**True**. When you constrain a generic type to a specific class or interface, you are allowed to use the methods and properties of that class or interface within the generic class or method. Example:
```csharp
public class MyClass<T> where T : IDisposable
{
    public void DisposeItem(T item)
    {
        item.Dispose(); // Can call Dispose because T implements IDisposable
    }
}
```