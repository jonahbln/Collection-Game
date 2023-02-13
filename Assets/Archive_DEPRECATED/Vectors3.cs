using UnityEngine;

public class Vectors3 : MonoBehaviour
{
    public Transform player;
    public float speed = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = Vector3.Lerp(transform.position, player.position, speed * Time.deltaTime);

        float step = Time.deltaTime * speed;
        transform.position = Vector3.MoveTowards(transform.position, player.position, step);
    }
}
