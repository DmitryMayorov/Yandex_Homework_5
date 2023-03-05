using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinsView : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text _render;

    [SerializeField] private Animator _animator;

    [SerializeField] private CoinsController _coinsController;

    private float AnimationTime = 0.5f;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin")
        {
            _coinsController.OnPickupCoin();

            Destroy(other.gameObject);
        }
    }

    public void OnPickupCoinAnimation()
    {
        _animator.SetBool("OnPickupCoin", true);

        Invoke("FinishOnPickupCoinAnimation", AnimationTime);
    }

    public void FinishOnPickupCoinAnimation()
    {
        _animator.SetBool("OnPickupCoin", false);
    }

    public void VisualizeText—oins(int amount)
    {
        _render.text = $"Coins: {amount}";
    }
}
