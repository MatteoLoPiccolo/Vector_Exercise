using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(VectorDeconstruction))]
public class VectorDeconstructionEditor : Editor
{
    
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        VectorDeconstruction vectorDeconstruction = target as VectorDeconstruction;
        EditorGUILayout.LabelField("Module", vectorDeconstruction._vector.magnitude.ToString());
    }

    void OnSceneGUI()
    {
        VectorDeconstruction vectorDeconstruction = target as VectorDeconstruction;

        Handles.color = Color.red;
        Handles.DrawLine(Vector3.zero, vectorDeconstruction._vector);

        Handles.color = Color.white;
        Handles.DrawLine(Vector3.zero, Vector3.right * vectorDeconstruction._vector.x);
        Handles.color = Color.white;
        Handles.DrawLine(Vector3.zero, Vector3.up * vectorDeconstruction._vector.y);
        Handles.color = Color.white;
        Handles.DrawLine(Vector3.zero, Vector3.forward * vectorDeconstruction._vector.z);

        Handles.color = Color.blue;
        Handles.DrawLine(Vector3.zero, vectorDeconstruction._vector.normalized);
    }
}