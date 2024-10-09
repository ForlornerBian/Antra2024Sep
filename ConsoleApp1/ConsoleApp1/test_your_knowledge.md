## Understanding Data Types
### Test your Knowledge
1. What type would you choose for the following “numbers”?

| "numbers" | Type |
| --- | --- |
| A person’s telephone number | string |
| A person’s height | Float or Decimal |
| A person’s age | Integer |
| A person’s gender (Male, Female, Prefer Not To Answer) | Enum or String |
| A person’s salary | Decimal |
| A book’s ISBN | String |
| A book’s price | Decimal |
| A book’s shipping weight | Float or Decimal |
| A country’s population | Long or BigInteger |
| The number of stars in the universe | BigInteger |
| The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business) | Integer |

---

2. What are the difference between value type and reference type variables? What is
   boxing and unboxing?

- **Value Type:**
    - Stored in the stack.
    - Contains the actual value.
    - Examples: `int`, `float`, `char`, `bool`, etc.
    - When you assign one value type to another, a copy of the value is made.

- **Reference Type:**
    - Stored in the heap, but the reference (address) is stored in the stack.
    - Contains a reference to the memory location where the object is stored.
    - Examples: `class`, `array`, `string`, etc.
    - When you assign one reference type to another, both refer to the same object in memory.

**Boxing and Unboxing:**
- **Boxing:** The process of converting a value type to an object (reference type).
    - Example: `int i = 123; object o = i; // Boxing`

- **Unboxing:** The reverse process of converting an object back to a value type.
    - Example: `object o = 123; int i = (int)o; // Unboxing`

---

3. What is meant by the terms managed resource and unmanaged resource in .NET
- **Managed Resource:**
    - These are resources managed by the .NET runtime, typically memory. The Garbage Collector (GC) handles the allocation and deallocation of these resources automatically.
    - Example: Memory used by objects, arrays, strings, etc.

- **Unmanaged Resource:**
    - Resources that the .NET runtime cannot automatically manage, such as file handles, database connections, or network connections.
    - These resources require manual cleanup (using `IDisposable` and `Dispose` methods).
    - Example: File streams, GDI+ handles, etc.

---

4. Whats the purpose of Garbage Collector in .NET?

The Garbage Collector (GC) in .NET is responsible for:
- **Automatic memory management:** It automatically releases memory that is no longer in use, preventing memory leaks.
- **Deallocating objects:** It frees memory by destroying objects that are no longer reachable by the application.
- **Optimizing memory usage:** The GC organizes memory into generations (Gen 0, Gen 1, and Gen 2) and frequently cleans up objects that are no longer needed, optimizing both speed and memory usage.
- **Reducing developer effort:** It handles the complexity of memory management, so developers don’t need to manually allocate or deallocate memory.

## Controlling Flow and Converting Types
### Test your Knowledge
1. What happens when you divide an `int` variable by 0?

Dividing an `int` by 0 results in a **runtime exception** (`System.DivideByZeroException`). This is because integer division by zero is undefined in mathematics.

2. What happens when you divide a `double` variable by 0?

Dividing a `double` by 0 does not throw an exception. Instead, it results in:
- **Positive infinity** (`Double.PositiveInfinity`) if the numerator is positive.
- **Negative infinity** (`Double.NegativeInfinity`) if the numerator is negative.
- **NaN** (Not a Number) if the numerator is 0.

3. What happens when you overflow an `int` variable, that is, set it to a value beyond its range?

If an `int` variable overflows (e.g., goes beyond `Int32.MaxValue` or below `Int32.MinValue`), it **wraps around** to the other end of the range. For example:
- If you go above `Int32.MaxValue`, it wraps around to `Int32.MinValue`.
- If you go below `Int32.MinValue`, it wraps around to `Int32.MaxValue`.

```csharp
using System;

class Program
{
    static void Main()
    {
        int maxValue = int.MaxValue;
        Console.WriteLine("Max int value: " + maxValue);
        
        // This causes overflow and wraps around
        int overflowedValue = maxValue + 1;
        Console.WriteLine("Overflowed value (without checked): " + overflowedValue);
    }
}
```
Output: 
```
Max int value: 2147483647
Overflowed value (without checked): -2147483648
```

This behavior can be avoided by using `checked` keyword, which will throw an `OverflowException` in the case of overflow.

4. What is the difference between `x = y++;` and `x = ++y;`?

- **`x = y++;`**: Post-increment. The value of `y` is assigned to `x` first, then `y` is incremented by 1.
- **`x = ++y;`**: Pre-increment. `y` is incremented by 1 first, then the updated value is assigned to `x`.

5. What is the difference between `break`, `continue`, and `return` when used inside a loop statement?

- **`break`**: Immediately exits the loop, regardless of the loop’s condition.
- **`continue`**: Skips the rest of the current iteration and proceeds to the next iteration of the loop.
- **`return`**: Exits the method entirely, and control is returned to the calling method.

6. What are the three parts of a `for` statement, and which of them are required?

The three parts of a `for` loop are:
1. **Initialization** (e.g., `int i = 0;`): executed once before the loop starts.
2. **Condition** (e.g., `i < 10;`): checked before each iteration, the loop continues if true.
3. **Iteration** (e.g., `i++`): executed after each iteration to update the loop variable.

**Required parts:** Only the condition part is required. The initialization and iteration parts can be omitted.

For example, this is valid:
```csharp
for ( ; ; ) 
{
    // Infinite loop
}
```

7. What is the difference between the `=` and `==` operators?

- **`=`**: Assignment operator. It assigns the value on the right-hand side to the variable on the left-hand side.
- **`==`**: Equality operator. It compares the two operands for equality and returns `true` if they are equal and `false` if they are not.

8. Does the following statement compile? `for ( ; true; ) ;`

Yes, the statement compiles. This creates an **infinite loop** because the condition `true` is always satisfied, like the one we proposed in question 6, and the body of the loop is empty (`;` is a no-op).

9. What does the underscore `_` represent in a switch expression?

In a switch expression, the underscore `_` is used as a **discard pattern**, meaning it matches any value not explicitly matched by previous cases. It functions like a **default case** in a traditional `switch` statement.

Example:
```csharp
switch (value)
{
    case 1: return "One";
    case 2: return "Two";
    default: return "Other";  // equivalent to "_"
}
```

10. What interface must an object implement to be enumerated over by using the `foreach` statement?

To be enumerated by `foreach`, an object must implement the **`IEnumerable`** or **`IEnumerable<T>`** interface. These interfaces define a method `GetEnumerator`, which returns an enumerator that supports simple iteration over a collection.