using UnityEngine;
using UnityEditor;
using System;
using System.Collections.Generic;

public class MultiChoiceModel : NodeData
{
    public List<Choice> Choices;

    public MultiChoiceModel(List<Choice> choices)
    {
        Choices = choices;
    }
}