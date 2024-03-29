using System.Collections;
using System.Collections.Generic;
using Unity.Networking.Transport.Error;
using UnityEngine;

public class VectorOperations
{
    public static Vector2 rawInput(Vector2 vector)
    {
        vector.x = rawAxis(vector.x);
        vector.y = rawAxis(vector.y);
        return vector; 
    }

    public static Vector2 halfVector2(Vector2 vector)
    {
        vector.x /= 2;
        vector.y /= 2;
        return vector;
    }

    public static Vector3 rawInput(Vector3 vector)
    {
        vector.x = rawAxis(vector.x);
        vector.y = rawAxis(vector.y);
        vector.z = rawAxis(vector.z);
        return vector;
    }

    private static int rawAxis(float value)
    {
        if (value == 0) return 0;
        if (value > 0) return 1;
        if (value < 0) return -1;

        throw new System.Exception("This exception should be imposible to throw");
    }
}
