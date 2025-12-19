using System;
using UnityEngine;

public sealed class ClanManager : MonoBehaviour
{
    public static ClanManager Instance;

    [SerializeField]
    private Clan economicClan = new Clan();
    [SerializeField]
    private Clan civilianClan = new Clan();
    [SerializeField]
    private Clan militaryClan = new Clan();

    private void Awake()
    {
        Instance = this;
    }

    public Clan GetEconomic()
    {
        return this.economicClan;
    }
    public Clan GetCivilian()
    {
        return this.civilianClan;
    }
    public Clan GetMilitary()
    {
        return this.militaryClan;
    }
}
