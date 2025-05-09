using UnityEngine;

public class TestScript : MonoBehaviour
{
    public float speed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate( Vector2.down * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enemy hit player!");
    }
}
