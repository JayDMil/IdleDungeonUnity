using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Experience;
    public static GameManager instance;

    void Awake() {
        instance = this;
    }

    public void AddExp(int amount) 
    {
        Experience += amount;
    
    }

    public void RemoveExp
    {
        Experience -= amount;
    }
    



}
