// File: EnemyProjectile.cs
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindFirstObjectByType<GameManager>().PlayerHit();
            Destroy(gameObject);
        }
    }
}
