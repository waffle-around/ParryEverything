using System;
using System.Threading;
using UnityEngine;

public class ParryBehavior : MonoBehaviour
{
    public GameObject parryBox;
    public Transform spawner;
    private new AudioSource audio;


    void Start()
    {
       audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = Instantiate(parryBox, spawner.position, spawner.rotation);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Projectile"))
        {
            audio.Play();
        }
           
    }

}
