using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public void Quitgame()
    {
        Application.Quit();
    }

    public void restartgame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
