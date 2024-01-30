Operator overloading in C# allows you to define how operators such as `+`, `-`, `*`, `/`, etc., behave with custom types. This feature enables you to make your classes more intuitive and expressive by defining meaningful behavior for these operators when applied to objects of your class.

Here's a basic example of how operator overloading works in C#:

```csharp
using System;

public class Vector2D
{
    public int X { get; set; }
    public int Y { get; set; }

    public Vector2D(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Overloading the + operator to add two Vector2D objects
    public static Vector2D operator +(Vector2D v1, Vector2D v2)
    {
        return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
    }

    // Overloading the * operator to scalar multiply a Vector2D object
    public static Vector2D operator *(Vector2D v, int scalar)
    {
        return new Vector2D(v.X * scalar, v.Y * scalar);
    }

    // Overloading the * operator to scalar multiply a Vector2D object (reverse order)
    public static Vector2D operator *(int scalar, Vector2D v)
    {
        return v * scalar; // Reuse the existing operator
    }

    // Overriding the ToString method for better string representation
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class Program
{
    static void Main()
    {
        Vector2D v1 = new Vector2D(1, 2);
        Vector2D v2 = new Vector2D(3, 4);

        // Using the overloaded + operator
        Vector2D result1 = v1 + v2;
        Console.WriteLine("Addition result: " + result1); // Output: (4, 6)

        // Using the overloaded * operator
        Vector2D result2 = v1 * 2;
        Console.WriteLine("Scalar multiplication result: " + result2); // Output: (2, 4)
    }
}
```

In this example, the `Vector2D` class overloads the `+` and `*` operators to define addition and scalar multiplication for vectors. This allows for more natural and intuitive use of these operators with `Vector2D` objects.
