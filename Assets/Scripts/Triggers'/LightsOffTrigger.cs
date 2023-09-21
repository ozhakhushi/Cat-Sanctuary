using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOffTrigger : MonoBehaviour
{
    public AudioClip[] horrorBuildup;
    public AudioSource audioSource;

    public Light[] lightsToTurnOff;
    
    public float duration = 8f;
    public float targetVolume = 0.4f;

    public GameObject GoBackToRoomTrigger;


    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        audioSource.PlayOneShot(horrorBuildup[0]);
        
       for(int i = 0; i<lightsToTurnOff.Length; i++)
       { 
              lightsToTurnOff[i].GetComponent<Light>().enabled = false; 

      }
        StartCoroutine(StartFade(audioSource,  duration,  targetVolume));
        GoBackToRoomTrigger.SetActive(true);
        GetComponent<BoxCollider>().enabled = false;
    }
    
    public static IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = audioSource.volume;
        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }
     
   
}
