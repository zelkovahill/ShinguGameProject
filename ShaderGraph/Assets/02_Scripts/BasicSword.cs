using UnityEngine;

public class BasicSword : ISword
{
    public string GetName()
    {
        return "철검";
    }

    public int GetAttackPower()
    {
        return 10;
    }

    public int GetCriticalChance()
    {
        return 5;
    }

    public string GetSpecialEffect()
    {
        return "";
    }

    public Color GetBladeColor()
    {
        return Color.gray;
    }

    public float GetGlowIntensity()
    {
        return 0f;
    }
}
