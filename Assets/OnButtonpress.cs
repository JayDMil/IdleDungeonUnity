using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnButtonpress : MonoBehaviour
{

    
    public void Update()
    {
       if (Input.GetKeyDown(KeyCode.Z))
        {
        Destroy(gameObject);
        } 
    }
    
}
