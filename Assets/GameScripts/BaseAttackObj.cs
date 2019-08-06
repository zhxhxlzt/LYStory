using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAttackObj : MonoBehaviour
{
    public int  AttackValue;
    public int  Hp;
    public bool IsAlive { get { return Hp > 0; } }

    public virtual int GetAttack(int damage)
    {
        Hp -= damage;
        OnGetAttack(damage);
        return damage;
    }

    public virtual void OnGetAttack(int damage)
    {

    }

    public void StartAttack( BaseAttackObj attacker, BaseAttackObj target )
    {
        target.GetAttack(attacker.AttackValue);
        attacker.GetAttack(target.AttackValue);
    }
}
