using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject completedCanvas;
    public GameObject failCanvas;
    public bool isCompleted;

    private void Update() {
        if(isCompleted)
        {
            if(Input.anyKey)
                InstantLoadScene();
        }

    }

    public void EnableCompletedCanvas()
    {
        ActiveCompletedCanvas();
        isCompleted = true;
    }

    private void ActiveCompletedCanvas()
    {
        completedCanvas.SetActive(true);
    }

    public void EnableFailCanvas()
    {
        ActiveFailCanvas();
        Invoke("RestartLevel", 1.0f);
    }

    private void ActiveFailCanvas()
    {
        failCanvas.SetActive(true);
    }

    public void InstantLoadScene()
    {
        var scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void RestartLevel()
    {
        var scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
