using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catRoomMusicTrigger : MonoBehaviour
{
    public AudioClip[] creepyPianoMusic;
    public AudioSource audioSource;
    public GameObject LightsOffTrigger;

    public float duration = 8f;
    public float targetVolume = 0.5f;

    public GameObject text; 
    public GameObject letterRead;

     
     public GameObject backtoRoomText; 



    void OnTriggerEnter()
    {
       audioSource.PlayOneShot(creepyPianoMusic[0]);
       LightsOffTrigger.SetActive(true);
       text.SetActive(true);
        StartCoroutine(DisableText(text));
        letterRead.SetActive(true);
        backtoRoomText.SetActive(true);

         StartCoroutine(StartFade(audioSource,  duration,  targetVolume));
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
