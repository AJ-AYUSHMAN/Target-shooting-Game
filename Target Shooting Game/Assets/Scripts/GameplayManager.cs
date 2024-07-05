using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    public static GameplayManager instance;
    int score = 0;
    bool hasWon = false;
    [SerializeField] Text scoretext;
    // Start is called before the first frame update
    [SerializeField] GameObject targetPrefab;
    [SerializeField] GameObject winPanel;
    private void Awake()
    {
        if (!instance) instance = this;
    }
    void Start()
    {
        winPanel.SetActive(false);
        //InvokeRepeating("SpawnTarget", 1f, 1f);
        
    }

    public void StartSpawningTargets()
    {
        InvokeRepeating("SpawnTarget", 1f, 1f);
    }

    private void Update()
    {
        if (hasWon) CancelInvoke("SpawnTarget");
    }

    // Update is called once per frame
    public void SpawnTarget()
    {
        float xPos = Random.Range(-7.5f, 7.5f);
        float yPos = Random.Range(-4.0f, 4.0f);
        Vector3 randomtargetPos = new Vector3 (xPos, yPos, 0);
        Instantiate(targetPrefab, randomtargetPos, Quaternion.identity);
    }

    public void IncrementScore()
    {
        score++;
        scoretext.text = score.ToString();

        if (score >= 20)
        {
            winPanel.SetActive (true);
            hasWon = true;
        }

        Debug.Log("Score: " + score);
    }

    

}
