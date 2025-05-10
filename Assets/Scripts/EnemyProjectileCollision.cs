using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // If hit by a player bullet or the player itself
        if (other.CompareTag("Player") || other.CompareTag("PlayerProjectile"))
        {
            Destroy(other.gameObject);  // Destroy the bullet or player (optional)
            Destroy(gameObject);        // Destroy this enemy
        }
    }
}
