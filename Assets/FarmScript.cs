using UnityEngine;
using System.Collections;

public class FarmScript : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(UpdateValue());
    }

    IEnumerator UpdateValue()
    {
        while (true)
        {
            WheatStorage.Instance.EarnWheat(1f);

            yield return new WaitForSeconds(1f);
        }
    }
}
