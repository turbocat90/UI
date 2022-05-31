using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDisplay : MonoBehaviour
{
    public Text CoinScore;
    public Text FoodBuster;
    public Text TimeBuster;
    private void Update() 
    {
        ShowCoins();
        ShowFoodBuster();
        ShowTimeBuster();   
    }
    private void ShowCoins()
    {
        CoinScore.text = CoinsAndBonusScorer.coinScore.ToString();
    }
    private void ShowFoodBuster()
    {
        FoodBuster.text = CoinsAndBonusScorer.foodBusterScore.ToString();
    }
    private void ShowTimeBuster()
    {
        TimeBuster.text = CoinsAndBonusScorer.timeBusterScore.ToString();
    }
}
