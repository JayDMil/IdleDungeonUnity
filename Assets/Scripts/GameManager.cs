using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Gold;
    public static GameManager instance;

    void Awake() {
        instance = this;
    }

    public void AddGold(int amount) 
    {
        Gold += amount;
    
    }

    public void RemoveGold(int amount)
    {
        Gold -= amount;
    }
    



}
