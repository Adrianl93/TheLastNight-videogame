using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int lives = 3;
    public TextMeshProUGUI livesValueText;

    private void Start()
    {
        UpdateLivesUI();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            DamagePlayer(1);
        }
    }

    public void DamagePlayer(int damage)
    {
        lives -= damage;
        Debug.Log("Player lives: " + lives);

        UpdateLivesUI();

        if (lives <= 0)
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.RestartGame();
            }
            else
            {
                Debug.LogError("GameManager.Instance is NULL");
            }
        }
    }

    private void UpdateLivesUI()
    {
        if (livesValueText != null)
        {
            livesValueText.text = lives.ToString();
        }
        else
        {
            Debug.LogWarning("livesValueText no asignado");
        }
    }
}
