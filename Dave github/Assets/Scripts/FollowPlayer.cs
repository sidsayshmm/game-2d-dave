using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        offset = player.transform.position;
    }

    void Update()
    {
        offset = player.transform.position;
    }

    void LateUpdate()
    {
        if (offset.x < 8f)
        {
            Vector3 temp = new Vector3(-0.2399998f, 0,-10f);
            transform.position = temp;
        }
        else if(offset.x >= 8f && offset.x <=29.07f)
        {       
            Vector3 temp = new Vector3(18.5f, 0, -10f);
            transform.position = temp;
        }
        else if(offset.x>29.07f)
        {
            Vector3 temp = new Vector3(28f, 0, -10f);
            transform.position = temp;
        }
    }

}
