using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GamesPage : MonoBehaviour
{
    [SerializeField] MainMenu menu;

    [Header("Buttons")]
    [SerializeField] Button digimechButton;
    [SerializeField] Button sproutButton;
    [SerializeField] GameObject playButton;
    [SerializeField] TextMeshProUGUI playText;

    private void Awake()
    {
        playButton.SetActive(false);
    }

    public void ClickDigimech()
    {
        menu.PlayClickSound(1);
        menu.UpdateSelectedGame(1);

        digimechButton.interactable = false;
        sproutButton.interactable = true;

        playButton.SetActive(true);
        playText.text = "Play Digimech";
    }

    public void ClickSprout()
    {
        menu.PlayClickSound(2);
        menu.UpdateSelectedGame(2);

        digimechButton.interactable = true;
        sproutButton.interactable = false;

        playButton.SetActive(true);
        playText.text = "Play Sprout";
    }

    public void UnselectGame()
    {
        digimechButton.interactable = true;
        sproutButton.interactable = true;
        playButton.SetActive(false);
    }
}
