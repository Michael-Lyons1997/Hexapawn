using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class octopawnMediumAIMove : MonoBehaviour
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
    public octopawnMediumPlayerMove playerScript;
    public AudioSource audioSource;
    public AudioClip pawnMove;
    public AudioClip takePawn;
    public float volume;
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
        playerScript = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumPlayerMove>();
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
        pawnFourCantMove = false;
        timer = 0.0f;
        timeDelay = 0.5f;
        volume = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        PawnOneOnA1 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnOneOnA1;
        PawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnOneOnB1;
        PawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnOneOnB2;
        PawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnOneOnC1;
        PawnOneOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnOneOnC2;
        PawnOneOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnOneOnC3; 
        PawnOneOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnOneOnD1;
        PawnOneOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnOneOnD2;
        PawnOneOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnOneOnD3; 
        PawnOneOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnOneOnD4; 
        PawnTwoOnA2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnTwoOnA2; 
        PawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnTwoOnB1;
        PawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnTwoOnB2;
        PawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnTwoOnB3;
        PawnTwoOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnTwoOnC1; 
        PawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnTwoOnC2; 
        PawnTwoOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnTwoOnC3; 
        PawnTwoOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnTwoOnC4;
        PawnTwoOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnTwoOnD1;
        PawnTwoOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnTwoOnD2;
        PawnTwoOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnTwoOnD3; 
        PawnTwoOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnTwoOnD4;  
        PawnThreeOnA3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnThreeOnA3;
        PawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnThreeOnB2;
        PawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnThreeOnB3;
        PawnThreeOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnThreeOnB4;
        PawnThreeOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnThreeOnC1;
        PawnThreeOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnThreeOnC2;
        PawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnThreeOnC3;
        PawnThreeOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnThreeOnC4;
        PawnThreeOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnThreeOnD1;
        PawnThreeOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnThreeOnD2;
        PawnThreeOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnThreeOnD3;
        PawnThreeOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnThreeOnD4;
        PawnFourOnA4 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnFourOnA4;
        PawnFourOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnFourOnB3;
        PawnFourOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnFourOnB4;
        PawnFourOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnFourOnC2;
        PawnFourOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnFourOnC3;
        PawnFourOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnFourOnC4;
        PawnFourOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnFourOnD1;
        PawnFourOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnFourOnD2;
        PawnFourOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnFourOnD3;
        PawnFourOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().AIPawnFourOnD4;
        otherPawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnOneOnB1;
        otherPawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnOneOnB2;
        otherPawnOneOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnOneOnB3;
        otherPawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnOneOnC1;
        otherPawnOneOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnOneOnC2;
        otherPawnOneOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnOneOnD1;
        otherPawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnTwoOnB1;
        otherPawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnTwoOnB2;
        otherPawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnTwoOnB3;
        otherPawnTwoOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnTwoOnB4;
        otherPawnTwoOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnTwoOnC1;
        otherPawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnTwoOnC2;
        otherPawnTwoOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnTwoOnC3;
        otherPawnTwoOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnTwoOnD2;
        otherPawnThreeOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnThreeOnB1;
        otherPawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnThreeOnB2;
        otherPawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnThreeOnB3;
        otherPawnThreeOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnThreeOnB4;
        otherPawnThreeOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnThreeOnC2;
        otherPawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnThreeOnC3;
        otherPawnThreeOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnThreeOnC4;
        otherPawnThreeOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnThreeOnD3;
        otherPawnFourOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnFourOnB2;
        otherPawnFourOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnFourOnB3;
        otherPawnFourOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnFourOnB4;
        otherPawnFourOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnFourOnC3;
        otherPawnFourOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnFourOnC4;
        otherPawnFourOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumBoardState>().playerPawnFourOnD4;
        movePawnOne = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumAI>().pawnOneMove;
        movePawnTwo = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumAI>().pawnTwoMove;
        movePawnThree = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumAI>().pawnThreeMove;
        movePawnFour = GameObject.FindWithTag("GameController").GetComponent<octopawnMediumAI>().pawnFourMove;
        if(AITurn)
        {
           timer += 1.0f * Time.deltaTime;

            if (timer >= timeDelay)
            {
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
                timer = 0.0f;
            }
        }
    }

    void moveAIPawnOne()
    {
        if(PawnOneOnA1)
        {
            if(otherPawnOneOnB2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnOne.transform.position = b2.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnTwoOnB2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnOne.transform.position = b2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnB2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnOne.transform.position = b2.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnFourOnB2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnOne.transform.position = b2.transform.position;
                playerPawnFour.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnOneOnB1 && !otherPawnTwoOnB1 && !otherPawnThreeOnB1 && !PawnTwoOnB1)
            {
                audioSource.PlayOneShot(pawnMove, volume);
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
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnOne.transform.position = c2.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnTwoOnC2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnOne.transform.position = c2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnC2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnOne.transform.position = c2.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnOneOnC1 && !otherPawnTwoOnC1 && !PawnTwoOnC1 && !PawnThreeOnC1)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnOne.transform.position = c1.transform.position;
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
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnOne.transform.position = c1.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnTwoOnC1)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnOne.transform.position = c1.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnTwoOnC3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnOne.transform.position = c3.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnC3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnOne.transform.position = c3.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnFourOnC3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnOne.transform.position = c3.transform.position;
                playerPawnFour.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnOneOnC2 && !otherPawnTwoOnC2 && !otherPawnThreeOnC2 && !PawnTwoOnC2 && !PawnThreeOnC2 && !PawnFourOnC2)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnOne.transform.position = c2.transform.position;
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
            if(otherPawnTwoOnD2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnOne.transform.position = d2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnOneOnD1 && !PawnTwoOnD1 && !PawnThreeOnD1 && !PawnFourOnD1)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnOne.transform.position = d1.transform.position;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnOneCantMove = true;
            }
        }
        else if(PawnOneOnC2)
        {
            if(otherPawnOneOnD1)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnOne.transform.position = d1.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnD3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnOne.transform.position = d3.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnTwoOnD2 && !PawnTwoOnD2 && !PawnThreeOnD2 && !PawnFourOnD2)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnOne.transform.position = d2.transform.position;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnOneCantMove = true;
            }
        }
        else if(PawnOneOnC3)
        {
            if(otherPawnTwoOnD2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnOne.transform.position = d2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnFourOnD4)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnOne.transform.position = d4.transform.position;
                playerPawnFour.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnThreeOnD3 && !PawnTwoOnD3 && !PawnThreeOnD3 && !PawnFourOnD3)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnOne.transform.position = d3.transform.position;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnOneCantMove = true;
            }
        }
    }
    void moveAIPawnTwo()
    {
        if(PawnTwoOnA2)
        {
            if(otherPawnOneOnB1)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = b1.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnTwoOnB1)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = b1.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnB1)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = b1.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnOneOnB3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = b3.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnTwoOnB3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = b3.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnB3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = b3.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnFourOnB3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = b3.transform.position;
                playerPawnFour.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2 && !otherPawnFourOnB2 && !PawnOneOnB2 && !PawnThreeOnB2)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnTwo.transform.position = b2.transform.position;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnTwoCantMove = true;
            }
        }
        else if(PawnTwoOnB2)
        {
            if(otherPawnOneOnC1)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = c1.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnTwoOnC1)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = c1.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnTwoOnC3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = c3.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnC3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = c3.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnFourOnC3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = c3.transform.position;
                playerPawnFour.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnOneOnC2 && !otherPawnTwoOnC2 && !otherPawnThreeOnC2 && !PawnOneOnC2 && !PawnThreeOnC2 && !PawnFourOnC2)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnTwo.transform.position = c2.transform.position;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnTwoCantMove = true;
            }
        }
        else if(PawnTwoOnB1)
        {
           if(otherPawnOneOnC2)
           {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = c2.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
           }
           else if(otherPawnTwoOnC2)
           {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = c2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
           }
           else if(otherPawnThreeOnC2)
           {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = c2.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
           }
           else if(!otherPawnOneOnC1 && !otherPawnTwoOnC1 && !PawnTwoOnC1 && !PawnThreeOnC1)
           {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnTwo.transform.position = c1.transform.position;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
           }
           else
           {
                pawnTwoCantMove = true;
           }
        }
        else if(PawnTwoOnB3)
        { 
            if(otherPawnOneOnC2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = c2.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnTwoOnC2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = c2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnC2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = c2.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnC4)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = c4.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnFourOnC4)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = c4.transform.position;
                playerPawnFour.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnTwoOnC3 && !otherPawnThreeOnC3 && !otherPawnFourOnC3 && !PawnTwoOnC3 && !PawnThreeOnC3 && !PawnFourOnC3)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnTwo.transform.position = c3.transform.position;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnTwoCantMove = true;
            }
        }
        else if(PawnTwoOnC1)
        {
            if(otherPawnTwoOnD2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = d2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnOneOnD1 && !PawnTwoOnD1 && !PawnThreeOnD1 && !PawnFourOnD1)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnTwo.transform.position = d1.transform.position;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnTwoCantMove = true;
            }
        }
        else if(PawnTwoOnC2)
        {
            if(otherPawnOneOnD1)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = d1.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnD3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = d3.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnTwoOnD2 && !PawnTwoOnD2 && !PawnThreeOnD2 && !PawnFourOnD2)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnTwo.transform.position = d2.transform.position;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnTwoCantMove = true;
            }
        }
        else if(PawnTwoOnC3)
        {
            if(otherPawnTwoOnD2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = d2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnFourOnD4)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = d4.transform.position;
                playerPawnFour.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnThreeOnD3 && !PawnTwoOnD3 && !PawnThreeOnD3 && !PawnFourOnD3)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnTwo.transform.position = c3.transform.position;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnTwoCantMove = true;
            }
        }
        else if(PawnTwoOnC4)
        {
            if(otherPawnThreeOnC3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = d3.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnFourOnC4 && !PawnTwoOnD4 && !PawnThreeOnD4 && !PawnFourOnD4)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnTwo.transform.position = c3.transform.position;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnTwoCantMove = true;
            }
        }
    }
    void moveAIPawnThree()
    {
        if(PawnThreeOnA3)
        {
            if(otherPawnOneOnB2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = b2.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnTwoOnB2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = b2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnB2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = b2.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnFourOnB2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = b2.transform.position;
                playerPawnFour.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnTwoOnB4)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = b4.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnB4)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = b4.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnFourOnB4)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = b4.transform.position;
                playerPawnFour.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnOneOnB3 && !otherPawnTwoOnB3 && !otherPawnThreeOnB3 && !otherPawnFourOnB3 && !PawnTwoOnB3 && !PawnFourOnB3)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnThree.transform.position = b3.transform.position;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnThreeCantMove = true;
            }
        }
        else if(PawnThreeOnB3)
        {
            if(otherPawnOneOnC2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = c2.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnTwoOnC2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = c2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnC2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = c2.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnC4)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = c4.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnFourOnC4)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = c4.transform.position;
                playerPawnFour.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnTwoOnC3 && !otherPawnThreeOnC3 && !otherPawnThreeOnC3 && !PawnOneOnC3 && !PawnTwoOnC3 && !PawnFourOnC3)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnThree.transform.position = c3.transform.position;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnThreeCantMove = true;
            }
        }
        else if(PawnThreeOnB2)
        {
            if(otherPawnOneOnC1)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = c1.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnTwoOnC1)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = c1.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnTwoOnC3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = c3.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnC3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = c3.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnFourOnC3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = c3.transform.position;
                playerPawnFour.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnOneOnC2 && !otherPawnTwoOnC2 && !otherPawnTwoOnC2 && !PawnOneOnC2 && !PawnTwoOnC2 && !PawnFourOnC2)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnThree.transform.position = c2.transform.position;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnThreeCantMove = true;
            }
        }
        else if(PawnThreeOnB4)
        {
            if(otherPawnTwoOnC3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = c3.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnC3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = c3.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnFourOnC3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = c3.transform.position;
                playerPawnFour.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnThreeOnC4 && !otherPawnFourOnC4 && !PawnTwoOnC4 && !PawnFourOnC4)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnThree.transform.position = d1.transform.position;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnThreeCantMove = true;
            }
        }
        else if(PawnThreeOnC1)
        {
            if(otherPawnTwoOnD2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = d2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnFourOnD4 && !PawnOneOnD1 && !PawnTwoOnD1 && !PawnFourOnD1)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnThree.transform.position = d1.transform.position;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnThreeCantMove = true;
            }
        }
        else if(PawnThreeOnC2)
        {
            if(otherPawnOneOnD1)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = d1.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnD3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = d3.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnTwoOnD2 && !PawnOneOnD2 && !PawnTwoOnD2 && !PawnFourOnD2)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnThree.transform.position = d2.transform.position;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnThreeCantMove = true;
            }
        }
        else if(PawnThreeOnC3)
        {
            if(otherPawnTwoOnD2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = d2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnFourOnD4)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = d4.transform.position;
                playerPawnFour.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnThreeOnD3 && !PawnOneOnD3 && !PawnTwoOnD3 && !PawnFourOnD3)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnThree.transform.position = d3.transform.position;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnThreeCantMove = true;
            }
        }
        else if(PawnThreeOnC4)
        {
            if(otherPawnThreeOnD3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = d3.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnFourOnD4 && !PawnOneOnD4 && !PawnTwoOnD4 && !PawnFourOnD4)
            {   
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnThree.transform.position = d4.transform.position;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnThreeCantMove = true;
            }
        }
    }

    void moveAIPawnFour()
    {
        if(PawnFourOnA4)
        {
            if(otherPawnOneOnB3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnFour.transform.position = b3.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnTwoOnB3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnFour.transform.position = b3.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnB3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnFour.transform.position = b3.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnFourOnB3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnFour.transform.position = b3.transform.position;
                playerPawnFour.SetActive(false);
                playerPawnNumber--;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnTwoOnB4 && !otherPawnThreeOnB4 && !otherPawnFourOnB4 && !PawnThreeOnB4 && !PawnFourOnB4)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnFour.transform.position = b4.transform.position;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnFourCantMove = true;
            }
        }
        else if(PawnFourOnB3)
        {
            if(otherPawnOneOnC2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnFour.transform.position = c2.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnFourCantMove = false;
                swapToPlayerTurn(); 
            }
            else if(otherPawnTwoOnC2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnFour.transform.position = c2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnC4)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnFour.transform.position = c4.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnFourOnC4)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnFour.transform.position = c4.transform.position;
                playerPawnFour.SetActive(false);
                playerPawnNumber--;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnTwoOnC3 && !otherPawnThreeOnC3 && !otherPawnFourOnC3 && !PawnOneOnC3 && !PawnTwoOnC3 && !PawnThreeOnC3)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnFour.transform.position = c3.transform.position;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnFourCantMove = true;
            }
        }
        else if(PawnFourOnB4)
        {
            if(otherPawnTwoOnC3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnFour.transform.position = c3.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnC3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnFour.transform.position = c3.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnFourOnC3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnFour.transform.position = c3.transform.position;
                playerPawnFour.SetActive(false);
                playerPawnNumber--;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnThreeOnC4 && !otherPawnFourOnC4 && !PawnTwoOnC4 && !PawnThreeOnC4)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnFour.transform.position = c4.transform.position;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnFourCantMove = true;
            }
        }
        else if(PawnFourOnC2)
        {
            if(otherPawnOneOnD1)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnFour.transform.position = d1.transform.position;
                playerPawnOne.SetActive(false);
                playerPawnNumber--;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnThreeOnD3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnFour.transform.position = d3.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnTwoOnD2 && !PawnOneOnD2 && !PawnTwoOnD2 && !PawnThreeOnD2)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnFour.transform.position = d2.transform.position;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnFourCantMove = true;
            }
        }
        else if(PawnFourOnC3)
        {
            if(otherPawnTwoOnD2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnFour.transform.position = d2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else if(otherPawnFourOnD4)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnFour.transform.position = d4.transform.position;
                playerPawnFour.SetActive(false);
                playerPawnNumber--;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnThreeOnD3 && !PawnOneOnD3 && !PawnTwoOnD3 && !PawnThreeOnD3)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnFour.transform.position = d3.transform.position;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnFourCantMove = true;
            }
        }
        else if(PawnFourOnC4)
        {
            if(otherPawnThreeOnD3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnFour.transform.position = d3.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnFourOnD4 && !PawnOneOnD4 && !PawnTwoOnD4 && !PawnThreeOnD4)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnFour.transform.position = d4.transform.position;
                pawnFourCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnFourCantMove = true;
            }
        }
    }

    void swapToPlayerTurn()
    {
        AITurn = false;
        playerScript.turnTimer = 5.0f;
        playerScript.playerTurn = true;
    }
}
