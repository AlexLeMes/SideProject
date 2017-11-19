using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequencer : CompositeNode 
{
	//CHECKS ALL CHILDREN
	//IF ONE IS FAIL, IT'S FAIL

	public override void Execute()
    {
		for (int i = 0; i < children.Count; i++)
		{
            children[i].Execute();

            if (children[i].currentState == Result.FAILED)
			{
                currentState = Result.FAILED;
                return;
			}

            if (children[i].currentState == Result.RUNNING)
			{
                currentState = Result.RUNNING;
				return;
			}

            currentState = Result.SUCCESS;

		}
    }
	
}
