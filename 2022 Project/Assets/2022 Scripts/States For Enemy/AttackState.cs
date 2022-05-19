using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : EnemyState
{
    public override EnemyState RunCurrentState()
    {
        Debug.Log("I Have Attack");
        return this;
    }
}
