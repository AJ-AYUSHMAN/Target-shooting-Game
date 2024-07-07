using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerScript : MonoBehaviour
{
    [SerializeField] GameObject startPannel;
    [SerializeField] GameObject gamePannel;
    [SerializeField] GameObject pauseButtonPannel;
    void ShowPannel(GameObject pannelToShow)
    {
        startPannel.SetActive(false);
        gamePannel.SetActive(false);
        pauseButtonPannel.SetActive(true);

        pannelToShow.SetActive(true);
        //restartButton.SetActive(true);
    }
    public void onClickStartButton()
    {
        ShowPannel(gamePannel);
        GameplayManager.instance.StartSpawningTargets();
    }

    
}
