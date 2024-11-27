using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : Base2
{
    protected string DKname;
    protected string ArcherName;
    protected int Archerattacks;
    protected int DKattacks;
   private string Lost;
    

    protected void Archername()
    {
        ArcherName = $"Archer Stats: \r\n Health: {ArcherHealth} \r\n Attack: {ArcherAttack} \r\n Defense: {ArcherDefense} ";
        Archerattacks = DemonKingHealth -= ArcherAttack;
        Debug.Log("Archer Attacks! \r\n Demon King Health: " +  Archerattacks);
    }

    

    public override void DKStats()
    {
        Demonkingstats = $"Demon King: \r\n Health: {DemonKingHealth} \r\n Attack: {DemonKingAttack} \r\n Defense: {DemonKingDefense} ";
        DKattacks = ArcherAttack -= DemonKingHealth;
        Debug.Log("Demon King Attacks! \r\n Archer Health: " +  DKattacks);
    }
    
        private void OnGUI()
        {
            GUI.Box(new Rect(750, 250, 400, 100), "");
            GUI.Label(new Rect(750, 250, 200, 75), Demonkingstats);
            GUI.Label(new Rect(950, 300, 200, 100), Lost);
            GUI.Label(new Rect(900, 250, 200, 75), ArcherName);


        if (GUI.Button(new Rect(20, 400, 200, 75), "Attack"))
            {
                Archername();
                DKStats();
            }
            if (ArcherHealth < 0)
            {
            Lost = "Player Lost!";
            }
            else if (DemonKingHealth < 0)
            {
            Lost = "Player Won!";
            }
   
          
        }
    }
