using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameEndScene : MonoBehaviour
{

    void Start()
    {
      StartCoroutine(GameEnd());
    }

    IEnumerator GameEnd()
    {
        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("TownNightScene");
    }
}
