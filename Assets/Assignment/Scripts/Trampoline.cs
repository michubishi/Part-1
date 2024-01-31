using UnityEngine;
/*
 * This class handles the spawning of coins after landing.
 */

public class Trampoline : MonoBehaviour
{
    public GameObject coin;

    private void OnCollisionEnter2D(Collision2D collision) //when the player hits the trampoline
    {
        Instantiate(coin, new Vector3(Random.Range(-5, 5), Random.Range(0, 200), 0), coin.transform.rotation); //create coins in randomized areas
        Instantiate(coin, new Vector3(Random.Range(-5, 5), Random.Range(0, 200), 0), coin.transform.rotation);
        Instantiate(coin, new Vector3(Random.Range(-5, 5), Random.Range(0, 200), 0), coin.transform.rotation);
    }
}
