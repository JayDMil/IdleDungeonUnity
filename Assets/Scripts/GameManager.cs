using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI goldtext;
    public static GameManager instance;

    [SerializeField] Camera MainCamera; 
    public GameObject QuitButton;


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
        QuitButton.gameObject.SetActive(false);

    }

    public void LeaveEncounter()
    {
        MainCamera.gameObject.SetActive(true);
        QuitButton.gameObject.SetActive(true);
    }







}
