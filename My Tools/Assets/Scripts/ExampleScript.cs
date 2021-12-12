using UnityEngine;

/// <summary>
/// This class contain example of how to use "ReadOnly" attribute.
/// </summary>
public class ExampleScript : MonoBehaviour
{
    [ReadOnly]
    [SerializeField]
    private string textNonEditable = "You can't edit this text.";
    [SerializeField]
    private string textEditable = "But you definitely can edit this one.";

    [Space]

    [ReadOnly]
    [SerializeField]
    protected int numNonEditable = 23;
    [SerializeField]
    protected int numEditable = 12;

    [Space]

    [ReadOnly]
    public Vector2 vectorNonEditable = new Vector2(25, 13);
    public Vector2 vectorEditable = new Vector2(7, 3);
}