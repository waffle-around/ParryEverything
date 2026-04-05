using UnityEngine;

public class BecomeTransparent : MonoBehaviour
{
    float transparency;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transparency = 1.0f;        
    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        renderer.color = new Color (1f, 1f, 1f, transparency);
        transparency -= 0.005f;
    }
}
