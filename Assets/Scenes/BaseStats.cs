using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStats : MonoBehaviour
{
    protected int SwordsmanHealth = 1000;
    protected int SwordsmanAttack = 25;
    protected int SwordsmanDefense = 25;

    protected int MageHealth = 150;
    protected int MageAttack = 2;
    protected int MageDefense = 122;

    public int ArcherHealth;
    public int ArcherAttack;
    public int ArcherDefense;

    protected int DemonKingHealth = 15000;
    public int DemonKingAttack;
    public int DemonKingDefense;

    public int CompanionKnightHealth;
    public int CompanionKnightAttack;
    public int CompanionKnightDefense;

    protected string Demonkingstats;
    protected string Companionknightstats;


    public virtual void DKStats()
    {
      Demonkingstats = $"DemonKing Stats! \r\n Health: {DemonKingHealth} \r\n Attack: {DemonKingAttack} \r\n Defense: {DemonKingDefense}";
      
    }
    public virtual void CKstats()
    {
      Companionknightstats = $"Companion Knight Stats! \r\n Health: {CompanionKnightHealth} \r\n Attack: {CompanionKnightAttack} \r\n Defense: {CompanionKnightDefense}";
    }
    
}
