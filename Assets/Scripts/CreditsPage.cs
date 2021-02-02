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
    [SerializeField] Button collectionButton;

    [Header("Credits")]
    [SerializeField] GameObject digimechCredits;
    [SerializeField] GameObject sproutCredits;
    [SerializeField] GameObject collectionCredits;

    private void Awake()
    {
        collectionButton.interactable = false;
        sproutCredits.SetActive(false);
        digimechCredits.SetActive(false);
    }

    public void OnDigimechClick()
    {
        // digimech
        digimechButton.interactable = false;
        digimechCredits.SetActive(true);

        // sprout
        sproutButton.interactable = true;
        sproutCredits.SetActive(false);

        // collection
        collectionButton.interactable = true;
        collectionCredits.SetActive(false);

        menu.PlayClickSound(0);
    }

    public void OnSproutClick()
    {
        digimechButton.interactable = true;
        digimechCredits.SetActive(false);

        sproutButton.interactable = false;
        sproutCredits.SetActive(true);

        collectionButton.interactable = true;
        collectionCredits.SetActive(false);

        menu.PlayClickSound(0);
    }

    public void OnCollectionClick()
    {
        digimechButton.interactable = true;
        digimechCredits.SetActive(false);

        sproutButton.interactable = true;
        sproutCredits.SetActive(false);

        collectionButton.interactable = false;
        collectionCredits.SetActive(true);

        menu.PlayClickSound(0);
    }
}
