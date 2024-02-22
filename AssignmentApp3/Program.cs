//1.
// Access Modifers:
// Public: Members can be accessed anywhere
// Private: members can be accessed only in current class.
// Internal: members can be accesssed in current assembly
// Protected: members can be accessed in current class and children classes
// protected internal: Access is limit to the current assembly or types derived from the containing class.
// private protected: Access is limited to the containing class or types derived from the containing class within the current assembly.

//2.
// static: Belongs to the type itself rather than an instance of the type. Can be accessed without an instance of the class.
// const: A compile-time constant. Its value must be assigned at declaration and cannot be changed.
// readonly: Can be assigned at declaration or in the constructor of the class in which it is declared. Its value is runtime constant.

//3.
// A constructor is a special method of a class that initializes new objects or instances of the class.

//4.
// The partial keyword allows the definition of a class, struct, or method to be split into multiple files. This is useful for managing large classes or collaborating on projects.
//5. 
// A tuple is a data structure that holds a sequence of elements of different types. It can be used to return multiple values from a method without using out parameters. Tuple is immutable
//6.
//record is used to define a reference type that provides built-in functionality for encapsulating data. It is primarily intended for immutable objects and supports value-based equality checks.
//7.
//Overloading: Defining multiple methods in the same scope with the same name but different parameters.
// Overriding: Redefining a method of a base class in a derived class.
//8.
// A field is a variable declared directly in a class or struct.
// A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field.
//9.
//We can make a method parameter optional by providing a default value in the method declaration.
//10.
// 1. Abstract class provides a base class to its subclasses - use it when we have clear class hierarchy;
// interface defines common behaviors that can be implemented by any class

// 2. One class only inherit from one abstract class/concrete class but one class can implement multiple interfaces

//11.
// Members of an interface are implicitly public.
//12. True
//13. True
//14. False
//15. False
//16. True
//17. True
//18. True
//19. False
//20. False
//21. True
//22. False
//23. True

//Working with methods
//1.

using AssignmentApp3;

Question1 q1 = new Question1();
Question2 q2 = new Question2();
int[] numbers = q1.GenerateNumbers();
q1.Reverse(numbers);
q1.PrintNumbers(numbers);
Console.WriteLine();
Console.WriteLine(q2.Fibonacci(8));

//Designing and Building Classes using object-oriented principles
// They are in Repositories, DataModel, and Presentation Directory, for time issus, I only show Instructor management Implementation, but they are pretty much the same.

//7.

Color color = new Color(255,255,255,255);
Ball ball = new Ball(10,color,2);
for(int i=0;i<9;i++){
    ball.Throw();
}
Console.WriteLine(ball.GetTimes());
ball.Pop();
ball.Throw();
Console.WriteLine(ball.GetTimes());





