using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : BaseAttackObj
{
    public int Cost;

    public void InitCard( int cost, int atk, int hp)
    {
        Cost = cost;
        AttackValue = atk;
        Hp = hp;
    }
}
