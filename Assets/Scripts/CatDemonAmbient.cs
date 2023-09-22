using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatDemonAmbient : MonoBehaviour
{
    public AudioSource catDemonSoundAudioSource;

    public float fadeTime = 5;
    public float minTimeOff = 5;
        public float maxTimeOff = 5;

    float timeOff;

    public float minTimeOn = 5;
    public float maxTimeOn = 15;
    float timeOn;

    public float minVol = 0.5f;
    public float maxVol = 1;
    float scaryDramaticVol;

    public float timer;
    public float timeTillNextEvent;

    bool catDemonSoundPlaying;
    // Start is called before the first frame update
    void Start()
    {
        RandomiseValues();
        timeTillNextEvent = timeOff;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeTillNextEvent){
            if(catDemonSoundPlaying){
                StartCoroutine(FadeCatDemonSound(catDemonSoundAudioSource.volume, 0, fadeTime));
                catDemonSoundPlaying = false;
                RandomiseValues();
                timeTillNextEvent = timeOff + fadeTime;
            }
            else if(!catDemonSoundPlaying){
                StartCoroutine(FadeCatDemonSound(0, scaryDramaticVol, fadeTime));
                catDemonSoundPlaying = true;
                RandomiseValues();
                timeTillNextEvent = timeOn + fadeTime;
            }
            timer = 0;
        }
    }

    void RandomiseValues()
    {
        timeOff = Random.Range(minTimeOff, maxTimeOff);
        timeOn = Random.Range(minTimeOn, maxTimeOn);
        scaryDramaticVol = Random.Range(minVol, maxVol);


    }

    IEnumerator FadeCatDemonSound(float startValue, float endValue, float duration)
    {
        float currentTime = 0;
        while (currentTime <= duration){
            catDemonSoundAudioSource.volume = Mathf.Lerp(startValue, endValue, (currentTime/duration));
            currentTime += Time.deltaTime;

            yield return null;
        }
    }
}
