using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
    using UnityEditor;
#endif
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private bool tutorialOn = false;
    private bool creditsOn = false;
    private bool cardsOn = false;
    public GameObject tutorialPage = null;
    public GameObject creditsPage = null;
    public GameObject cardsPage = null;
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Tutorial()
    {
        if (tutorialOn == false)
        {
            tutorialPage.gameObject.SetActive(true);
            tutorialOn = true;

            //closing other menus
            creditsPage.gameObject.SetActive(false);
            cardsPage.gameObject.SetActive(false);
            creditsOn = false;
            cardsOn = false;
        }
        else
        {
            tutorialPage.gameObject.SetActive(false);
            tutorialOn = false;
        }
    }

    public void Credits()
    {
        if (creditsOn == false)
        {
            creditsPage.gameObject.SetActive(true);
            creditsOn = true;

            // closing other menus
            tutorialPage.gameObject.SetActive(false);
            cardsPage.gameObject.SetActive(false);
            cardsOn = false;
            tutorialOn = false;
        }
        else
        {
            creditsPage.gameObject.SetActive(false);
            creditsOn = false;
        }
    }

    public void Cards()
    {
        if (cardsOn == false)
        {
            cardsPage.gameObject.SetActive(true);
            cardsOn = true;

            // closing other menus
            tutorialPage.gameObject.SetActive(false);
            creditsPage.gameObject.SetActive(false);
            tutorialOn = false;
            creditsOn = false;
        }
        else
        {
            cardsPage.gameObject.SetActive(false);
            cardsOn = false;
        }
    }

    public void Quit()
    {
#if UNITY_EDITOR
EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
