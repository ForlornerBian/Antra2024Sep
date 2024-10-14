# C# Prep

### 1. **Reference Type vs. Value Type**
   - **Value Type**: Stores data directly, and variables hold actual values. Examples: `int`, `double`, `struct`.
   - **Reference Type**: Stores a reference to the data's memory address. Examples: `class`, `string`, `object`.
   - **Difference**: Value types are stored on the stack, whereas reference types are stored on the heap.

### 2. **Boxing vs. Unboxing**
   - **Boxing**: Converting a value type to a reference type (e.g., `int` to `object`).
   - **Unboxing**: Extracting a value type from a reference type (e.g., casting `object` back to `int`).
   - **Example**: 
     ```csharp
     int i = 123;
     object o = i; // Boxing
     int j = (int)o; // Unboxing
     ```

### 3. **Four Principles of OOP in C#**

   1. **Encapsulation**: Hiding internal state and requiring interaction through methods.
      - **Why**: Improves security, simplifies maintenance.
      - **Example**: Using private fields and public methods.
   2. **Abstraction**: Simplifying complex realities by modeling classes appropriate to the problem.
      - **Why**: Reduces complexity by focusing on essential details.
      - **Example**: Abstract classes and interfaces.
   3. **Inheritance**: Deriving new classes from existing ones to promote code reuse.
      - **Why**: Allows you to reuse code and extend functionalities.
      - **Example**: A `Car` class inherits from a `Vehicle` class.
   4. **Polymorphism**: Allowing methods to do different things based on the object it is acting upon.
      - **Why**: Increases flexibility and reusability.
      - **Example**: Overriding methods in derived classes.

#### Subtopics:
   1. **Different Access Modifiers**: 
      - `public`, `private`, `protected`, `internal`, `protected internal`, `private protected`.
   2. **Overriding vs. Overloading**:
      - **Overloading**: Multiple methods with the same name but different signatures (compile-time).
      - **Overriding**: Redefining a method in a derived class (runtime).
   3. **Multiple Inheritance in C#**:
      - C# doesn't support multiple inheritance for classes but allows it for interfaces.
   4. **Virtual Method vs. Abstract Method**:
      - **Virtual Method**: Has a base implementation, can be overridden.
      - **Abstract Method**: Declared without an implementation in an abstract class.
   5. **Abstract Class vs. Interface**:
      - **Abstract Class**: Can have both abstract and non-abstract methods, supports inheritance.
      - **Interface**: Only has method declarations, no implementation. Use interface when you need multiple inheritance or to define behavior across unrelated classes.

### 4. **What Does a Constructor Do? Can It Be Overridden or Overloaded?**
   - **Constructor**: Initializes objects of a class.
   - **Overriding**: Not allowed.
   - **Overloading**: Yes, constructors can be overloaded to accept different parameters.

### 5. **Static Keyword**
   - **Static Keyword**: Belongs to the type itself rather than any instance. Static members/methods can be accessed without creating an object of the class.

### 6. **Delegates in C#**
   - A delegate is a type that represents references to methods with a particular parameter list and return type.
   - **Built-in Delegates**: `Action<>`, `Func<>`, `Predicate<>`.
   - **Example**:
     ```csharp
     public delegate void MyDelegate(string message);
     ```

### 7. **Extension Method**
   - Allows you to add new methods to existing types without modifying the type itself.
   - **Built-in Example**: `string.Join()`, `string.IsNullOrEmpty()`.
   - **Custom Extension Example**:
     ```csharp
     public static class StringExtensions
     {
         public static int WordCount(this string str)
         {
             return str.Split(' ').Length;
         }
     }
     ```

### 8. **Ref vs. Out vs. Params**
   - **Ref**: Passes a variable by reference; the variable must be initialized before passing.
   - **Out**: Passes by reference, but the variable doesn't need to be initialized.
   - **Params**: Allows passing a variable number of arguments to a method.

### 9. **Pass by Reference vs. Pass by Value**
   - **Pass by Value**: A copy of the data is passed, and modifications don't affect the original value.
   - **Pass by Reference**: The reference to the data is passed, and changes to the parameter affect the original value.

### 10. **Array vs. ArrayList**
   - **Array**: Fixed size, can only store elements of the same data type.
   - **ArrayList**: Resizable, can store different data types (non-generic).

### 11. **Handling Exceptions in C#**
   - Syntax:
     ```csharp
     try
     {
         // code that might throw an exception
     }
     catch (Exception ex)
     {
         // handle exception
     }
     finally
     {
         // code that will always execute
     }
     ```

### 12. **Generics in C#**
   - Generics allow for type safety while enabling code reusability.
   - **Syntax**:
     ```csharp
     public class MyGenericClass<T>
     {
         public void GenericMethod(T param) { }
     }
     ```
   - **Constraints**: Can limit the type by using `where T : struct`, `class`, etc.

### 13. **Generic Collection vs. Non-Generic Collection**
   - **Generic Collection**: Type-safe, e.g., `List<T>`, `Dictionary<TKey, TValue>`.
   - **Non-Generic Collection**: Not type-safe, e.g., `ArrayList`, `Hashtable`.

### 14. **What is LINQ? Why Use It?**
   - **LINQ** (Language Integrated Query): Provides a consistent way to query various data sources (arrays, collections, databases).
   - **Why Use**: Simplifies querying, filtering, and data manipulation with cleaner and more readable code.

### 15. **IEnumerable vs. IQueryable**
   - **IEnumerable**: Works in memory and supports deferred execution. Suitable for in-memory collections.
   - **IQueryable**: Supports deferred execution and is suitable for querying out-of-memory data (e.g., databases).

### 16. **First, FirstOrDefault, Single, SingleOrDefault**
   - **First()**: Returns the first element, throws an exception if not found.
   - **FirstOrDefault()**: Returns the first element or default value if not found.
   - **Single()**: Returns the only element, throws an exception if more than one or none is found.
   - **SingleOrDefault()**: Returns the only element or default value, throws an exception if more than one is found.

### 17. **Any() vs. All()**
   - **Any()**: Returns `true` if any element matches a condition.
   - **All()**: Returns `true` if all elements match a condition.

### 18. **Pagination in LINQ**
   - Use `Skip()` and `Take()` to implement pagination:
     ```csharp
     var result = data.Skip(pageSize * (pageNumber - 1)).Take(pageSize);
     ```

### 19. **Deferred Execution vs. Immediate Execution**
   - **Deferred Execution**: The query is not executed until the data is actually requested (e.g., `IEnumerable`).
   - **Immediate Execution**: The query is executed immediately, and the result is stored (e.g., `ToList()`).