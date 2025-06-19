using TMPro;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int coins = 0;
    public bool key = false;
    public TextMeshProUGUI coinsValueText;
    public GameObject keyIconUI; 

    private void Start()
    {
        if (keyIconUI != null)
        {
            keyIconUI.SetActive(false); 
        }
    }

    public void AddCoin(int quantity)
    {
        coins += quantity;
        Debug.Log("Total Coins: " + coins);
        coinsValueText.text = coins.ToString();
    }

    public void AddKey()
    {
        key = true;
        Debug.Log("Key obtenida");

        if (keyIconUI != null)
        {
            keyIconUI.SetActive(true); 
        }
    }
}
