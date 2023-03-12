using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class Degree 
{
    static Triangle triangle;

    public static float calculateDegree(Vector2 input)
    {
        triangle = new Triangle(input);
        switch (triangle.TriangleType)
        {
            case Triangle.Type.Equilateral:
                return 60;
            case Triangle.Type.Isosceles: 
                break;
            case Triangle.Type.Scalene:
                break;
            default: break;
        }

        return 0;
    }

    public static float calculateRadian(Vector2 input) 
    {
        triangle = new Triangle(input);
        return 0;
    }
}
