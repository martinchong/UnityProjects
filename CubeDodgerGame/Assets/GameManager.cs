using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;

    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    public void Win()
    {
        Debug.Log("Level Clear.");
        completeLevelUI.SetActive(true);
    }

    public void GameOver()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", restartDelay);

        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
