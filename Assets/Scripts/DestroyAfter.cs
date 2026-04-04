using UnityEngine;

public class DestroyAfter : MonoBehaviour
{
    public float DestroyTimer;
    void Start()
    {
        
    }


    void Update()
    {
        Destroy(this.gameObject, DestroyTimer);
    }
}
