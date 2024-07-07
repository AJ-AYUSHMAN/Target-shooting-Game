using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseManager : MonoBehaviour
{
    public GameObject pausePanel;
    [SerializeField] GameObject pauseButtonPannel;

    public void Pause()
    {
        pausePanel.SetActive(true); 
        pauseButtonPannel.SetActive(false);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pausePanel.SetActive(false);
        pauseButtonPannel.SetActive(true);
        Time.timeScale = 1f;
    }

}
