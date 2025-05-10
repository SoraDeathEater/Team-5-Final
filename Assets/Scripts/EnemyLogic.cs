using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Projectile"))
        {
            Destroy(other.gameObject); // Destroy the projectile
            Destroy(gameObject);       // Destroy the enemy

            FindFirstObjectByType<GameManager>().AddScore(1); // Add 1 point to score
        }
    }
}
