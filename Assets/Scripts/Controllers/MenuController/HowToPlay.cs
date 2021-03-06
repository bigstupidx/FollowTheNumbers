﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HowToPlay : MonoBehaviour {

    [Header("UnityStuffs")]
    public TextMeshProUGUI descriptionText;
    public GameObject howToPlayScreen;
    string[] scripts;
    public Button[] buttons;
    LevelUIController levelUIController;
    private void Start()
    {
        index = 0;
        int langIndex = PlayerPrefs.HasKey("lang") ? PlayerPrefs.GetInt("lang") : 0;

        scripts = StringLiterals.scripts[langIndex];
    	levelUIController = FindObjectOfType<LevelUIController>();
    }

    int index = 0;
    
	public void NextButton()
    {
        if (index == scripts.Length)
        {        
            HideHowToPlayScreen();
            return;
        }
         descriptionText.text =scripts[index];
        index++;
    }

    public void HideHowToPlayScreen()
    {
        index = 0;
        
		LevelController.Instance.levelPaused = false;
        levelUIController.showCardsButton.interactable = true;
        levelUIController.optionsButton.interactable = true;
        howToPlayScreen.SetActive(false);
    }
   
}
