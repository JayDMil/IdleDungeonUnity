using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI goldtext;
    public static GameManager instance;

    //text for the level of the upgrades
    public TextMeshProUGUI swordLevelText;
    public TextMeshProUGUI swordCostText;
    public int swordUpgradePrice;
    public int swordLevel;

    public TextMeshProUGUI armorLevelText;
    public int armorUpgradePrice = 100;
    public int armorLevel = 0;

    public TextMeshProUGUI potionLevelText;
    public int potionUpgradePrice = 1000;
    public int potionLevel = 0;

    public TextMeshProUGUI bagLevelText;
    public int bagUpgradePrice = 5;
    public int bagLevel = 0;


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
        
        if (Gold >= swordUpgradePrice)
        {
            RemoveGold(amount);
            //change the upgrade price
            swordUpgradePrice = swordUpgradePrice * 2;
            swordCostText.text = swordUpgradePrice.ToString();

            //increase the sword level
            swordLevel += 1;
            swordLevelText.text = "Sword Power: Level " + swordLevel.ToString();

            //autoclicker now...


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
