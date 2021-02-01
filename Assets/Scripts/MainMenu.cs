using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("General")]
    public int selectedGame = 0;

    [Header("UI")]
    [SerializeField] Image background;
    [SerializeField] Sprite[] backgrounds;

    [Header("Menu Pages")]
    [SerializeField] GameObject mainPage;
    [SerializeField] GameObject creditsPage;
    [SerializeField] GameObject gamePage;

    [Header("Audio")]
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] audioClips;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        UpdateSelectedGame(selectedGame);
    }

    private void Start()
    {
        creditsPage.SetActive(false);
        gamePage.SetActive(false);
    }

    public void ToggleCreditsPage()
    {
        mainPage.SetActive(!mainPage.activeSelf);
        creditsPage.SetActive(!creditsPage.activeSelf);
        PlayClickSound(0);
    }

    public void ToggleGamesPage()
    {
        mainPage.SetActive(!mainPage.activeSelf);
        gamePage.SetActive(!gamePage.activeSelf);
        PlayClickSound(0);

        UpdateSelectedGame(0);
    }

    public void PlayClickSound(int ind)
    {
       audioSource.PlayOneShot(audioClips[ind]);
    }

    public void UpdateSelectedGame(int ind)
    {
        selectedGame = ind;
        //background.sprite = backgrounds[ind];
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(selectedGame);
    }

    public void QuitGame()
    {
        Application.Quit(); // Quits the application
        Debug.Log("Quit");
    }
}
