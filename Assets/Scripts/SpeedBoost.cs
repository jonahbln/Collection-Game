using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    float speed = 1f;
    public Color color1 = Color.green;
    public Color color2 = Color.cyan;
    new Renderer renderer;
    float t;
    public float boost = 4f;

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
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<PlayerController>().speed += boost;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<PlayerController>().speed -= boost;
        }
    }
}
