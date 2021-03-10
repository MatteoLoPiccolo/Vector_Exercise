using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorCalculator : MonoBehaviour
{
    public Vector3 _firstVector;
    public Vector3 _secondVector;

    public Vector3 Sum()
    {
        return _firstVector + _secondVector;
    }
    public Vector3 Difference()
    {
        return _firstVector - _secondVector;
    }

    public Vector3 Scalar()
    {
        return Vector3.Scale(_firstVector, _secondVector);
    }

    public Vector3 Cross()
    {
        return Vector3.Cross(_firstVector, _secondVector);
    }
}