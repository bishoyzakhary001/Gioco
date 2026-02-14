using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiController : MonoBehaviour
{
  public void Play()
    {
        sceneController.Loadscene(2);
        Time.timeScale = 1;
    }
    public void Restart()
    {
        sceneController.Restart();
        Time.timeScale = 1;
    }
    public void NextLevel()
    {
        sceneController.NextLevel();
        Time.timeScale=1;
    }
    public void SceneLoad(int sceneIndex) 
    {
        sceneController.Loadscene(sceneIndex);
        Time.timeScale = 1;
    }

}
