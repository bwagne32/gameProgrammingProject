using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerTurnChanger : MonoBehaviour
{
    public GameObject player1_UI;
    public GameObject player2_UI;

    short currentPlayer = 1;

    void Start(){
        currentPlayer = 1;
        player1_UI.SetActive(true);
        player2_UI.SetActive(false);
    }


    public void swapPlayer()
    {
        if (currentPlayer == 1){
            currentPlayer = 2;
            player1_UI.SetActive(false);
            player2_UI.SetActive(true);
        }
        else {
            currentPlayer = 1;
            player1_UI.SetActive(true);
            player2_UI.SetActive(false);
        }
    }

    public void endGame()
    {
        SceneManager.LoadScene("CreditScreen_victory");
    }
}
