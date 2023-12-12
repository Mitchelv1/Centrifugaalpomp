using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayVrGame()
    {
        SceneManager.LoadSceneAsync("SampleSceneVr");
    }

    public void Play3dGame()
    {
        SceneManager.LoadSceneAsync("SampleScene3d");
    }

    public void centrifugaalpomp()
    {
        SceneManager.LoadSceneAsync("centrifugaalpomp Main Menu");
    }

    public void afsluiten()
    {
        Application.Quit();
    }
}
