using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBehavior : MonoBehaviour
{
    public GameObject target;
    Vector3 offset;
    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            Vector3 pos = target.transform.position + offset;
            pos.y = Mathf.Clamp(pos.y, 1.25f, 10f);
            transform.position = pos;
        }
    }
}
