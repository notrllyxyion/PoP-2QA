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
    protected string CK;
    protected int CKattacks;

    public  override void CKstats()
    {
        CK = $"Companion Knight Stats! \r\n Health: {CompanionKnightHealth} \r\n Attack: {CompanionKnightAttack} \r\n Defense: {CompanionKnightDefense}";
        CKattacks = CompanionKnightHealth -= DemonKingAttack;
    }

    protected void Archername()
    {
        ArcherName = $"Archer Stats: \r\n Health: {ArcherHealth} \r\n Attack: {ArcherAttack} \r\n Defense: {ArcherDefense} ";
        Archerattacks = ArcherHealth -= DemonKingAttack;
        Debug.Log("Archer Attacks! \r\n Demon King Health: " +  DemonKingHealth);
    }

    

    public override void DKStats()
    {
        Demonkingstats = $"Demon King: \r\n Health: {DemonKingHealth} \r\n Attack: {DemonKingAttack} \r\n Defense: {DemonKingDefense} ";
        DKattacks = DemonKingHealth -= ArcherAttack;
        DKattacks = DemonKingHealth -= CompanionKnightAttack;
        Debug.Log("Demon King Attacks! \r\n Archer Health: " +  ArcherHealth);
    }
    
        private void OnGUI()
        {
             
              
              GUI.Box(new Rect(750, 250, 400, 100), "");



        if (GUI.Button(new Rect(20, 400, 200, 75), "Attack"))
            {
                Archername();
                DKStats();
              CKstats();
            }
            if (ArcherHealth < 0)
            {
            Lost = "Player Lost!";
            Debug.Log("Player Lost! " + Lost);
            }
            else if (DemonKingHealth < 0)
            {
            Lost = "Player Won!";
            Debug.Log("Player Won! " + Lost);
            }
        GUI.Label(new Rect(750, 250, 200, 75), Demonkingstats);
        GUI.Label(new Rect(950, 500, 200, 100), Lost);
        GUI.Label(new Rect(900, 250, 200, 75), ArcherName);
        GUI.Label(new Rect(750, 350, 200, 75), CK);

    }
    }
