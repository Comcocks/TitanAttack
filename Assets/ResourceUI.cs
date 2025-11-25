using UnityEngine;
using TMPro;

public class ResourceUI : MonoBehaviour
{
    [SerializeField] private TMP_Text valueText;

    void Start()
    {
        ResourceStorage.Instance.OnResourceChanged += UpdateText;
    }

    void OnDisable()
    {
        ResourceStorage.Instance.OnResourceChanged -= UpdateText;
    }

    private void UpdateText(int value)
    {
        valueText.text = "Resource: " + value.ToString();
    }
}
