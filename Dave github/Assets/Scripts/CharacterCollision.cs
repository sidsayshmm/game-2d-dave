using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollision : MonoBehaviour
{

    Animator anim;
    public CharacterControl movement;
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Danger")
        {
            Death();
        }

        if (collision.gameObject.tag == "Trophy")
        {
            FindObjectOfType<LevelController>().TrophyCheck();
            GameManager.manager.score += 1000;
            Destroy(collision.gameObject);
        }
    }


    void Death()
    {
        anim.SetBool("Alive", false);
        Debug.Log("You died");
        GameManager.manager.EndGame();
    }
}
