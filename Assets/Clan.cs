using UnityEngine;

public class Clan
{
    public int strength;
    public int maxBouns;

    public Clan(int strength = 50, int maxBonus = 20)
    {
        this.strength = strength;
        this.maxBouns = maxBonus;
    }
}
