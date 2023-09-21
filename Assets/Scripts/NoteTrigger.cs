using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject letterReadUI;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            letterReadUI.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            letterReadUI.SetActive(false);
        }
    }


}
