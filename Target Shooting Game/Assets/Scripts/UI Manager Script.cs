using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerScript : MonoBehaviour
{
    [SerializeField] GameObject startPannel;
    [SerializeField] GameObject gamePannel;

    void ShowPannel(GameObject pannelToShow)
    {
        startPannel.SetActive(false);
        gamePannel.SetActive(false);

        pannelToShow.SetActive(true);
    }
    public void onClickStartButton()
    {
        ShowPannel(gamePannel);
        GameplayManager.instance.StartSpawningTargets();
    }
}
