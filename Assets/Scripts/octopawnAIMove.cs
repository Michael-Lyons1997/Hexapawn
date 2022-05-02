using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class octopawnAIMove : MonoBehaviour
{
    public GameObject AIPawnOne;
    public GameObject AIPawnTwo;
    public GameObject AIPawnThree;
    public GameObject AIPawnFour;
    public GameObject playerPawnOne;
    public GameObject playerPawnTwo;
    public GameObject playerPawnThree;
    public GameObject playerPawnFour;
    public GameObject a1;
    public GameObject a2;
    public GameObject a3;
    public GameObject a4;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;
    public GameObject d1;
    public GameObject d2;
    public GameObject d3;
    public GameObject d4;
    public octopawnPlayerMove playerScript;
    bool PawnOneOnA1;
    bool PawnOneOnB1;
    bool PawnOneOnB2;
    bool PawnOneOnC1;
    bool PawnOneOnC2;
    bool PawnOneOnC3;
    bool PawnOneOnD1;
    bool PawnOneOnD2;
    bool PawnOneOnD3;
    bool PawnOneOnD4;
    bool PawnTwoOnA2;
    bool PawnTwoOnB1;
    bool PawnTwoOnB2;
    bool PawnTwoOnB3;
    bool PawnTwoOnC1;
    bool PawnTwoOnC2;
    bool PawnTwoOnC3; 
    bool PawnTwoOnC4; 
    bool PawnTwoOnD1;
    bool PawnTwoOnD2;
    bool PawnTwoOnD3; 
    bool PawnTwoOnD4; 
    bool PawnThreeOnA3;
    bool PawnThreeOnB2;
    bool PawnThreeOnB3;
    bool PawnThreeOnB4;
    bool PawnThreeOnC1;
    bool PawnThreeOnC2;
    bool PawnThreeOnC3;
    bool PawnThreeOnC4;
    bool PawnThreeOnD1;
    bool PawnThreeOnD2;
    bool PawnThreeOnD3;
    bool PawnThreeOnD4;
    bool PawnFourOnA4;
    bool PawnFourOnB3;
    bool PawnFourOnB4;
    bool PawnFourOnC2;
    bool PawnFourOnC3;
    bool PawnFourOnC4;
    bool PawnFourOnD1;
    bool PawnFourOnD2;
    bool PawnFourOnD3;
    bool PawnFourOnD4;
    bool otherPawnOneOnB1;
    bool otherPawnOneOnB2;
    bool otherPawnOneOnB3;
    bool otherPawnOneOnC1;
    bool otherPawnOneOnC2;
    bool otherPawnOneOnD1;
    bool otherPawnTwoOnB1;
    bool otherPawnTwoOnB2;
    bool otherPawnTwoOnB3;
    bool otherPawnTwoOnB4;
    bool otherPawnTwoOnC1;
    bool otherPawnTwoOnC2;
    bool otherPawnTwoOnC3;
    bool otherPawnTwoOnD2;
    bool otherPawnThreeOnB1;
    bool otherPawnThreeOnB2;
    bool otherPawnThreeOnB3;
    bool otherPawnThreeOnB4;
    bool otherPawnThreeOnC2;
    bool otherPawnThreeOnC3;
    bool otherPawnThreeOnC4;
    bool otherPawnThreeOnD3;
    bool otherPawnFourOnB2;
    bool otherPawnFourOnB3;
    bool otherPawnFourOnB4;
    bool otherPawnFourOnC3;
    bool otherPawnFourOnC4;
    bool otherPawnFourOnD4;
    bool movePawnOne;
    bool movePawnTwo;
    bool movePawnThree;
    bool movePawnFour;
    public bool AITurn;
    public int playerPawnNumber;
    public bool pawnOneCantMove;
    public bool pawnTwoCantMove;
    public bool pawnThreeCantMove;
    public bool pawnFourCantMove;
    float timer;
    float timeDelay;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.FindWithTag("GameController").GetComponent<octopawnPlayerMove>();
        AIPawnOne = GameObject.FindWithTag("AI-Pawn-1");
        AIPawnTwo = GameObject.FindWithTag("AI-Pawn-2");
        AIPawnThree = GameObject.FindWithTag("AI-Pawn-3");
        AIPawnFour = GameObject.FindWithTag("AI-Pawn-4");
        playerPawnOne = GameObject.FindWithTag("Player-1");
        playerPawnTwo = GameObject.FindWithTag("Player-2");
        playerPawnThree = GameObject.FindWithTag("Player-3");
        playerPawnFour = GameObject.FindWithTag("Player-4");
        a1 = GameObject.FindWithTag("A1");
        a2 = GameObject.FindWithTag("A2");
        a3 = GameObject.FindWithTag("A3");
        a4 = GameObject.FindWithTag("A4");
        b1 = GameObject.FindWithTag("B1");
        b2 = GameObject.FindWithTag("B2");
        b3 = GameObject.FindWithTag("B3");
        b4 = GameObject.FindWithTag("B4");
        c1 = GameObject.FindWithTag("C1");
        c2 = GameObject.FindWithTag("C2");
        c3 = GameObject.FindWithTag("C3");
        c4 = GameObject.FindWithTag("C4");
        d1 = GameObject.FindWithTag("D1");
        d2 = GameObject.FindWithTag("D2");
        d3 = GameObject.FindWithTag("D3");
        d4 = GameObject.FindWithTag("D4");
        AITurn = false;
        playerPawnNumber = 4;
        pawnOneCantMove = false;
        pawnTwoCantMove = false;
        pawnThreeCantMove = false;
        timer = 0.0f;
        timeDelay = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        PawnOneOnA1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnOneOnA1;
        PawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnOneOnB1;
        PawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnOneOnB2;
        PawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnOneOnC1;
        PawnOneOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnOneOnC2;
        PawnOneOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnOneOnC3; 
        PawnOneOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnOneOnD1;
        PawnOneOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnOneOnD2;
        PawnOneOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnOneOnD3; 
        PawnOneOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnOneOnD4; 
        PawnTwoOnA2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnA2; 
        PawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnB1;
        PawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnB2;
        PawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnB3;
        PawnTwoOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnC1; 
        PawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnC2; 
        PawnTwoOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnC3; 
        PawnTwoOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnC4;
        PawnTwoOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnD1;
        PawnTwoOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnD2;
        PawnTwoOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnD3; 
        PawnTwoOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnD4;  
        PawnThreeOnA3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnA3;
        PawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnB2;
        PawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnB3;
        PawnThreeOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnB4;
        PawnThreeOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnC1;
        PawnThreeOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnC2;
        PawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnC3;
        PawnThreeOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnC4;
        PawnThreeOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnD1;
        PawnThreeOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnD2;
        PawnThreeOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnD3;
        PawnThreeOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnD4;
        PawnFourOnA4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnFourOnA4;
        PawnFourOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnFourOnB3;
        PawnFourOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnFourOnB4;
        PawnFourOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnFourOnC2;
        PawnFourOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnFourOnC3;
        PawnFourOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnFourOnC4;
        PawnFourOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnFourOnD1;
        PawnFourOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnFourOnD2;
        PawnFourOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnFourOnD3;
        PawnFourOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnFourOnD4;
        otherPawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnOneOnB1;
        otherPawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnOneOnB2;
        otherPawnOneOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnOneOnB3;
        otherPawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnOneOnC1;
        otherPawnOneOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnOneOnC2;
        otherPawnOneOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnOneOnD1;
        otherPawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnB1;
        otherPawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnB2;
        otherPawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnB3;
        otherPawnTwoOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnB4;
        otherPawnTwoOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnC1;
        otherPawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnC2;
        otherPawnTwoOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnC3;
        otherPawnTwoOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnD2;
        otherPawnThreeOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnB1;
        otherPawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnB2;
        otherPawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnB3;
        otherPawnThreeOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnB4;
        otherPawnThreeOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnC2;
        otherPawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnC3;
        otherPawnThreeOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnC4;
        otherPawnThreeOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnD3;
        otherPawnFourOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnFourOnB2;
        otherPawnFourOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnFourOnB3;
        otherPawnFourOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnFourOnB4;
        otherPawnFourOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnFourOnC3;
        otherPawnFourOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnFourOnC4;
        otherPawnFourOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnFourOnD4;
        movePawnOne = GameObject.FindWithTag("GameController").GetComponent<octopawnAI>().pawnOneMove;
        movePawnTwo = GameObject.FindWithTag("GameController").GetComponent<octopawnAI>().pawnTwoMove;
        movePawnThree = GameObject.FindWithTag("GameController").GetComponent<octopawnAI>().pawnThreeMove;
        movePawnFour = GameObject.FindWithTag("GameController").GetComponent<octopawnAI>().pawnFourMove;
        if(AITurn)
        {
           timer += 1.0f * Time.deltaTime;

            if (timer >= timeDelay)
            {
                timer = 0.0f;
                if(movePawnOne)
                {
                    moveAIPawnOne();
                }
                if(movePawnTwo)
                {
                    moveAIPawnTwo();
                }
                if(movePawnThree)
                {
                    moveAIPawnThree();
                }
                if(movePawnFour)
                {
                    moveAIPawnFour();
                }
            }
        }
    }

    void moveAIPawnOne()
    {
        if(PawnOneOnA1)
        {
            if(otherPawnOneOnB2)
            {
                AIPawnOne.transform.position = b2.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnTwoOnB2)
            {
                AIPawnOne.transform.position = b2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnB2)
            {
                AIPawnOne.transform.position = b2.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnFourOnB2)
            {
                AIPawnOne.transform.position = b2.transform.position;
                playerPawnFour.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnOneOnB1 && !otherPawnTwoOnB1 && !otherPawnThreeOnB1 && !PawnTwoOnB1)
            {
                AIPawnOne.transform.position = b1.transform.position;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnOneCantMove = true;
            }
        }
        else if(PawnOneOnB1)
        {
            if(otherPawnOneOnC2)
            {
                AIPawnOne.transform.position = c2.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnTwoOnC2)
            {
                AIPawnOne.transform.position = c2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnC2)
            {
                AIPawnOne.transform.position = c2.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnOneOnC1 && !otherPawnTwoOnC1 && !PawnTwoOnC1 && !PawnThreeOnC1)
            {
                AIPawnOne.transform.position = b1.transform.position;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnOneCantMove = true;
            }
        }
        else if(PawnOneOnB2)
        {
            if(otherPawnOneOnC1)
            {
                AIPawnOne.transform.position = c1.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnTwoOnC1)
            {
                AIPawnOne.transform.position = c1.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnTwoOnC3)
            {
                AIPawnOne.transform.position = c3.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnC3)
            {
                AIPawnOne.transform.position = c3.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnFourOnC3)
            {
                AIPawnOne.transform.position = c3.transform.position;
                playerPawnFour.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnOneOnC2 && !otherPawnTwoOnC2 && !PawnTwoOnC2 && !PawnThreeOnC2 && !PawnFourOnC2)
            {
                AIPawnOne.transform.position = b2.transform.position;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnOneCantMove = true;
            }
        }
        else if(PawnOneOnC1)
        {

        }
        else if(PawnOneOnC2)
        {

        }
        else if(PawnOneOnC3)
        {

        }
    }
    void moveAIPawnTwo()
    {
        if(PawnTwoOnA2)
        {
            
        }
        else if(PawnTwoOnB2)
        {
            
        }
        else if(PawnTwoOnB1)
        {
           
        }
        else if(PawnTwoOnB3)
        { 
            
        }
        else if(PawnTwoOnC1)
        {

        }
        else if(PawnTwoOnC2)
        {

        }
        else if(PawnTwoOnC3)
        {

        }
        else if(PawnTwoOnC4)
        {

        }
    }
    void moveAIPawnThree()
    {
        if(PawnThreeOnA3)
        {
            
        }
        else if(PawnThreeOnB3)
        {
            
        }
        else if(PawnThreeOnB2)
        {
            
        }
        else if(PawnThreeOnC1)
        {

        }
        else if(PawnThreeOnC2)
        {

        }
        else if(PawnThreeOnC3)
        {

        }
        else if(PawnThreeOnC4)
        {

        }
    }

    void moveAIPawnFour()
    {
        if(PawnFourOnA4)
        {
            
        }
        else if(PawnFourOnB3)
        {
            
        }
        else if(PawnFourOnB4)
        {
            
        }
        else if(PawnFourOnC2)
        {

        }
        else if(PawnFourOnC3)
        {

        }
        else if(PawnFourOnC4)
        {

        }
    }

    void swapToPlayerTurn()
    {
        AITurn = false;
        playerScript.playerTurn = true;
    }
}
