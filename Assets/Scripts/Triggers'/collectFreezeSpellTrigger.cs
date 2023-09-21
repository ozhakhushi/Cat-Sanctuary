using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectFreezeSpellTrigger : MonoBehaviour
{
    public FreezeOrbSpell freezeOrbSpell; 
    public AudioClip collectSound;
    public AudioSource audioSourceCollectSound;
    public AudioSource audioSource;
    public AudioClip[] horrorBuildup;
    public GameObject enemiesJumpScare;


    public Light[] lightsToTurnOffInTemple;
    
    public float duration = 8f;
    public float targetVolume = 0.4f;

    
    void Start()
    {
        freezeOrbSpell = GameObject.Find("Player").GetComponent<FreezeOrbSpell>();
    }

     private void OnTriggerEnter(Collider other)
    {   
        if (other.tag == "Player")
        {
            audioSourceCollectSound.PlayOneShot(collectSound);

            freezeOrbSpell.freezeOrbs += 1;
        }

        audioSource.PlayOneShot(horrorBuildup[0]);
        
       for(int i = 0; i<lightsToTurnOffInTemple.Length; i++)
       { 
              lightsToTurnOffInTemple[i].GetComponent<Light>().enabled = false; 

      }
        StartCoroutine(StartFade(audioSource,  duration,  targetVolume));
        enemiesJumpScare.SetActive(true);
        
        GetComponent<BoxCollider>().enabled = false;   
       // GetComponent<VisualEffect>().enabled = false; 
       //gameObject.enabled(false);
       //gameObject.destroy();
        Destroy(gameObject);
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
