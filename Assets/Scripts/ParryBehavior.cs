using UnityEngine;

public class ParryBehavior : MonoBehaviour
{
    public GameObject parryBox;
    public Transform spawner;
    public bool parried = false;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            parried = true;
        }
        
        if (parried)
        {
            Instantiate(parryBox, spawner.position, spawner.rotation);
            parried = false;
        }
    }
}
