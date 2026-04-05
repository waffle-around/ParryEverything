using UnityEngine;

public class VillainBehavior : MonoBehaviour
{
    public Transform spawner;
    public GameObject projectile;
    public float fireRate = 1f;
    private float timer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= fireRate)
        {
            Instantiate(projectile, spawner.position, spawner.rotation);
            timer = 0f;
        }
    }
}
