using System;
using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    private int coins;
    [SerializeField] private TextMeshProUGUI coinText;

    private void Update()
    {
        coinText.text = "Coins: " + coins;
    }

    public void IncreaseCoins(int amount)
    {
        coins += amount;
    }
}
