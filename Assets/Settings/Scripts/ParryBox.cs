using System.Threading;
using UnityEngine;

public class ParryBox : MonoBehaviour
{
    public bool parried = false;
    public GameObject parryConfirm;
    public Transform confSpawner;

    void Start()
    {
        
    }


    void Update()
    {
        if (parried)
        {
            Instantiate(parryConfirm, confSpawner.position, confSpawner.rotation);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Debug.Log("ass");
            parried = true;
        }
    }
}
