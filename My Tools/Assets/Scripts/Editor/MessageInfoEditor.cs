using UnityEngine;
using UnityEditor;

/// <summary>
/// Custom inspector for Message Info component.
/// Additional functionality allow us to display message in editor.
/// </summary>
[CustomEditor(typeof(MessageInfo))]
public class MessageInfoEditor : Editor
{

    #region ANOTHER METHOD TO DISPLAY MESSAGE
    // Reference to the message property of the component.
    SerializedProperty messageProp;

    /// <summary>
    /// Unity method called when custom inspector is enabled.
    /// </summary>
    private void OnEnable()
    {
        // Fetching the property from the component.
        messageProp = serializedObject.FindProperty("message");
    }
    #endregion

    /// <summary>
    /// Unity method that renders component inspector.
    /// </summary>
    public override void OnInspectorGUI()
    {
        EditorGUILayout.LabelField("Default view", EditorStyles.boldLabel);
        EditorGUILayout.Space();

        // Drawning default component inspector for compare 
        DrawDefaultInspector();

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("Custom view", EditorStyles.boldLabel);
        EditorGUILayout.Space();

        // Custom editor part.
        // Getting reference to the component.
        var component = target as MessageInfo;

        // Displaying message field.
        component.message = EditorGUILayout.TextField("Message", component.message);

        #region ANOTHER METHOD TO DISPLAY MESSAGE
        // Another way to display the message.
        //EditorGUILayout.PropertyField(messageProp);
        #endregion

        // In addition, we are displaying a button to show the message.
        EditorGUILayout.Space();
        if (GUILayout.Button("Show Message!"))
        {
            // Displaying a ​message with editor dialog.
            EditorUtility.DisplayDialog("You've a new message!", component.message, "OK");
        }
    }
}