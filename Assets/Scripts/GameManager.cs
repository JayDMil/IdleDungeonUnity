using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class GameManager : MonoBehaviour
{
    public List <float> autoclicks = new List<float>();

    public TextMeshProUGUI goldtext;
    public static GameManager instance;

    //sword variables
    public int swordUpgradePrice;
    public int swordLevel;


    public TextMeshProUGUI swordLevelText;
    public TextMeshProUGUI swordCostText;

    //armor variables
    public int armorUpgradePrice;
    public int armorLevel;


    public TextMeshProUGUI armorLevelText;
    public TextMeshProUGUI armorCostText;

    //potion variables
    public int potionUpgradePrice;
    public int potionLevel;


    public TextMeshProUGUI potionLevelText;
    public TextMeshProUGUI potionCostText;

    //bag variables
    public int bagUpgradePrice;
    public int bagLevel;


    public TextMeshProUGUI bagLevelText;
    public TextMeshProUGUI bagCostText;


    [SerializeField] Camera MainCamera; 
    [SerializeField] Camera EncounterCamera;
    public GameObject QuitButton;


    public EncounterManager encounterManager;

    public int GoldPerClick = 1;
    public int Gold;

    public int UpgradePrice;

    public List <GameObject> EncounterList;


    void Awake() {
        instance = this;
    }

    public void AddGold(int amount) 
    {
        Gold += amount;
        goldtext.text = "Gold: " + Gold.ToString();    
        
    
    }
    public void Update()
    {
        for (int i = 0; i < autoclicks.Count; i++)
        {
            if (Time.time - autoclicks[i] >= 1.0f)
            {
                autoclicks[i] = Time.time;
                AddGold(1);
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MainCamera.gameObject.SetActive(true);
        }
    }




    public void SwordUpgrade(int amount)
    {
        
        if (Gold >= swordUpgradePrice)
        {



            RemoveGold(swordUpgradePrice);
            //change the upgrade price
            swordUpgradePrice *= 2;
            swordCostText.text = swordUpgradePrice.ToString();
            

            //increase the sword level
            swordLevel += 1;
            swordLevelText.text = "Sword Power: Level " + swordLevel.ToString();

            //Autoclick info 
            autoclicks.Add(Time.time);

    

        }
        else
        {
            Debug.Log("Not enough gold");
        }
    }


    public void ArmorUpgrade(int amount)
    {

        if (Gold >= armorUpgradePrice)
        {
            RemoveGold(armorUpgradePrice);
            //change the upgrade price
            armorUpgradePrice *= 2;
            armorCostText.text = armorUpgradePrice.ToString();


            //increase the armor level
            armorLevel += 1;
            armorLevelText.text = "Armor Strength: Level " + armorLevel.ToString();

            //Autoclick info 
            autoclicks.Add(Time.time);
            autoclicks.Add(Time.time);
            autoclicks.Add(Time.time);
            autoclicks.Add(Time.time);


        }
        else
        {
            Debug.Log("Not enough gold");
        }
    }

    public void PotionUpgrade(int amount)
    {

        if (Gold >= potionUpgradePrice)
        {
            RemoveGold(potionUpgradePrice);
            //change the upgrade price
            potionUpgradePrice *= 2;
            potionCostText.text = potionUpgradePrice.ToString();


            //increase the armor level
            potionLevel += 1;
            potionLevelText.text = "Potion Potency: Level " + potionLevel.ToString();

            //Autoclick info 
            autoclicks.Add(Time.time);
            autoclicks.Add(Time.time);
            autoclicks.Add(Time.time);
            autoclicks.Add(Time.time);
            autoclicks.Add(Time.time);
            autoclicks.Add(Time.time);
            autoclicks.Add(Time.time); 

        }
        else
        {
            Debug.Log("Not enough gold");
        }
    }

    public void BagUpgrade(int amount)
    {

        if (Gold >= bagUpgradePrice)
        {
            RemoveGold(bagUpgradePrice);
            //change the upgrade price
            bagUpgradePrice *= 2;
            bagCostText.text = bagUpgradePrice.ToString();


            //increase the armor level
            bagLevel += 1;
            bagLevelText.text = "Bag Space: Level " + potionLevel.ToString();

            //Autoclick info 
            autoclicks.Add(Time.time);
            autoclicks.Add(Time.time);
            autoclicks.Add(Time.time);
            autoclicks.Add(Time.time);
            autoclicks.Add(Time.time);
            autoclicks.Add(Time.time);
            autoclicks.Add(Time.time);
            autoclicks.Add(Time.time);
            autoclicks.Add(Time.time);
            autoclicks.Add(Time.time);

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
        EncounterList = new List<GameObject>(Resources.LoadAll<GameObject>("Targets"));
        int randomPrefab = Random.Range(0, EncounterList.Count - 1);
        Instantiate(EncounterList[randomPrefab], new Vector3(-21, 0, 0), Quaternion.identity, encounterManager.transform);
        
    }

    public void LeaveEncounter()
    {
        MainCamera.gameObject.SetActive(true);
        QuitButton.gameObject.SetActive(true);
    }







}
