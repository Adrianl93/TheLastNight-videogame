using TMPro;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int coins = 0;
    public TextMeshProUGUI coinsValueText;
    public TextMeshProUGUI livesValueText;
    public void AddCoin(int quantity)
    {
        coins += quantity;
        Debug.Log("Total Coins: " + coins);

        if (coinsValueText == null)
        {
            Debug.LogError("coinsValueText no está asignado en el Inspector.");
            return;
        }
        coinsValueText.text = coins.ToString();
    }
}
