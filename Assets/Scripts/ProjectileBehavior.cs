using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float speed = 5f;
    //public Vector2 leftmove = Vector2.left;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
