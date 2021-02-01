using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsPage : MonoBehaviour
{
    [SerializeField] MainMenu menu;

    [Header("Buttons")]
    [SerializeField] Button digimechButton;
    [SerializeField] Button sproutButton;

    [Header("Credits")]
    [SerializeField] GameObject digimechCredits;
    [SerializeField] GameObject sproutCredits;

    private void Awake()
    {
        digimechButton.interactable = false;
        sproutCredits.SetActive(false);
    }

    public void OnDigimechClick()
    {
        digimechButton.interactable = false;
        digimechCredits.SetActive(true);

        sproutButton.interactable = true;
        sproutCredits.SetActive(false);

        menu.PlayClickSound(0);
    }

    public void OnSproutClick()
    {
        digimechButton.interactable = true;
        digimechCredits.SetActive(false);

        sproutButton.interactable = false;
        sproutCredits.SetActive(true);

        menu.PlayClickSound(0);
    }
}
