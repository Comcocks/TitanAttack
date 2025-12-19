using UnityEngine;
using TMPro;

public class WheatUI : MonoBehaviour
{
    [SerializeField] private TMP_Text valueText;

    void Start()
    {
        WheatStorage.Instance.OnWheatChanged += UpdateText;
    }

    void OnDisable()
    {
        WheatStorage.Instance.OnWheatChanged -= UpdateText;
    }

    private void UpdateText(float value)
    {
        valueText.text = "Wheat: " + value.ToString();
    }
}
