using System;
using UnityEngine;

public sealed class WheatStorage : MonoBehaviour
{
    public static WheatStorage Instance;

    public event Action<int> OnWheatChanged;

    [SerializeField]
    private int currentWheat;

    private void Awake()
    {
        Instance = this;
    }

    public void SetupWheat(int wheat)
    {
        this.currentWheat = wheat;
    }

    public int GetWheat()
    {
        return this.currentWheat;
    }

    public void EarnWheat(int range)
    {
        this.currentWheat += range;
        this.OnWheatChanged?.Invoke(this.currentWheat);
    }

    public void SpendWheat(int range)
    {
        this.currentWheat -= range;
        this.OnWheatChanged?.Invoke(this.currentWheat);
    }
}