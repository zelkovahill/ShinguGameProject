using UnityEngine;

public class FireEnchantment : SwordDecorator
{
    public FireEnchantment(ISword sword) : base(sword) { }

    public override string GetName()
    {
        return base.GetName() + " 파이어";
    }

    public override int GetAttackPower()
    {
        return base.GetAttackPower() + 8;
    }

    public override string GetSpecialEffect()
    {
        string baseEffect = base.GetSpecialEffect();
        string fireEffect = "";

        return string.IsNullOrEmpty(baseEffect) ? fireEffect : baseEffect + ", " + fireEffect;
    }

    public override Color GetBladeColor()
    {
        return Color.red;
    }

    public override float GetGlowIntensity()
    {
        return base.GetGlowIntensity() + 1.5f;
    }
}
