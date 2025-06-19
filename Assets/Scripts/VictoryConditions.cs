using UnityEngine;

public class VictoryConditions : MonoBehaviour
{
    [SerializeField] private GameObject VictoryPanel;
    [SerializeField] private float timeToRestart = 1f;

    private void Start()
    {
        if (VictoryPanel != null)
            VictoryPanel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();
            if (inventory != null && inventory.key)
            {
                Debug.Log("¡Ganaste!");
                if (VictoryPanel != null)
                    VictoryPanel.SetActive(true);

                Invoke(nameof(RestartThroughManager), timeToRestart);
            }
        }
    }

    private void RestartThroughManager()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.RestartGame();
        }
        else
        {
            Debug.LogError("GameManager.Instance es NULL");
        }
    }
}
