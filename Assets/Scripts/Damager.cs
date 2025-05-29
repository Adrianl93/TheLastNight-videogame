using UnityEngine;

public class Damager : MonoBehaviour
{
    public int damage = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
        if (playerHealth == null)
        {

        }
        else
        {
            playerHealth.DamagePlayer(damage);
        }
    }

    
}
