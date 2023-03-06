using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompositeRoot : MonoBehaviour
{
    [SerializeField] CoinsView _coinsView;

    public void SaveAmountMoney()
    {
        PlayerPrefs.SetInt("Coins", CoinsModel._amount);
    }
}
