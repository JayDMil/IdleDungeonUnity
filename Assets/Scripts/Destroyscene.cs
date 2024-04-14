using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyscene : MonoBehaviour
{    
    public void Awake()
    {
        Destroy(this, 5);
    }
}
