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

    private static int rawAxis(float value)
    {
        if (value == 0) return 0;
        if (value > 0) return 1;
        if (value < 0) return -1;

        throw new System.Exception("This exception should be imposible to throw");
    }
}
