using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI goldtext;
    public static GameManager instance;

    [SerializeField] Camera MainCamera;


    public EncounterManager encounterManager;

    public int GoldPerClick = 1;
    public int Gold;

    public int UpgradePrice;

    void Awake() {
        instance = this;
    }

    public void AddGold(int amount) 
    {
        Gold += amount;
        goldtext.text = "Gold: " + Gold.ToString();    
        
    
    }

    public void SwordUpgrade(int amount)
    {
        UpgradePrice = 5;
        if (Gold >= UpgradePrice)
        {
            UpgradePrice = UpgradePrice * 2;
        }
        else
        {
            Debug.Log("Not enough gold");
        }
    }

    public void RemoveGold(int amount)
    {
        Gold -= amount;
        goldtext.text = "Gold: " + Gold.ToString();
    }
    

    private void Start()
    {
        encounterManager.OnEncountered += StartEncounter;
        
    }

    void StartEncounter()
    {
        MainCamera.gameObject.SetActive(false);

    }

    public void LeaveEncounter()
    {
        MainCamera.gameObject.SetActive(true);
    }







}
