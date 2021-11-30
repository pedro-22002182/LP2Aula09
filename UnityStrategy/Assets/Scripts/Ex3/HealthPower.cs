using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPower : Superpower
{
    [SerializeField]
    private float health = 20;
    public override void Activate()
    {
        Heal(health);
        LightMyFire();
    }
}
