using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsPreventer : MonoBehaviour
{
    [SerializeField] private CoinsModel _coinsModel;

    private int price = 10;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin")
        {
            _coinsModel.OnPickupCoin();

            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Ñafe")
        {
            _coinsModel.TryDiscard(price);
        }
    }
}
