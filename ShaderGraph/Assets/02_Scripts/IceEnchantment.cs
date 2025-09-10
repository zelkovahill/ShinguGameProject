using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceEnchantment : SwordDecorator
{
    public IceEnchantment(ISword swrod) : base(swrod) { }

    public override string GetName()
    {
        return base.GetName() + " 아이스";
    }

    public override int GetAttackPower()
    {
        return base.GetAttackPower() + 6;
    }

    public override string GetSpecialEffect()
    {
        string baseEffect = base.GetSpecialEffect();
        string iceEffect = " ";


        return string.IsNullOrEmpty(baseEffect) ? iceEffect : baseEffect + ", " + iceEffect;
    }

    public override Color GetBladeColor()
    {
        return Color.cyan;
    }

    public override float GetGlowIntensity()
    {
        return base.GetGlowIntensity() + 1.2f;
    }
}
