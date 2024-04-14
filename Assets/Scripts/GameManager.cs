using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI goldtext;
    public int Gold;
    public static GameManager instance;

    [SerializeField] Camera MainCamera;


    public EncounterManager encounterManager;

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

    private void Start()
    {
        encounterManager.OnEncountered += StartEncounter;
        
    }

    void StartEncounter()
    {
        MainCamera.gameObject.SetActive(false);
             
    }





}
