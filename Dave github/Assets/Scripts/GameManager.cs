using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
    public static GameManager manager;

    bool gameHasEnded = false;
    public float restartDelay = 1f;

    private  int level = 1;

    public int lives = 3;
    public int score=0;
    

    void Awake()
    {
        if (manager == null)
        {
            DontDestroyOnLoad(gameObject);
            manager = this;
        }
        else if (manager != null)
        {
            Destroy(gameObject);
        }
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            lives--;
            gameHasEnded = true;
            if (lives == -1)
                Debug.Log("Game Over");
            else
                Debug.Log("You died. " +lives+ "Lives left");

            

            Invoke("Restart", restartDelay);
        }
    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameHasEnded = false;
    }


    public void LevelManager()
    {
        if(level==5)
        {
            Debug.Log("Game won");
            return;
        }

        level = level + 1;
        Debug.Log("Level" + level + "completed");
        if(SceneManager.GetActiveScene().buildIndex==1)
        {
            SceneManager.LoadScene(2);
        }
        else if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            SceneManager.LoadScene(3);
        }
        else if(SceneManager.GetActiveScene().buildIndex == 3)
        {
            SceneManager.LoadScene(4);
        }
    }
}
