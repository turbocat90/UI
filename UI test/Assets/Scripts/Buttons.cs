using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject ShopPanel;
    private bool _activeShopPanel;
    public void StartDayButon()
    {
        Debug.Log("Start Day");
    }
    public void SettingsButton()
    {
        Debug.Log("Open Settings");
    }
    public void ShopButton()
    {
        if (_activeShopPanel == false)
        {
            ShopPanel.transform.gameObject.SetActive(true);
            _activeShopPanel = true;
        }
        else
        {
            ShopPanel.transform.gameObject.SetActive(false);
            _activeShopPanel = false;
        }
    }
    public void BuyCoins()
    {
        CoinsAndBonusScorer.coinScore += CoinsAndBonusScorer.buyCoinsFree;
    }
    public void BuyFoodBuster()
    {
        if (CoinsAndBonusScorer.coinScore >= CoinsAndBonusScorer.foodBusterCoast)
        {
            CoinsAndBonusScorer.foodBusterScore += 5;
            CoinsAndBonusScorer.coinScore -= CoinsAndBonusScorer.foodBusterCoast;
        } 
    }
    public void BuyTimeBuster()
    {
        if (CoinsAndBonusScorer.coinScore >= CoinsAndBonusScorer.timeBusterCoast)
        {
            CoinsAndBonusScorer.timeBusterScore += 1;
            CoinsAndBonusScorer.coinScore -= CoinsAndBonusScorer.timeBusterCoast;
        } 
    }
    public void UseFoodBuster()
    {
        if (CoinsAndBonusScorer.foodBusterScore > 0)
        {
            CoinsAndBonusScorer.foodBusterScore -= 1;
        }
    }
    public void UseTimeBuster()
    {
        if (CoinsAndBonusScorer.timeBusterScore > 0)
        {
            CoinsAndBonusScorer.timeBusterScore -= 1;
        }
    }
}   
