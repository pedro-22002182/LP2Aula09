using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepAI : AnimalsAI
{
    protected override void Move()
    {
        Debug.Log("moveu ovelha");
    }

    protected override void TryEat()
    {
        Debug.Log("tentar comer erva");
    }

    protected override void TryReproduce()
    {
        Debug.Log("tentar reproduzir com ovelha");
    }
}