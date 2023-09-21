using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraAnimationController : MonoBehaviour
{
        public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
            anim = GetComponent<Animator>();
                 anim.SetTrigger("wakingUp");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
