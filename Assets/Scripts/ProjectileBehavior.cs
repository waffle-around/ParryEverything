using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float randSpeed;
 
    //private Rigidbody2D rb;
   
    void Start()
    {
        StartCoroutine(RandomNumber());
    }

    void Update()
    {
        transform.Translate(Vector2.left * randSpeed * Time.deltaTime);
    }

    IEnumerator RandomNumber()
    {
        while (true)
        {
            randSpeed = Random.Range(1.0f, 19.0f);
            yield return new WaitForSeconds(2f); 
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

        if(collision.gameObject.CompareTag("Parry"))
        {
            
            Destroy(gameObject, 1.0f);
        }
            
    }
}
