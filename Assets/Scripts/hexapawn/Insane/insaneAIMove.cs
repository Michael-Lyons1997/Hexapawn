using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insaneAIMove : MonoBehaviour
{
    public GameObject AIPawnOne;
    public GameObject AIPawnTwo;
    public GameObject AIPawnThree;
    public GameObject playerPawnOne;
    public GameObject playerPawnTwo;
    public GameObject playerPawnThree;
    public GameObject a1;
    public GameObject a2;
    public GameObject a3;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public insanePlayerMove playerScript;
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
    bool PawnTwoOnA2;
    bool PawnTwoOnB1;
    bool PawnTwoOnB2;
    bool PawnTwoOnB3;
    bool PawnTwoOnC1;
    bool PawnTwoOnC2;
    bool PawnTwoOnC3; 
    bool PawnThreeOnA3;
    bool PawnThreeOnB2;
    bool PawnThreeOnB3;
    bool PawnThreeOnC1;
    bool PawnThreeOnC2;
    bool PawnThreeOnC3;
    bool otherPawnOneOnB1;
    bool otherPawnOneOnB2;
    bool otherPawnOneOnC1;
    bool otherPawnTwoOnB1;
    bool otherPawnTwoOnB2;
    bool otherPawnTwoOnB3;
    bool otherPawnTwoOnC2;
    bool otherPawnThreeOnB2;
    bool otherPawnThreeOnB3;
    bool otherPawnThreeOnC3;
    bool movePawnOne;
    bool movePawnTwo;
    bool movePawnThree;
    public bool AITurn;
    public int playerPawnNumber;
    public bool pawnOneCantMove;
    public bool pawnTwoCantMove;
    public bool pawnThreeCantMove;
    float timer;
    float timeDelay;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.FindWithTag("GameController").GetComponent<insanePlayerMove>();
        AIPawnOne = GameObject.FindWithTag("AI-Pawn-1");
        AIPawnTwo = GameObject.FindWithTag("AI-Pawn-2");
        AIPawnThree = GameObject.FindWithTag("AI-Pawn-3");
        playerPawnOne = GameObject.FindWithTag("Player-1");
        playerPawnTwo = GameObject.FindWithTag("Player-2");
        playerPawnThree = GameObject.FindWithTag("Player-3");
        a1 = GameObject.FindWithTag("A1");
        a2 = GameObject.FindWithTag("A2");
        a3 = GameObject.FindWithTag("A3");
        b1 = GameObject.FindWithTag("B1");
        b2 = GameObject.FindWithTag("B2");
        b3 = GameObject.FindWithTag("B3");
        c1 = GameObject.FindWithTag("C1");
        c2 = GameObject.FindWithTag("C2");
        c3 = GameObject.FindWithTag("C3");
        AITurn = false;
        playerPawnNumber = 3;
        pawnOneCantMove = false;
        pawnTwoCantMove = false;
        pawnThreeCantMove = false;
        timer = 0.0f;
        timeDelay = 0.5f;
        volume = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        PawnOneOnA1 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnOneOnA1;
        PawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnOneOnB1;
        PawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnOneOnB2;
        PawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnOneOnC1;
        PawnOneOnC2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnOneOnC2;
        PawnOneOnC3 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnOneOnC3; 
        PawnTwoOnA2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnTwoOnA2; 
        PawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnTwoOnB1;
        PawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnTwoOnB2;
        PawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnTwoOnB3;
        PawnTwoOnC1 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnTwoOnC1; 
        PawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnTwoOnC2; 
        PawnTwoOnC3 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnTwoOnC3; 
        PawnThreeOnA3 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnThreeOnA3;
        PawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnThreeOnB2;
        PawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnThreeOnB3;
        PawnThreeOnC1 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnThreeOnC1;
        PawnThreeOnC2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnThreeOnC2;
        PawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnThreeOnC3;
        otherPawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnOneOnB1;
        otherPawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnOneOnB2;
        otherPawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnOneOnC1;
        otherPawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnTwoOnB1;
        otherPawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnTwoOnB2;
        otherPawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnTwoOnB3;
        otherPawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnTwoOnC2;
        otherPawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnThreeOnB2;
        otherPawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnThreeOnB3;
        otherPawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnThreeOnC3;
        movePawnOne = GameObject.FindWithTag("GameController").GetComponent<insaneAI>().pawnOneMove;
        movePawnTwo = GameObject.FindWithTag("GameController").GetComponent<insaneAI>().pawnTwoMove;
        movePawnThree = GameObject.FindWithTag("GameController").GetComponent<insaneAI>().pawnThreeMove;
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
            else if(!otherPawnOneOnB1 && !otherPawnTwoOnB1 && !PawnTwoOnB1)
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
            if(otherPawnTwoOnC2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnOne.transform.position = c2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnOneOnC1 && !PawnTwoOnC1 && !PawnThreeOnC1)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnOne.transform.position = c1.transform.position;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnOneCantMove = true;;
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
            else if(otherPawnThreeOnC3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnOne.transform.position = c3.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnOneCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnTwoOnC2 && !PawnTwoOnC2 && !PawnThreeOnC2)
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
            else if(!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2 && !PawnOneOnB2 && !PawnThreeOnB2)
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
            else if(otherPawnThreeOnC3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = c3.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnTwoOnC2 && !PawnOneOnC2 && !PawnThreeOnC2)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnTwo.transform.position = c2.transform.position;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnTwoCantMove= true;
            }
        }
        else if(PawnTwoOnB1)
        {
            if(otherPawnTwoOnC2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = c2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnOneOnC1 && !PawnOneOnC1 && !PawnThreeOnC1)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnTwo.transform.position = c1.transform.position;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnTwoCantMove= true;
            }
        }
        else if(PawnTwoOnB3)
        { 
            if(otherPawnTwoOnC2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnTwo.transform.position = c2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnThreeOnC3 && !PawnOneOnC3 && !PawnThreeOnC3)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnTwo.transform.position = c3.transform.position;
                pawnTwoCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnTwoCantMove= true;
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
            else if(!otherPawnTwoOnB3 && !otherPawnThreeOnB3 && !PawnTwoOnB3)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnThree.transform.position = b3.transform.position;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnThreeCantMove= true;
            }
        }
        else if(PawnThreeOnB3)
        {
            if(otherPawnTwoOnC2)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = c2.transform.position;
                playerPawnTwo.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnThreeOnC3 && !PawnOneOnC3 && !PawnTwoOnC3)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnThree.transform.position = c3.transform.position;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnThreeCantMove= true;
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
            else if(otherPawnThreeOnC3)
            {
                audioSource.PlayOneShot(takePawn, volume);
                AIPawnThree.transform.position = c3.transform.position;
                playerPawnThree.SetActive(false);
                playerPawnNumber--;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else if(!otherPawnTwoOnC2 && !PawnOneOnC2 && !PawnThreeOnC2)
            {
                audioSource.PlayOneShot(pawnMove, volume);
                AIPawnThree.transform.position = c2.transform.position;
                pawnThreeCantMove = false;
                swapToPlayerTurn();
            }
            else
            {
                pawnThreeCantMove= true;
            }
        }
    }

    void swapToPlayerTurn()
    {
        AITurn = false;
        playerScript.turnTimer = 1.0f;
        playerScript.playerTurn = true;
    }
}
