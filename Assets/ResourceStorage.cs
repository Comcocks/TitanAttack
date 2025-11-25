using System;
using UnityEngine;

public sealed class ResourceStorage : MonoBehaviour
{
    public static ResourceStorage Instance;

    public event Action<int> OnResourceChanged;

    [SerializeField]
    private int currentResource;

    private void Awake()
    {
        Instance = this;
    }

    public void SetupResource(int resource)
    {
        this.currentResource = resource;
    }

    public int GetResource()
    {
        return this.currentResource;
    }

    public void EarnResource(int range)
    {
        this.currentResource += range;
        this.OnResourceChanged?.Invoke(this.currentResource);
    }

    public void SpendResource(int range)
    {
        this.currentResource -= range;
        this.OnResourceChanged?.Invoke(this.currentResource);
    }
}