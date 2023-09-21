using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBackToRoomTrigger : MonoBehaviour
{
    public GameObject text; 
   // public GameObject lightsflickering;
    public GameObject letterRead;




    void OnTriggerEnter()
    {
        text.SetActive(true);
        StartCoroutine(DisableText(text));
       // lightsflickering.SetActive(true);
        letterRead.SetActive(true);
        GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator DisableText(GameObject myCanvas)
    {
        yield return new WaitForSeconds(1);
        myCanvas.SetActive(false);
    }
}
