using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;



public class NoteController : MonoBehaviour
{ 
    [Header("input")]
    [SerializeField] private KeyCode closeKey;

    [Space(10)]
    [SerializeField] private PlayerMovement player;

    [Header("UI Text")]
    [SerializeField] private GameObject noteCanvas;
    [SerializeField] private TMP_Text noteTextAreaUI;

    [Space(10)]
    [SerializeField] [TextArea] private string noteText;

    [Space(10)]
    [SerializeField] private UnityEvent openEvent;
    private bool isOpen = false;


    public void ShowNote()
    {
        noteTextAreaUI.text = noteText;
        noteCanvas.SetActive(true);
        openEvent.Invoke();
        DisablePlayer(true);
        isOpen = true;
    }

    void DisableNote()
    {
        noteCanvas.SetActive(false);
        noteTextAreaUI.text = null;
        DisablePlayer(false); 
        isOpen = false;

    }

    void DisablePlayer(bool disable)
    {
        player.enabled = !disable;
    }
    
    private void Update()
    {
        if(isOpen)
        {
            if(Input.GetKeyDown(closeKey))
            {
                DisableNote();
            }
        }
    }
}
