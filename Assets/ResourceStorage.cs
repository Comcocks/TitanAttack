using System;
using UnityEngine;

public sealed class ResourceStorage : MonoBehaviour
{
    public static ResourceStorage Instance;

    public event Action<float> OnResourceChanged;

    [SerializeField]
    private float currentResource;

    private void Awake()
    {
        Instance = this;
    }

    public void SetupResource(float resource)
    {
        this.currentResource = resource;
    }

    public float GetResource()
    {
        return this.currentResource;
    }

    public void EarnResource(float range)
    {
        var clan = ClanManager.Instance.GetCivilian();
        this.currentResource += range + range * clan.maxBouns * clan.strength / 10000;
        this.OnResourceChanged?.Invoke(this.currentResource);
    }

    public void SpendResource(float range)
    {
        this.currentResource -= range;
        this.OnResourceChanged?.Invoke(this.currentResource);
    }
}