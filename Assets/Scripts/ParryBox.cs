using System.Threading;
using UnityEngine;

public class ParryBox : MonoBehaviour
{
    public GameObject parryConfirm;
    public Transform confSpawner;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Projectile"))
        {
            Debug.Log("Parried!");

            Instantiate(parryConfirm, confSpawner.position, Quaternion.identity);

            Destroy(other.gameObject); // destroy projectile
        }
    }
}
