using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// TODO: Define a simple class called MyMath with the following static methods:
// * Add - adds two integers together and returns the result.
public static class MyMath
{
    public static int sumTotal = 0;

    public static int Add(int a, int b)
    {
        sumTotal += a + b;
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b; //drops off the answer right here, got it!!!!!
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Divide(int a, int b)
    {
        return a / b;
    }
}
// * Subtract - subtracts integer b from integer a and returns the result.
// * Multiply - Multiplies two integers and returns the result.
// * Divide - divides two integers and returns the result.

// TODO: In MyMath, add the following static variable:
// * sumTotal - the sum of every time the Add method is called.


public class StaticPractice : MonoBehaviour
{
    void Start()
    {
        // uncomment the following code to test your class.
        print(MyMath.Add(10, 15));
        print(MyMath.Add(13, 22));
        print(MyMath.Add(56, 83));
        print(MyMath.sumTotal); //OHHH i see other. is a place holder of a field. and Static is just- yes...

        print(MyMath.Subtract(10, 5));

        print(MyMath.Multiply(4, 8));

        print(MyMath.Divide(10, 2));
    }
}
