using UnityEngine;

public class Key : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        PlayerInventory playerInventory = collision.gameObject.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.AddKey();
            Destroy(gameObject);
        }
    }
}
