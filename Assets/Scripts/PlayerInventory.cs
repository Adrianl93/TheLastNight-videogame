using TMPro;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int coins = 0;
    public bool key = false;
    public TextMeshProUGUI coinsValueText;
    public GameObject keyIconUI;

    [Header("Sonido de recolección")]
    [SerializeField] private AudioClip coinSound;
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();

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

        if (coinSound != null && _audioSource != null)
        {
            _audioSource.PlayOneShot(coinSound);
        }
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
