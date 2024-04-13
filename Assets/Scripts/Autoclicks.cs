using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autoclicks : MonoBehaviour
{
    
    public List <float> autoclicks = new List<float>();
    public int autoclickprice;
    
    void Update()
    
    {
        // loop through the auto clickers
        for (int i = 0; i < autoclicks.Count; i++)
        {
            if(Time.time - autoclicks[i] >= 1.0f)
            {
                autoclickprice = i;
            }
        }
    }

}
