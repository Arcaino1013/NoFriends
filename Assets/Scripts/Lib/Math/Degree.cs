using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
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
                return Mathf.Sin((triangle.Side1.magnitude)/(triangle.Side3.magnitude / 2));
            case Triangle.Type.Scalene:
                if(triangle.Side1.magnitude >= triangle.Side2.magnitude) return Mathf.Asin((triangle.Side1.magnitude) / (triangle.Side3.magnitude));
                return Mathf.Sin((triangle.Side2.magnitude) / (triangle.Side3.magnitude));
            default: break;
        }

        return 0;
    }

    private float scaleneDegree(float oppositeLeg, float hypothenuse)
    {
        float sinA = oppositeLeg/(hypothenuse);
        return Mathf.Asin(sinA);
    }

    public static float calculateRadian(Vector2 input) 
    {
        triangle = new Triangle(input);
        return 0;
    }
}
