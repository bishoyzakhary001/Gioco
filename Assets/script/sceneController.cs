using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class sceneController
{
   public static void Loadscene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    } 
    public static void Restart()
    {
        Loadscene(SceneManager.GetActiveScene().buildIndex);
    }
    public static void NextLevel()
    {
        if (SceneManager.sceneCountInBuildSettings > SceneManager.GetActiveScene().buildIndex + 1)
        {

            Loadscene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else{
            Debug.Log("Coming Soon...");
        }
    }
}
