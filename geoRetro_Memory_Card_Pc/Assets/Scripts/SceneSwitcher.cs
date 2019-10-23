using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitcher : MonoBehaviour {

    //public GameObject LearnUI;

    public void GotoMainScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("menu");
    }

    //void changPanel()
    //{
    //    LearnUI
    //}



}
