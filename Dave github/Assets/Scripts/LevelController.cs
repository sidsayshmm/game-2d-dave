using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public static LevelController control;
    bool CollectTrophy = false;

	public void TrophyCheck()
    {
        if(CollectTrophy == false)
        {
            Debug.Log("Trophy Found");
            CollectTrophy = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(CollectTrophy == true)
        {
            Debug.Log("Loading next level");
            GameManager.manager.score += 2000;
            GameManager.manager.LevelManager();
        }
        else
        {
            Debug.Log("Collect Trophy first");
        }
    }
}
