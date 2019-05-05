using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColRedDiamond : MonoBehaviour
{
    private static int collected = 0;

    void Start()
    {
        if (collected == 1)
        {
            Destroy(gameObject);
        }
        if (gameObject.tag == "Collected")
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.manager.score += 150;
            Destroy(gameObject);

            collected = 1;
            transform.gameObject.tag = "Collected";
        }
    }
}
