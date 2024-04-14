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

    void Awake() {
        instance = this;
    }

    public void AddGold(int amount) 
    {
        GoldPerClick += amount;
        goldtext.text = "Gold: " + GoldPerClick.ToString();    
        
    
    }

    public void RemoveGold(int amount)
    {
        GoldPerClick -= amount;
        goldtext.text = "Gold: " + GoldPerClick.ToString();
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
