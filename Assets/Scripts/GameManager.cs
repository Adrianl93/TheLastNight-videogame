using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        // Singleton para que sea accesible desde cualquier script
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Opcional si usás varias escenas
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        CloseGame();
        RebootGame();
    }

    // Cerrar el juego con Escape
    public void CloseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    // Reiniciar el juego manualmente con R
    public void RebootGame()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Nivel1");
        }
    }

    // Reinicio llamado externamente (desde PlayerHealth)
    public void RestartGame()
    {
        SceneManager.LoadScene("Nivel1");
    }
}
