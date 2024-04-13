using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Gold;
    public static GameManager instance;
    get component 

    void Awake() {
        instance = this;
    }

    public void AddExp(int amount) 
    {
        Gold += amount;
    
    }

    public void RemoveExp(int amount)
    {
        Gold -= amount;
    }
    



}
