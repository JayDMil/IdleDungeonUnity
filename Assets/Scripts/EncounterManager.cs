using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterManager : MonoBehaviour
{
    const int baseThreshold = 1;

    public bool Encountered;
    public int currentThreshold = baseThreshold;
    public static EncounterManager Instance;


    void Awake(){
        Instance = this;
    }

    public void SpinEncounter()
    {
        int chance = Random.Range(0, 100);
        if (chance < currentThreshold)
        {
            
            startEncounter();
            currentThreshold = baseThreshold;
        }
        else
        {
            currentThreshold += 2;
            Encountered = false;
        }

    }

    public void startEncounter()
    {
        Debug.Log("Random Encounter Begin");
        Encountered = true;
        
    }
}
