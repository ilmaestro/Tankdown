using UnityEngine;
using System.Collections;

public class MainMenuEvents : MonoBehaviour {

    public void StartGame() 
    {
        Application.LoadLevel("FirstMatch");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
