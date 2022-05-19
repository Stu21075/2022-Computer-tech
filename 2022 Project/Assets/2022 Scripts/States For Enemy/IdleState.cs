using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : EnemyState
{
    public ChaseState chaseState;
    public bool canSeePlayer;

    public override EnemyState RunCurrentState()
    {
        if(canSeePlayer)
        {
            return chaseState;
        }
        else
        {
            return this;
        }
        
    }
}
