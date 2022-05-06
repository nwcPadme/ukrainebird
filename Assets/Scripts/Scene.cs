using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }


    public void Help()
    {
        SceneManager.LoadScene("help");
    }
}
