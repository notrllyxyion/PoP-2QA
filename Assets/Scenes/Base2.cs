using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Base2 : Archer, Mage , Swordsman
{
    private string Statshow;

    public override void Stats()
    {
        Statshow = $"Archer Stats: \r\n \r\n Health: {ArcherHealth} \r\n Attack: {ArcherAttack} \r\n Defense: {ArcherDefense}";
    }
    public void magee()
    {
        Statshow = $"Mage Stats: \r\n \r\nHealth: {MageHealth} \r\n Attack: {MageAttack} \r\n Defense: {MageDefense}";
    }
    
    public void Swoordsman()
    {
        Statshow = $"Swordsman Stats: \r\n \r\n Health: {SwordsmanHealth} \r\n Attack: {SwordsmanAttack} \r\n Defense: {SwordsmanDefense}";
    }

    public override void steets()
    {
        base.steets();
    }
    public override void CKstats()
    {
        base.CKstats();
    }


    private void Start()
    {
        steets();
        CKstats();
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 1350, 650), "STAAAAAAAATS");

        if (GUI.Button(new Rect(20, 100, 200, 75), "Mage"))
        {
           magee();
        }
        if (GUI.Button(new Rect(20,200, 200, 75), "Swordsman"))
        {
            Swoordsman();
        }
        if (GUI.Button(new Rect(20, 300, 200, 75), "Archer"))
        {
            Stats();
        }

        if (GUI.Button(new Rect(20, 400, 200, 75), "Attack"))
        {
            
        }


        GUI.Label(new Rect(750, 150, 200, 80), Statshow);
        GUI.Label(new Rect(750, 250, 200, 75), Demonkingstats);
        GUI.Label(new Rect(750, 350, 200, 75), Companionknightstats);
    }
}
