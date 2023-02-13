using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeScript : MonoBehaviour
{
    public float strike = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(strike, 0, 0);
    }
}
