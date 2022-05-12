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

    public void loadMultiplayerGameChoice()
    {
        SceneManager.LoadScene("pickMultiPlayerGame");
    }

    public void loadInstructionsChoice()
    {
        SceneManager.LoadScene("whichInstructionstoShow");
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

    public void loadOnlineMultiPlayer()
    {
        SceneManager.LoadScene("onlineMultiplayer");
    }

    public void loadOnlineOctopawnMultiPlayer()
    {
        SceneManager.LoadScene("onlineOctopawnMultiplayer");
    }

    public void loadOctopawnMultiPlayer()
    {
        SceneManager.LoadScene("octopawnMultiplayer");
    }

    public void loadInstructions()
    {
        SceneManager.LoadScene("instructions");
    }

    public void loadMultiplayerInstructions()
    {
        SceneManager.LoadScene("multiplayerInstructions");
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }
}
