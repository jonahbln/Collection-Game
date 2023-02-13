using UnityEngine;

public class Vectors4 : MonoBehaviour
{
    public float speed = 4;
    new Renderer renderer;
    void Start()
    {
        renderer = GetComponent<Renderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        float t = Mathf.Sin(Time.time * speed);

        t += 1;

        t /= 2;

        transform.localScale = Vector3.Lerp(new Vector3(1, 1, 1), new Vector3(3, 3, 3), t);

        renderer.material.color = Color.Lerp(Color.white, Color.magenta, t);

    //  renderer.sharedMaterial; 
    }
}
