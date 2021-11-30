using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAI : AnimalsAI
{
    protected override void SelectTarget()
    {
        Debug.Log("Ovelha target");
    }

    protected override void Move()
    {
        Debug.Log("moveu Lobo");
    }

    protected override void TryEat()
    {
        Debug.Log("tentar comer ovelha");
    }

    protected override void TryReproduce()
    {
        Debug.Log("tentar reproduzir com lobo");
    }
}
