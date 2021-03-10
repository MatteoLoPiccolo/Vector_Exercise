using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(VectorCalculator))]
public class VectorCalculateEditor : Editor
{
    void OnSceneGUI()
    {
        VectorCalculator vectorCalculator = target as VectorCalculator;

        Handles.color = Color.white;
        Handles.DrawLine(Vector3.zero, vectorCalculator._firstVector);
        Handles.color = Color.white;
        Handles.DrawLine(Vector3.zero, vectorCalculator._secondVector);
        //Handles.DrawLine(Vector3.zero, vectorCalculator._secondVector);

        Handles.color = Color.green;
        Handles.DrawLine(Vector3.zero, vectorCalculator.Sum());

        Handles.color = Color.red;
        Handles.DrawLine(Vector3.zero, vectorCalculator.Scalar());

        Handles.color = Color.yellow;
        Handles.DrawLine(Vector3.zero, vectorCalculator.Difference());

        Handles.color = Color.blue;
        Handles.DrawLine(Vector3.zero, vectorCalculator.Cross());
    }
}