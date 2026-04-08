using System;
using System.Threading;
using UnityEngine;

public class ParryBehavior : MonoBehaviour
{
    public GameObject parryBox;
    public Transform spawner;
    private AudioSource audioSource;

    public float parryCooldownTime = 2.7f;
    private float timerElapsed;


    void Start()
    {
       timerElapsed = parryCooldownTime;
       audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        timerElapsed += Time.deltaTime;

        if (timerElapsed >= parryCooldownTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject obj = Instantiate(parryBox, spawner.position, spawner.rotation);
                timerElapsed = 0f;
            }

          
        }       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Projectile"))
        {
            audioSource.Play();
        }
           
    }

}
