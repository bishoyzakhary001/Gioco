using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game : MonoBehaviour
{
  public void PlayGame()
    {
        SceneManager.LoadSceneAsync("livello 1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
