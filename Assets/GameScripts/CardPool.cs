using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPool : MonoBehaviour
{
    public List<Card> selfCards =  new List<Card>();
    public List<Card> enemyCards = new List<Card>();

    public Card DrawCard(int side)
    {
        List<Card> targetCards;
        Card card;
        if (side == 0)
        {
            targetCards = selfCards;
            
        }
        else
        {
            targetCards = enemyCards;
        }

        if (targetCards == null || targetCards.Count == 0)
        {
            return null;
        }
        
        int pos = Random.Range(0, selfCards.Count - 1);
        card = selfCards[pos];
        selfCards.RemoveAt(pos);
        return card;
    }

    public void InitCard()
    {
        selfCards.Clear();
        enemyCards.Clear();
        for (int i=0; i<30; i++)
        {
            selfCards.Add(CreateRandomCard());
            enemyCards.Add(CreateRandomCard());
        }
    }

    public Card CreateRandomCard()
    {
        var card = Instantiate(Resources.Load<GameObject>("Arts/Prefabs/Card")).GetComponent<Card>();
        var atk  = Random.Range(1, 10);
        var hp  = Random.Range(1, 10);
        var cost = Random.Range((atk + hp) / 2 - 1, (atk + hp) / 2 + 1);
        card.InitCard(cost, atk, hp);
        return card;
    }
}
