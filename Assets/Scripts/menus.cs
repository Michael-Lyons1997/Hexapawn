using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menus : MonoBehaviour
{

    public void loadHexapawnDifficulty()
    {
        SceneManager.LoadScene("hexapawnDifficulty");
    }

    public void loadOctopawnDifficulty()
    {
        SceneManager.LoadScene("octopawnDifficulty");
    }

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

    public void loadHexapawnEasy()
    {
        SceneManager.LoadScene("hexapawnEasySingleplayer");
    }

    public void loadHexapawnMedium()
    {
        SceneManager.LoadScene("hexapawnMediumSingleplayer");
    }

    public void loadHexapawnHard()
    {
        SceneManager.LoadScene("hexapawnHardSingleplayer");
    }

    public void loadHexapawnInsane()
    {
        SceneManager.LoadScene("hexapawnInsaneSingleplayer");
    }
    
    public void loadOctopawnEasy()
    {
        SceneManager.LoadScene("octopawnEasySingleplayer");
    }

    public void loadOctopawnMedium()
    {
        SceneManager.LoadScene("octopawnMediumSingleplayer");
    }

    public void loadOctopawnHard()
    {
        SceneManager.LoadScene("octopawnHardSingleplayer");
    }

    public void loadOctopawnInsane()
    {
        SceneManager.LoadScene("octopawnInsaneSingleplayer");
    }

    public void loadHexapawnMultiPlayer()
    {
        SceneManager.LoadScene("hexapawnMultiplayer");
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
