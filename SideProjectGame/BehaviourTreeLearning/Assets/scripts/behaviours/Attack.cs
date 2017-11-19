using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : Node 
{

    float damage = 10f;

    public override void Execute()
    {
        currentState = Result.RUNNING;

        BT.shoot();

        

        Debug.Log("ATTACK");
    }
	
}
