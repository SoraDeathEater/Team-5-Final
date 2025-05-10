using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public Vector3 moveDirection = Vector3.up; // Default to up for player bullets

    void Update()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Optional: destroy this projectile if it hits something meaningful
        if (other.CompareTag("Enemy") && moveDirection == Vector3.up) // player bullet hits enemy
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Player") && moveDirection == Vector3.down) // enemy bullet hits player
        {
            FindFirstObjectByType<GameManager>().PlayerHit();
            Destroy(gameObject);
        }
    }
}
