using UnityEditor;
using UnityEngine;
using System.IO;

/// <summary>
/// Folder creator wizard.
/// </summary>
public class FolderCreatorWizard : ScriptableWizard
{
    // Flags for folder creation.
    // Animations
    public bool CreateAnimationsFolder;
    // Materials
    public bool CreateMaterialsFolder;
    // Prefabs
    public bool CreatePrefabsFolder;
    // Resources
    public bool CreateResourcesFolder;
    // Scripts
    public bool CreateScriptsFolder;

    /// <summary>
    /// Creating and displaying wizard.
    /// </summary>
    [MenuItem("Tools/Create Default Folders")]
    public static void CreateWizard()
    {
        DisplayWizard<FolderCreatorWizard>("Create Default Folders", "Create");
    }

    /// <summary>
    /// Wizard Update.
    /// Runs when window need to be refreshed.
    /// </summary>
    private void OnWizardUpdate()
    {
        // Shows message what to do.
        helpString = "Select folders to create!";
        // Building error message if any of the selected folder exists.
        errorString = "";
        if (CreateAnimationsFolder && Directory.Exists(Path.Combine(Application.dataPath, "AnimationsFolder")))
        {
            // check is folder exist and maybe set error.
            errorString += string.Format("Folder \"{0}\" already exists!\n", "AnimationsFolder");
        }
        if (CreateMaterialsFolder && Directory.Exists(Path.Combine(Application.dataPath, "MaterialsFolder")))
        {
            // check is folder exist and maybe set error.
            errorString += string.Format("Folder \"{0}\" already exists!\n", "MaterialsFolder");
        }
        if (CreatePrefabsFolder && Directory.Exists(Path.Combine(Application.dataPath, "PrefabsFolder")))
        {
            // check is folder exist and maybe set error.
            errorString += string.Format("Folder \"{0}\" already exists!\n", "PrefabsFolder");
        }
        if (CreateResourcesFolder && Directory.Exists(Path.Combine(Application.dataPath, "ResourcesFolder")))
        {
            // check is folder exist and maybe set error.
            errorString += string.Format("Folder \"{0}\" already exists!\n", "ResourcesFolder");
        }
        if (CreateScriptsFolder && Directory.Exists(Path.Combine(Application.dataPath, "ScriptsFolder")))
        {
            // check is folder exist and maybe set error.
            errorString += string.Format("Folder \"{0}\" already exists!\n", "ScriptsFolder");
        }
        // Set flag to enable Create button.
        isValid = (CreateAnimationsFolder || CreateMaterialsFolder ||
                   CreatePrefabsFolder || CreateResourcesFolder || CreateScriptsFolder)
                    && errorString.Length == 0;
    }

    /// <summary>
    /// Method called on Create button click.
    /// Used here to create selected folder.
    /// </summary>
    private void OnWizardCreate()
    {
        // Creating paths and new folders.
        // Animations
        string path = Path.Combine(Application.dataPath, "AnimationsFolder");
        if (CreateAnimationsFolder && !Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Debug.LogFormat("Directory created: {0}", path);
        }
        // Materials
        path = Path.Combine(Application.dataPath, "MaterialsFolder");
        if (CreateMaterialsFolder && !Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Debug.LogFormat("Directory created: {0}", path);
        }
        // Prefabs
        path = Path.Combine(Application.dataPath, "PrefabsFolder");
        if (CreatePrefabsFolder && !Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Debug.LogFormat("Directory created: {0}", path);
        }
        // Resources
        path = Path.Combine(Application.dataPath, "ResourcesFolder");
        if (CreateResourcesFolder && !Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Debug.LogFormat("Directory created: {0}", path);
        }
        // Scripts
        path = Path.Combine(Application.dataPath, "ScriptsFolder");
        if (CreateScriptsFolder && !Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Debug.LogFormat("Directory created: {0}", path);
        }
        // Refresh Project view to see newly created folders.
        AssetDatabase.Refresh();
    }
}