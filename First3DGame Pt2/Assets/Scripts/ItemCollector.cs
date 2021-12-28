using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemCollector : MonoBehaviour
{
    int coins = 0;
    [SerializeField] Text coinsText;
    [SerializeField] AudioSource coinSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinSound.Play();
            coinsText.text = "Coins: " + coins;
        }
    }
}
