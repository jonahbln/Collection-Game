using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehavior : MonoBehaviour
{
    public static int score = 0;

    public AudioClip pickupSound;

    public int value = 0;
    
    void Start()
    {
        score = 0;
    }


    void Update()
    {
        if(LevelManager.gameOver)
        {
            score = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (!LevelManager.gameOver && other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(pickupSound, Camera.main.transform.position);
            gameObject.GetComponent<Animator>().SetTrigger("Destroy");
            Destroy(gameObject, .5f);
        }
    }

    private void OnDestroy()
    {
        if(!LevelManager.gameOver)
        {
            if (LevelManager.countDown >= (FindObjectOfType<LevelManager>().levelDuration / 2))
            {
                score += 2 * value;
                LevelManager.score += 2 * value;
            }
            else
            {
                score += value;
                LevelManager.score += value;
            }
            if (score >= FindObjectOfType<LevelManager>().winScore)
            {
                FindObjectOfType<LevelManager>().LevelBeat();
            }
        }
    }
}