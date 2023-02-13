using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public Transform player;
    public float speed = 10f;
    public AudioClip enemySFX;

    void Start()
    {
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!LevelManager.gameOver)
        {
            float step = speed * Time.deltaTime;


            transform.position = Vector3.MoveTowards(transform.position, player.position, step);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            AudioSource.PlayClipAtPoint(enemySFX, Camera.main.transform.position);
            gameObject.GetComponent<Animator>().SetTrigger("destroy");
            Destroy(gameObject, 1f);
        }
    }
}
