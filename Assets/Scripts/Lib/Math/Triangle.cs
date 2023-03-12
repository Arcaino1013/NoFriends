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
        side2 = input.normalized;
        side3 = side2 - side1;
    }

    public Triangle(Vector2 side1, Vector2 side2)
    {
        this.side1 = side1.normalized;
        this.side2 = side2.normalized;
        side3 = side2 - side1;
    }

    private void SetHypothenuse()
    {
        //Determines the Type of Triangle we are working with
        if(side3.magnitude == side2.magnitude && side3.magnitude == side1.magnitude) { type = Type.Equilateral; return; }
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

}
