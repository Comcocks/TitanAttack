using System;
using UnityEngine;

public sealed class WheatStorage : MonoBehaviour
{
    public static WheatStorage Instance;

    public event Action<float> OnWheatChanged;

    [SerializeField]
    private float currentWheat;

    private void Awake()
    {
        Instance = this;
    }

    public void SetupWheat(float wheat)
    {
        this.currentWheat = wheat;
    }

    public float GetWheat()
    {
        return this.currentWheat;
    }

    public void EarnWheat(float range)
    {
        var clan = ClanManager.Instance.GetCivilian();
        this.currentWheat += range + range * clan.maxBouns * clan.strength / 10000;
        this.OnWheatChanged?.Invoke(this.currentWheat);
    }

    public void SpendWheat(float range)
    {
        this.currentWheat -= range;
        this.OnWheatChanged?.Invoke(this.currentWheat);
    }
}