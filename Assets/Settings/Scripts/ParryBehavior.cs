using UnityEngine;

public class ParryBehavior : MonoBehaviour
{
    public GameObject parryBox;
    public Transform spawner;
    public Transform confSpawner;
    public bool parried = false;
    //public GameObject parryConfirm;
    //BoxCollider2D collider;


    void Start()
    {
        //collider = Get<BoxCollider2D>();   
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(parryBox, spawner.position, spawner.rotation);
            parried = true;
        }
        
       /* if (parried)
        {

            Instantiate(parryConfirm, confSpawner.position, confSpawner.rotation);
        }*/
    }
}
