using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : Superpower
{
    [SerializeField]
    private float speed = 50;

    public override void Activate()
    {
        BoostSpeed(speed);
        LightMyFire();
    }
}
