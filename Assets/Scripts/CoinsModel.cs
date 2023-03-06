using UnityEngine;

public class CoinsModel : MonoBehaviour
{
    [SerializeField] CoinsView _coinsView;
    
    private int _amount;

    private void Awake()
    {
        _amount = PlayerPrefs.GetInt("Coins", 0);

        _coinsView.Show—oins(_amount);
    }

    public void OnPickupCoin()
    {
        _amount += 5;

        PlayerPrefs.SetInt("Coins", _amount);

        _coinsView.Show—oins(_amount);

        _coinsView.OnPickupCoinAnimation();
    }

    public bool TryDiscard(int price)
    {
        if (_amount < price)
            return false;

        _amount -= price;

        PlayerPrefs.SetInt("Coins", _amount);

        _coinsView.Show—oins(_amount);

        _coinsView.OnPickupCoinAnimation();

        return true;
    }
}