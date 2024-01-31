using UnityEngine;

/*
 * This class handles coin collection.
 */
public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) //when the coin collides with the player
    {
        Destroy(gameObject); //it gets destroyed
    }
}
