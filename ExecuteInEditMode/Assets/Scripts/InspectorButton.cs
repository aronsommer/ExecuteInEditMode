using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TestScript))]
class DecalMeshHelperEditor : Editor
{
    public override void OnInspectorGUI()
    {
        if (GUILayout.Button("Run Test Function"))
        {
            //Debug.Log("It's alive: " + target.name);
            TestScript.TestFunction();
        }
    }
}