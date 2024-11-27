using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : BaseStats
{
    private int Archerattack;
    public void Attack()
    {
        ArcherAttack -= DemonKingHealth;
        DemonKingAttack -= ArcherHealth; 
        
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(20, 400, 200, 75), "Attack"))
        {
            Attack();
        }
    }
}
