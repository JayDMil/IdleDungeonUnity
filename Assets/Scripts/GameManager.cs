using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI goldtext;
    public int Gold;
    public static GameManager instance;

    public GameObject camera1;
    public GameObject camera2;

    public EncounterManager EncounterManager;

    public int Clicks;

    void Awake() {
        instance = this;
    }

    public void AddGold(int amount) 
    {
        Gold += amount;
        goldtext.text = "Gold: " + Gold.ToString();    
    
    }

    public void RemoveGold(int amount)
    {
        Gold -= amount;
    }
    
    public void ClickAmount(int amount)
    {

    }

    public void SwitchView()
    {
        if (EncounterManager.Encountered == true)
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
            
        }
        else if (EncounterManager.Encountered == false)
        {
            camera2.SetActive(false);
            camera1.SetActive(true);
            
        }
    }



}
