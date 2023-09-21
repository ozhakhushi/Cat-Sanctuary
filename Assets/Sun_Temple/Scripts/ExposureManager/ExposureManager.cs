/// <summary>
/// This will adjust sun brightness depending on whether player is inside trigger area or not. Put this on empty gameobject in scene
/// </summary>


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


namespace SunTemple
{

    public class ExposureManager : MonoBehaviour
    {

        public static ExposureManager instance;
        public Light Sun;
        public float ExteriorSunIntensity = 1f;
        public float InteriorSunIntensity = 3.0f;
        public float AdaptationSpeed = 1f;
        public string PlayerTag = "Player";
        public int zoneCounter;
        public AudioMixerSnapshot defaultSnapshot;
        public AudioMixerSnapshot insideSnapshot;


        float StartIntensity;
        float EndIntensity;

        float LerpTime = 1f;
        float CurrentLerpTime;
        bool LerpLight;


        void Awake()
        {
            instance = this;

			if (!Sun) {
				Debug.LogError (this.GetType ().Name + ".cs on " + this.gameObject.name + ": no light assigned to 'Sun' variable", gameObject);
				return;
			}
        }



        void Update()
        {
            if (LerpLight)
            {
                LerpIntensity();
            }
        }





        void LerpIntensity()
        {
            //increment timer once per frame
            CurrentLerpTime += Time.deltaTime* AdaptationSpeed;
            if (CurrentLerpTime > LerpTime)
            {
                CurrentLerpTime = LerpTime;
            }

            //lerp!
            float perc = CurrentLerpTime / LerpTime;
            Sun.intensity = Mathf.Lerp(StartIntensity, EndIntensity, perc);
            if (CurrentLerpTime == LerpTime)
            {
                LerpLight = false;
            }
        }



        public void SetSunIntensityToExterior()
        {
            LerpLight = true;
            CurrentLerpTime = 0;
            StartIntensity = Sun.intensity;
            EndIntensity = ExteriorSunIntensity;
            zoneCounter += 1;
           //UpdateAudioZone();
           defaultSnapshot.TransitionTo(1f);




        }

        public void SetSunIntensityToInterior()
        {
            LerpLight = true;
            CurrentLerpTime = 0;
            StartIntensity = Sun.intensity;
            EndIntensity = InteriorSunIntensity;
            zoneCounter -= 1;
           insideSnapshot.TransitionTo(1f);

           // UpdateAudioZone();

        }

        public void UpdateAudioZone()
        {
            if(zoneCounter > 0)
            {
                insideSnapshot.TransitionTo(1f);
            }
            else{
                defaultSnapshot.TransitionTo(1f);
            }
        }


        

    }
}