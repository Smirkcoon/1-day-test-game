using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBonusSound : MonoBehaviour {

    public AudioSource Health;
    public static bool HealthSoundActivated;
    
	void Update ()
    {
        if (HealthSoundActivated == true)
        {
            Health.Play();
            HealthSoundActivated = false;
        }     
    }
}
