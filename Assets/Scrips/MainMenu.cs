using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // This method will be called when the Play button is pressed
    public void PlayGame()
    {
        // Replace "GameScene" with the name of your game scene
        SceneManager.LoadScene("GameScene");
    }

    // This method will be called when the Quit button is pressed
    public void QuitGame()
    {
        // If running in the Unity editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // If running as a build
        Application.Quit();
#endif
    }
}
