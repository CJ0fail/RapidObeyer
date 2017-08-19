using System.Collections;
using System.Collections.Generic;

public class Node
{
    public string ID { get; private set; }
    public NodeData Data { get; private set; }
    public List<string> childrenIDs = new List<string>();

    public Node (NodeData data, ModelTypes type)
    {
        // get Node with right model using factory
    }
}
