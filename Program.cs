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
