
using UnityEngine;
using TMPro;

public class CoinsView : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text _render;

    [SerializeField] private Animator _animator;

    private float AnimationTime = 0.5f;

    public void OnPickupCoinAnimation()
    {
        _animator.SetBool("OnPickupCoin", true);

        Invoke("FinishOnPickupCoinAnimation", AnimationTime);   //Использует метод FinishOnPickupCoinAnimation()
    }

    public void FinishOnPickupCoinAnimation()
    {
        _animator.SetBool("OnPickupCoin", false);
    }

    public void ShowСoins(int amount)
    {
        _render.text = $"Coins: {amount}";
    }
}
