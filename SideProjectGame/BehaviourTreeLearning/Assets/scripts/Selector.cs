using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : CompositeNode
{
    //CHECKS ALL CHILDREN
    //IF ONE IS SUCCESS, IT'S SUCCESS

    public override void Execute()
    {
        for (int i = 0; i < children.Count; i++)
        {
			children[i].Execute();

			if(children[i].currentState == Result.SUCCESS)
            {
                currentState = Result.SUCCESS;
                return;
            }
            if (children[i].currentState == Result.RUNNING)
			{
				currentState = Result.RUNNING;
				return;
			}
        }

        currentState = Result.FAILED;
    }
}
