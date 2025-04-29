using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") || other.CompareTag("EnemyProjectile"))
        {
            FindFirstObjectByType<GameManager>().PlayerHit();
            Destroy(other.gameObject);
        }
    }
}
