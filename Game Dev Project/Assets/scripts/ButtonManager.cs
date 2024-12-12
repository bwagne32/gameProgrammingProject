using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void TitleScreen()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("map1");
    }

    public void CreditScreenVictory()
    {
        SceneManager.LoadScene("CreditScreen_victory");
    }

    public void CreditScreenDraw()
    {
        SceneManager.LoadScene("CreditScreen_draw");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}
