using UnityEngine;
using UnityEditor;

public class Choice : ScriptableObject
{
    public string ChoiceText { get; set; }
    public int AlignmentDelta { get; set; }

    public Choice (string text, int alignmentDelta)
    {
        ChoiceText = text;
        AlignmentDelta = alignmentDelta;
    }

}