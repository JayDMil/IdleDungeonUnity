using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EncounterManager : MonoBehaviour
{
    const float baseThreshold = 1;
    public float currentThreshold = baseThreshold;
    public static EncounterManager Instance;

    public event Action OnEncountered;


    void Awake(){
        Instance = this;
    }

    public void SpinEncounter()
    {
        int chance = UnityEngine.Random.Range(0, 1001);
        if (chance < currentThreshold)
        {
            
            OnEncountered();
            currentThreshold = baseThreshold;
        }
        else
        {
            currentThreshold += 1;
        }
    }
}
  