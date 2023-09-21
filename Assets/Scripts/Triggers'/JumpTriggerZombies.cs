using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTriggerZombies : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject CatDemon;
    public AudioClip[] jumpscareMusic;
    
 

    void OnTriggerEnter()
    {
        StartCoroutine(ZombieJumpScare());
        audioSource.PlayOneShot(jumpscareMusic[0]);
        GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator ZombieJumpScare()
    {
        CatDemon.SetActive(true);

        yield return new WaitForSeconds(2);
        CatDemon.SetActive(false);
    }

    
    
}
