using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : EnemyState
{
    public AttackState attackState;
    public bool IsInAttackRange;

    public override EnemyState RunCurrentState()
    {
        if (IsInAttackRange)
        {
            return attackState;
        }
        else
        {
            return this;
        }

        
    }
}
