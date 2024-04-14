using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI goldtext;
    public int Gold;
    public static GameManager instance;

    public Camera MainCamera;
    public Camera EncounterCamera;

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

    public void Start()
    {
        MainCamera.enabled = true;
        EncounterCamera.enabled = false;
    }


    public void SwitchView()
    {
        if (EncounterManager.Encountered == true)
        {
            EncounterCamera.enabled = true;
            MainCamera.enabled = false;
            
        }
        else if (EncounterManager.Encountered == false)
        {
            MainCamera.enabled = true;
            EncounterCamera.enabled = false;
        }
    }



}
