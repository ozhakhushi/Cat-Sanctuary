using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatDemonAwakeTrigger : MonoBehaviour
{

    //add ambient music that has monster sounds in it.
    
    //set active the cat monsters
    public GameObject catMonsters;
    
    //set active the body parts 
    public GameObject bodyParts;

    //set active the grave 
    public GameObject Grave;


    void start()
    {
          
              }

    void OnTriggerEnter()
    {
        GameObject.Find("Audio").GetComponent<CatDemonAmbient>().enabled = true;
        catMonsters.SetActive(true);
        bodyParts.SetActive(true);
        Grave.SetActive(true);
    }
    

    
}
