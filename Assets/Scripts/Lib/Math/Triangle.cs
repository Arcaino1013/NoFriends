using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle 
{
    public enum Type { Equilateral, Isosceles, Scalene}
    public enum Hypothenuse {Side1,Side2, Side3}

    protected Vector2 side1, side2, side3;
    protected Type type;
    protected Hypothenuse hypothenuse;

    public Triangle(Vector2 input)
    {
        side1 = new Vector2(0, 1);
        side2 = input;
        side3 = side1 - side2;
        SetHypothenuse();
        //Debug.Log("Side1 = " + side1);
        //Debug.Log("Side2 = " + side2);
        //Debug.Log("Side3 = " + side3);
    }

    public Triangle(Vector2 side1, Vector2 side2)
    {
        this.side1 = side1;
        this.side2 = side2;
        side3 =side1 - side2;
        SetHypothenuse();
    }

    private void SetHypothenuse()
    {
        //Determines the Type of Triangle we are working with
        if(side1.magnitude == side2.magnitude && side3.magnitude == side1.magnitude) { type = Type.Equilateral; return; }
        if(side1.magnitude == side3.magnitude) { type = Type.Isosceles; return; }
        //If you dont enter in both ifs the Triangle is of the Type Scalene an has a Hyposthenuse
        type = Type.Scalene;
        if(side1.magnitude > side2.magnitude)
        {
            if(side1.magnitude > side3.magnitude) { hypothenuse= Hypothenuse.Side1; return;}
        }
        if(side2.magnitude > side3.magnitude) { hypothenuse = Hypothenuse.Side2; return;}
        hypothenuse= Hypothenuse.Side3; return;
    }

    public Type TriangleType { get { return type; } }

    public Vector2 Side1 { get { return side1; } }
    public Vector2 Side2 { get { return side2; } }                                                                                                                                                                                                                                                                         
    public Vector2 Side3 { get { return side3; } }

}
