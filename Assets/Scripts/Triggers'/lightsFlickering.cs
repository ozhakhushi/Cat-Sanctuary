using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightsFlickering : MonoBehaviour
{
    public Light[] lightsToFlicker;
     public float flickerSpeed  = 0.1f;
     public bool lightsFlicker = false;
    // Update is called once per frame
    void update()
    {
       StartCoroutine(lightsflickering(lightsToFlicker));
    }

    IEnumerator lightsflickering(Light[] lights)
    {
      for(int i = 0; i<lights.Length; i++)
        {      
               lightsFlicker = true;
               while (lightsFlicker){

                lights[i].GetComponent<Light>().enabled = true; 
                yield return new WaitForSeconds (flickerSpeed);
                }
                lightsFlicker = false;
                lights[i].GetComponent<Light>().enabled = false; 
                yield return new WaitForSeconds (flickerSpeed);
        } 
    }
}
