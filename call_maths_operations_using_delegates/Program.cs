/*
 *  C# Program to Call Math Operations using Delegates
 */

using System;

static class MathOperations
{
    public static double Multiply(double value)
    {
        return value * 2;
    }

    public static double Square(double value)
    {
        return value * value;
    }
}

delegate double DoubleOp(double x);

class Application
{
    static void Main()
    {
        DoubleOp[] operations =
            {
               MathOperations.Multiply,
               MathOperations.Square
            };

        for (int i = 0; i < operations.Length; i++)
        {
            Console.WriteLine("Operation[{0}]:", i);
            ProcessAndDisplayNumber(operations[i], 5.0);
            ProcessAndDisplayNumber(operations[i], 13.55);
            ProcessAndDisplayNumber(operations[i], 1.732);
            Console.WriteLine();
        }
        Console.ReadLine();
    }