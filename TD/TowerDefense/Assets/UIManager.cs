using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject livesTextBox;
    public GameObject goldTextBox;
    public static UIManager instance = null;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    void Start(){
        UpdateGoldDisplay();
        UpdateLivesDisplay();
    }

    public void UpdateLivesDisplay(){
        TextMeshProUGUI myTextBox = livesTextBox.GetComponent<TextMeshProUGUI>();
        myTextBox.text = "Lives: " + PlayerManager.instance.Lives;
    }
    public void UpdateGoldDisplay(){
         TextMeshProUGUI myTextBox = goldTextBox.GetComponent<TextMeshProUGUI>();
        myTextBox.text = "Gold: " + PlayerManager.instance.Gold;
    }

}
