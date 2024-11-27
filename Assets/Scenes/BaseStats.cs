using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStats : MonoBehaviour
{
    public int SwordsmanHealth;
    public int SwordsmanAttack;
    public int SwordsmanDefense;

    public int MageHealth;
    public int MageAttack;
    public int MageDefense;

    public int ArcherHealth;
    public int ArcherAttack;
    public int ArcherDefense;

    public int DemonKingHealth;
    public int DemonKingAttack;
    public int DemonKingDefense;

    public int CompanionKnightHealth;
    public int CompanionKnightAttack;
    public int CompanionKnightDefense;

    protected string Demonkingstats;
    protected string Companionknightstats;

    public virtual void steets()
    {
      Demonkingstats = $"DemonKing Stats! \r\n Health: {DemonKingHealth} \r\n Attack: {DemonKingAttack} \r\n Defense: {DemonKingDefense}";
      
    }
    public virtual void CKstats()
    {
      Companionknightstats = $"Companion Knight Stats! \r\n Health: {CompanionKnightHealth} \r\n Attack: {CompanionKnightAttack} \r\n Defense: {CompanionKnightDefense}";
    }
    
}
