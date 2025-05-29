using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int lives = 3;
    public GameManager gameManager;


    private void Start()
    {

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
        if (lives < 0) 
        {
            if (gameManager != null) 
            { 
                gameManager.RebootGame();
            }
            else
            {
                Debug.LogError("Reference to Game Manager is Null");
            }
            


        }
        else
        {
            lives = lives - damage;
            Debug.Log("Player lives: " + lives);


            //Se reinicia el juego si la cantidad de  vidas es iguales o menor a 0
            if(lives <= 0)
            {
                //SceneManager.LoadScene("Nivel1");
                gameManager.RebootGame();
            }
        }
            
    }
}

