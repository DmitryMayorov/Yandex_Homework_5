using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purchases : MonoBehaviour
{
    [SerializeField] private CoinsController _coinsController;

    private int price = 10;

    void OnTriggerEnter2D(Collider2D other)
    {
        _coinsController.TryDiscard(price);
    }
}
