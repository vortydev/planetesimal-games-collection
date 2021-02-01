using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1); // Loads scene 1 with the actual game
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
