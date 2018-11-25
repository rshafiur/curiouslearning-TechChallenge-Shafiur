using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public void GameOver()
    {
        if (SceneManager.GetActiveScene().buildIndex >= SceneManager.sceneCountInBuildSettings)
            return;
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
