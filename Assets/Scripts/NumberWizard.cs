﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText; 
    int guess;

	// Use this for initialization
	void Start ()
    {
        max += 1;
        NextGuess();
	}

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        if (min == max)
        {
            return;
        }
        guess = Random.Range( min, max);
        guessText.text = guess.ToString();
    }

}
    