using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyBlock : MonoBehaviour
{
    public float bounciness = 300f;
    
    public float speed = 1f;
    public Color color1 = Color.magenta;
    public Color color2 = Color.red;
    new Renderer renderer;
    float t;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        t = Mathf.Sin(Time.time * speed);

        t += 1;
        t /= 2;

        renderer.material.color = Color.Lerp(color1, color2, t);
    }


    private void OnCollisionEnter(Collision collision)
    {
        
        Vector3 impulse = (collision.impulse.normalized * bounciness);

        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForceAtPosition(impulse, collision.contacts[0].normal);
        }
    }
}
