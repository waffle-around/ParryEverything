using System;
using System.Threading;
using UnityEngine;

public class ParryBehavior : MonoBehaviour
{
    public GameObject parryBox;
    public Transform spawner;
    /*public Transform confSpawner;
    public bool parried = false;
    public GameObject parryConfirm;
    private ParryBox cParrybox;
    //BoxCollider2D collider;*/

    void Start()
    {
        //collider = Get<BoxCollider2D>();   
       // parryBox = GetComponent<ParryBox>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = Instantiate(parryBox, spawner.position, spawner.rotation);
        }

    }

}
