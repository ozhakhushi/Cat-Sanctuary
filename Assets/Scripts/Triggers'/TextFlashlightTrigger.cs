using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFlashlightTrigger : MonoBehaviour
{
    public GameObject text; 

    void OnTriggerEnter()
    {
        text.SetActive(true);
        StartCoroutine(DisableText(text));
        GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator DisableText(GameObject myCanvas)
    {
        yield return new WaitForSeconds(3);
        myCanvas.SetActive(false);
    }
}
