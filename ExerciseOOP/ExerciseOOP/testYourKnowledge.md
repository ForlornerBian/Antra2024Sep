### Test Your Knowledge

#### 1. What are the six combinations of access modifier keywords and what do they do?
- **`public`**: The member is accessible from anywhere.
- **`private`**: The member is accessible only within the class it is declared.
- **`protected`**: The member is accessible within the class it is declared and by derived classes.
- **`internal`**: The member is accessible within the same assembly but not from another assembly.
- **`protected internal`**: The member is accessible from the current assembly or any derived classes, even in other assemblies.
- **`private protected`**: The member is accessible only within the class it is declared and by derived classes within the same assembly.

#### 2. What is the difference between the `static`, `const`, and `readonly` keywords when applied to a type member?
- **`static`**: The member belongs to the type itself rather than to a specific instance of the type. It can be accessed without creating an instance of the class.
- **`const`**: The value is set at compile time and cannot be changed. It must be initialized where it is declared.
- **`readonly`**: The value can be set at runtime but only in the constructor or at the point of declaration. Once set, it cannot be modified.

#### 3. What does a constructor do?
A **constructor** initializes an object of a class. It is called automatically when an object is created and is used to set initial values for fields or properties of the class.

#### 4. Why is the `partial` keyword useful?
The **`partial`** keyword allows a class, struct, or interface to be split across multiple files. This can be useful for organizing code, especially in large projects or when different parts of the class are generated automatically by tools.

#### 5. What is a tuple?
A **tuple** is a data structure that allows you to group multiple elements of different types into a single unit. For example: `(int, string) tuple = (1, "hello");`

#### 6. What does the C# `record` keyword do?
The **`record`** keyword defines a reference type that provides built-in functionality for value-based equality, immutability, and concise syntax for defining objects. Records are typically used for data models where you care more about the content of the object than its identity.

#### 7. What does overloading and overriding mean?
- **Overloading**: Defining multiple methods in the same class with the same name but different parameter lists (i.e., different signatures).
- **Overriding**: Providing a new implementation for a method that is inherited from a base class, typically when the method is marked as `virtual` or `abstract` in the base class.

#### 8. What is the difference between a field and a property?
- **Field**: A field is a variable that is declared directly in a class. It holds data.
- **Property**: A property is a member that provides controlled access (get/set) to a field. Properties can include logic to validate data or trigger events.

#### 9. How do you make a method parameter optional?
You can make a method parameter optional by providing a **default value** for it. For example:
```csharp
void MyMethod(int x = 10) { }
```

#### 10. What is an interface and how is it different from an abstract class?
- **Interface**: An interface defines a contract that classes must implement, but it does not provide any implementation itself. A class can implement multiple interfaces.
- **Abstract class**: An abstract class can have method implementations and abstract methods. A class can inherit from only one abstract class.

#### 11. What accessibility level are members of an interface?
Interface members are **public** by default, and they do not have explicit access modifiers.

#### 12. **True**/False. Polymorphism allows derived classes to provide different implementations of the same method.
- **True**.

#### 13. **True**/False. The `override` keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
- **True**.

#### 14. **True**/False. The `new` keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
- **False**. The `new` keyword hides a method in the base class but does not override it.

#### 15. True/**False**. Abstract methods can be used in a normal (non-abstract) class.
- **False**. Abstract methods can only be declared in abstract classes.

#### 16. **True**/False. Normal (non-abstract) methods can be used in an abstract class.
- **True**.

#### 17. **True**/False. Derived classes can override methods that were virtual in the base class.
- **True**.

#### 18. **True**/False. Derived classes can override methods that were abstract in the base class.
- **True**.

#### 19. True/**False**. In a derived class, you can override a method that was neither virtual nor abstract in the base class.
- **False**. You can only override methods that are marked as `virtual`, `abstract`, or `override` in the base class.

#### 20. True/**False**. A class that implements an interface does not have to provide an implementation for all of the members of the interface.
- **False**. A class that implements an interface must provide an implementation for all interface members.

#### 21. **True**/False. A class that implements an interface is allowed to have other members that aren’t defined in the interface.
- **True**.

#### 22. True/**False**. A class can have more than one base class.
- **False**. C# does not support multiple inheritance for classes, but it does for interfaces.

#### 23. **True**/False. A class can implement more than one interface.
- **True**.