using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinColletor : MonoBehaviour
{
    private float coin = 0;
    public TextMeshProUGUI textcoins;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coin++;
            textcoins.text = coin.ToString();
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
        }
    }

}
