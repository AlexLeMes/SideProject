using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public List<Node> children = new List<Node>();

    public BehaviourTree BT;

    public enum Result { SUCCESS, RUNNING, FAILED, READY};

	public Result currentState = Result.READY;

    public void Start()
    {
        for (int i = 0; i < children.Count; i++)
        {
            children[i].BT = BT;
            children[i].Start();
        }

        if(currentState == Result.READY)
        {
            Debug.Log("CURRENT STATE = READY");
        }

        if (currentState == Result.RUNNING)
		{
			Debug.Log("CURRENT STATE = RUNNING");
		}
    }

    public virtual void Execute()
    {
        Debug.Log("IM A NODE");
    }
}
