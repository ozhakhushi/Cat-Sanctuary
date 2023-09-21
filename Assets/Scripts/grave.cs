using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class grave : MonoBehaviour
{
    public BodyBury bodyBurryGrave;
    // Start is called before the first frame update
    void Start()
    {
        bodyBurryGrave = GameObject.Find("Player").GetComponent<BodyBury>();

    }

    private void OnTriggerEnter(Collider other)
    {   
        if (other.tag == "Player")
        {
            if(bodyBurryGrave.bodyparts == 3)
            {
              SceneManager.LoadScene("GameEnd");
            }
            
        }      
        GetComponent<BoxCollider>().enabled = false;   
  
    }

}
