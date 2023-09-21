using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*Allows buttons to fire various functions, like QuitGame and LoadScene*/

public class MenuHandler : MonoBehaviour {
    

	[SerializeField] private string whichScene;
    [SerializeField]public AudioClip clickSound;
 
    void Start()
    {
       // Cursor.visible = true;
       // Cursor.lockState = CursorLockMode.None;

    } 
    
    public void QuitGame()
    {

        Application.Quit();
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(whichScene);

    }

    
    
}
