using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector3 offset;

    GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(!LevelManager.gameOver && player != null)
        {
            transform.position = player.transform.position + offset;
        }
    }
}
