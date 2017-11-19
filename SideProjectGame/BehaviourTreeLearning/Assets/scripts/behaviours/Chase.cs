using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : Node
{
    bool move = true;
    bool canSeePlayer = false;


    public override void Execute()
	{
        currentState = Result.RUNNING;

        RaycastHit hit;

        if (Physics.Raycast(BT.transform.position, BT.player.transform.position, out hit))
        {
            if (hit.transform == BT.player.transform)
            {
                canSeePlayer = true;
            }
            else
            {
                canSeePlayer = false;
            }

            Debug.DrawLine(BT.transform.position, hit.point);
        }

        if(canSeePlayer)
        {
            BT.transform.LookAt(BT.player.transform);
        }
        
        if (move && canSeePlayer)
        {
			BT.transform.position = Vector3.MoveTowards(BT.transform.position, BT.player.transform.position, BT.moveSpeed * Time.deltaTime);
        }

        if (Vector3.Distance(BT.player.transform.position, BT.transform.position) < 15f)
        {
            move = false;
            currentState = Result.SUCCESS;
        }
        else
        {
            move = true;
        }

        Debug.Log("CHASE");
	}
}
