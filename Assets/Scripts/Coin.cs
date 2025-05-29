using UnityEngine;



public class Coin : MonoBehaviour
{
    public int quantity;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        PlayerInventory playerInventory = collision.gameObject.GetComponent<PlayerInventory>();
        
        if(playerInventory != null)
        {
            playerInventory.AddCoin(quantity);
            Destroy(gameObject);
        }
    }

    
}
