using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menus : MonoBehaviour
{

    public void loadGameChoice()
    {
        SceneManager.LoadScene("whichGameToPlay");
    }

    public void loadSinglePlayer()
    {
        SceneManager.LoadScene("singleplayer");
    }
    
     public void loadOctopawnSinglePlayer()
    {
        SceneManager.LoadScene("octopawnSingleplayer");
    }

    public void loadMultiPlayer()
    {
        SceneManager.LoadScene("multiplayer");
    }

    public void loadInstructions()
    {
        SceneManager.LoadScene("instructions");
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }
}
