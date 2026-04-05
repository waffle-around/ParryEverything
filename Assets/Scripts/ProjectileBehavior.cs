using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float speed = 5f;
    //private Rigidbody2D rb;
   
    void Start()
    {
       // rb = GetComponent<Rigidbody2D>();
       // rb.linearVelocity = Vector2.left * speed;
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Piss");
            Destroy(this.gameObject);
        }

        if(collision.gameObject.CompareTag("Parry"))
        {
            
            Destroy(this.gameObject);
        }
            
    }
}
