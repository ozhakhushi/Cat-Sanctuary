using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CatVoiceTrigger : MonoBehaviour
{
    public AudioClip[] catVoice;
    public AudioSource audioSource;
   
    public float duration = 8f;
    public float targetVolume = 1f;

    public GameObject objective; 


 

    void OnTriggerEnter()
    {
       audioSource.PlayOneShot(catVoice[0]);
       objective.SetActive(true);


       StartCoroutine(StartFade(audioSource,  duration,  targetVolume));
        StartCoroutine(DisableText(objective));
        GetComponent<BoxCollider>().enabled = false;




    }
     
     IEnumerator DisableText(GameObject myCanvas)
    {
        yield return new WaitForSeconds(6);
        myCanvas.SetActive(false);
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
