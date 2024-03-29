﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartBoost5000Manager : MonoBehaviour {
    public PopUpMessageShop PopUpInstance;
    public Text PriceText1;
    public Text PriceText2;
    public Text AmountText1;
    public Text AmountText2;
    public float Price;

    public void Update()
    {
        PriceText1.text = Price.ToString();
        PriceText2.text = Price.ToString();
        AmountText1.text = PlayerPrefs.GetFloat("StartBoost5000Counter").ToString();
        AmountText2.text = PlayerPrefs.GetFloat("StartBoost5000Counter").ToString();
    }

    public void Buy()
    {     
        PopUpInstance.SetPopUpPanel("StartBoost5000Counter", Price);
    }
}
