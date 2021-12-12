using UnityEngine;
using UnityEditor;

/// <summary>
/// Custom inspector drawer for AssetPreviewGrid script.
/// Adds button to the Inspector and menu item.
/// </summary>
[CustomEditor(typeof(AssetPreviewGrid))]
public class AssetPreviewGridEditor : Editor
{
    /// <summary>
    /// Unity method which draws Inspector.
    /// </summary>
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        // Add space between parameters and the button.
        EditorGUILayout.Space();

        // Button for rearranging elements.
        if (GUILayout.Button("Rearrange elements"))
        {
            var placer = target as AssetPreviewGrid;
            placer.RearrangeElements();
        }
    }
}