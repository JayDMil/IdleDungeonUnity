using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EncounterHUD : MonoBehaviour
{
    [SerializeField] Text yesText;
    [SerializeField] Text noText;

    public void ShowText(string text)
    {
        yesText.text = "Yes";
        noText.text = "No";
    }
}
