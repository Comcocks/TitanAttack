using UnityEngine;
using System.Collections;

public class MineScript : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(UpdateValue());
    }

    IEnumerator UpdateValue()
    {
        while (true)
        {
            ResourceStorage.Instance.EarnResource(1);

            yield return new WaitForSeconds(2f);
        }
    }
}
