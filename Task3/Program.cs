using System;

class Program
{
    static void Main()
    {
        Quaternion q1 = new Quaternion(1, 2, 3, 4);
        Quaternion q2 = new Quaternion(5, 6, 7, 8);

        Quaternion sum = q1 + q2;
        Console.WriteLine($"Sum: {sum}");

        Quaternion difference = q1 - q2;
        Console.WriteLine($"Difference: {difference}");

        Quaternion product = q1 * q2;
        Console.WriteLine($"Product: {product}");

        double magnitude = q1.Magnitude();
        Console.WriteLine($"Magnitude of q1: {magnitude}");

        Quaternion conjugate = q1.Conjugate();
        Console.WriteLine($"Conjugate of q1: {conjugate}");
    }
}
