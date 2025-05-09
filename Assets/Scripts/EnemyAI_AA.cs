using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour
{
    public float speed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void DestroyEnemy()
    {
        FindFirstObjectByType<GameManager>().AddScore();
        Destroy(gameObject);


    }

    public void Restart()

    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
        transform.Translate( Vector2.down * speed * Time.deltaTime);
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene("GameOver");
        }

        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        
        
    }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Projectile>() != null) ;

    }
