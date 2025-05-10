// File: EnemyProjectile.cs
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float speed = 2f;
    public GameObject enemyProjectilePrefab;
    public float shootInterval = 2f;

    private float shootTimer = 0f;

    void Update()
    {
        // Move down like a space invader
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        // Count up and shoot when time reaches interval
        shootTimer += Time.deltaTime;
        if (shootTimer >= shootInterval)
        {
            Shoot();
            shootTimer = 0f;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(enemyProjectilePrefab, transform.position, Quaternion.identity);
        // Optional: set direction if your Projectile uses moveDirection
        // bullet.GetComponent<Projectile>().moveDirection = Vector3.down;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Projectile"))
        {
            Destroy(collision.gameObject); // destroy player bullet
            Destroy(gameObject);           // destroy enemy
        }
    }
}