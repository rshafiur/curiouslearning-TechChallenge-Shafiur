using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public void GameOver()
    {
        //Show level complete UI text
        Invoke("LoadNextScene", 1.0f);
    }

    private void LoadNextScene()
    {
        if (SceneManager.GetActiveScene().buildIndex >= SceneManager.sceneCountInBuildSettings)
            return;
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
