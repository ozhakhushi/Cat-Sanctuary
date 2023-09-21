using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyPart : MonoBehaviour
{
    public BodyBury bodyBurry;

    public AudioClip collectSound;
    public AudioSource audioSourceCollectSound;

    // Start is called before the first frame update
    void Start()
    {
        bodyBurry = GameObject.Find("Player").GetComponent<BodyBury>();


    }
    
     private void OnTriggerEnter(Collider other)
    {   
        if (other.tag == "Player")
        {
            audioSourceCollectSound.PlayOneShot(collectSound);

            bodyBurry.bodyparts += 1;
        }

        
        
        GetComponent<BoxCollider>().enabled = false;   
       
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
