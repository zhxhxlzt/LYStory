using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardField : MonoBehaviour
{
    public List<Transform> selfPos  = new List<Transform>();
    public List<Transform> enemyPos = new List<Transform>();
    public CardPool cardPool = new CardPool();

    private IEnumerator Start()
    {
        cardPool.InitCard();
        yield break;
    }

    IEnumerator DrawCardAction()
    {
        yield break;
    }

}
