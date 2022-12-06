using UnityEngine;

public class BurningRush : Superpower
{
    [SerializeField] private float boostPercent;

    public override void Activate()
    {
        LightMyFire();
        BoostSpeed(boostPercent);
    }
}
