using UnityEngine;
using UnityEditor;

/// <summary>
/// Custom window class that is displaying sample editor window.
/// </summary>
public class CustomWindow : EditorWindow
{
    // Sample variables that are used to display editing in the window.
    private bool checkbox;
    private float number;
    private string textSample;
    private int clickCount;

    private int selectionGridInt = 0;
    private string[] selectionGridStrings = { "Raz", "Dwa", "Trzy", "Cztery" };

    // Add menu named "Custom Window" to the menu.
    [MenuItem("Window/Custom Window")]


    /// <summary>
    /// Method called to show window.
    /// </summary>
    public static void ShowWindow()
    {
        // Get existing open window or if none, make a new one:
        var window = GetWindow(typeof(CustomWindow));
        window.Show();
    }

    /// <summary>
    /// Unity method that renders editor window.
    /// </summary>
    private void OnGUI()
    {
        EditorGUILayout.LabelField("Simple Custom Window", EditorStyles.boldLabel);

        // Sample variables displayed in the window.
        checkbox = EditorGUILayout.Toggle("Sample checkbox", checkbox);
        number = EditorGUILayout.Slider("Sample slider", number, 0, 10);
        textSample = EditorGUILayout.TextField("Sample text", textSample);

        // Displaying button with click count.
        if (GUILayout.Button(string.Format("You've clicked me {0} times!", clickCount)))
        {
            clickCount++;
        }

        selectionGridInt = GUI.SelectionGrid(new Rect(4, 115, 200, 130), selectionGridInt, selectionGridStrings, 1);

        if(selectionGridInt == 0)
        {
            textSample = selectionGridStrings[0];
        }

        if (selectionGridInt == 1)
        {
            textSample = selectionGridStrings[1];
        }

        if (selectionGridInt == 2)
        {
            textSample = selectionGridStrings[2];
        }

        if (selectionGridInt == 3)
        {
            textSample = selectionGridStrings[3];
        }
    }
}
