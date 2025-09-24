using UnityEngine;

public class CoinsManager : MonoBehaviour
{
   [SerializedField]
   private UnityEvent<int> onCoinsChanged;
    private int numberOfCoins = 0;
    public void SetNumberOfCoins(int amount)
    {
        numberOfCoins = amoubnt;
        onCoinsChanged.Invoke(numberOfCoins);
    }

    public boolCanBuy(int cost)
    {
        if (numberOfCoins >= cost)
        {
            SetNumberOfCoins(numberOfCoins - cost);
            return true;
        }
        return false;
    }
    public void AddCoins(int amount)
    {
        SetNumberOfCoins(numberOfCoins + amount);
    }
}
