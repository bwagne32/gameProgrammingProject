using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerTurnChanger : MonoBehaviour
{
    public GameObject player1_UI;
    public GameObject player2_UI;
    public List<GameObject> prefabs;
    
    public Vector3 startingSpawn;
    short currentPlayer = 1;
    //public short numDead = 0;

    void Start(){
        currentPlayer = 1;
        player1_UI.SetActive(true);
        player2_UI.SetActive(false);
        
        for (int i = 0; i < prefabs.Count; i++)
        {
            startingSpawn[0] += 2;
            Quaternion spawnRotation = Quaternion.identity; // No rotation

            // Spawn the GameObject
            Instantiate(prefabs[i], startingSpawn, spawnRotation);

        }
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
    private void Update()
    {
        int numDead = 0;
        for (int i = 0; i < prefabs.Count; i++)
        {
            if (!prefabs[i].gameObject.activeSelf) numDead++;
        }
        if (numDead == 3) endGame();
    }
    public void endGame()
    {
        SceneManager.LoadScene("CreditScreen_victory");
    }
}
