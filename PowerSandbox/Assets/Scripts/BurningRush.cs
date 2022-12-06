using UnityEngine;

public class BurningRush : Superpower
{
    [SerializeField] private float boostFactor;

    public override void Activate()
    {
        LightMyFire();
        BoostSpeed(boostFactor);
    }
}
