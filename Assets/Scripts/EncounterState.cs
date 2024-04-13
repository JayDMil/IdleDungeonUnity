using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StateMachine {Idling, Encounter}

public class EncounterState : MonoBehaviour
{
    StateMachine state;

    private void Update()
    {
        if (state == StateMachine.Idling)
        {

        }
        else if (state == StateMachine.Encounter)
        {

        }
    }
}
