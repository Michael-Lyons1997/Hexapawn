using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerTwoMove : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
    public GameObject playerPawnOne;
    public GameObject playerPawnTwo;
    public GameObject playerPawnThree;
    public GameObject opponentPawnOne;
    public GameObject opponentPawnTwo;
    public GameObject opponentPawnThree;
    public GameObject pawnHighlight;
    public GameObject squareHighlight;
    public GameObject squarePawnHighlight;
    public GameObject squarePawnHighlightTwo;
    public GameObject a1;
    public GameObject a2;
    public GameObject a3;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public playerOneMove playerOneMoveScript;
    public AudioSource audioSource;
    public AudioClip pawnMove;
    public AudioClip takePawn;
    public float volume;
    bool pawnOneClicked;
    bool pawnTwoClicked;
    bool pawnThreeClicked;
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
    public bool playerTwoTurn;
    public int playerOnePawnNumber;
    public bool pawnOneCantMove;
    public bool pawnTwoCantMove;
    public bool pawnThreeCantMove;
    // Start is called before the first frame update
    void Start()
    {
        playerOneMoveScript = GameObject.FindWithTag("GameController").GetComponent<playerOneMove>();
        addPhysics2DRaycaster();
        playerPawnOne = GameObject.FindWithTag("player-2-pawn-1");
        playerPawnTwo = GameObject.FindWithTag("player-2-pawn-2");
        playerPawnThree = GameObject.FindWithTag("player-2-pawn-3");
        opponentPawnOne = GameObject.FindWithTag("Player-1");
        opponentPawnTwo = GameObject.FindWithTag("Player-2");
        opponentPawnThree = GameObject.FindWithTag("Player-3");
        pawnHighlight = GameObject.FindWithTag("player-2-pawn-highlight");
        squareHighlight = GameObject.FindWithTag("player-2-square-highlight");
        squarePawnHighlight = GameObject.FindWithTag("player-2-square-pawn-highlight");
        squarePawnHighlightTwo = GameObject.FindWithTag("player-2-square-pawn-two-highlight");
        pawnHighlight.SetActive(false);
        squareHighlight.SetActive(false);
        squarePawnHighlight.SetActive(false);
        squarePawnHighlightTwo.SetActive(false);
        a1 = GameObject.FindWithTag("A1");
        a2 = GameObject.FindWithTag("A2");
        a3 = GameObject.FindWithTag("A3");
        b1 = GameObject.FindWithTag("B1");
        b2 = GameObject.FindWithTag("B2");
        b3 = GameObject.FindWithTag("B3");
        c1 = GameObject.FindWithTag("C1");
        c2 = GameObject.FindWithTag("C2");
        c3 = GameObject.FindWithTag("C3");
        pawnOneClicked = false;
        pawnTwoClicked = false;
        pawnThreeClicked = false;
        playerTwoTurn = false;
        playerOnePawnNumber = 3;
        pawnOneCantMove = false;
        pawnTwoCantMove = false;
        pawnThreeCantMove = false;
        volume = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        PawnOneOnA1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnOneOnA1;
        PawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnOneOnB1;
        PawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnOneOnB2;
        PawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnOneOnC1;
        PawnOneOnC2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnOneOnC2;
        PawnOneOnC3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnOneOnC3; 
        PawnTwoOnA2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnTwoOnA2; 
        PawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnTwoOnB1;
        PawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnTwoOnB2;
        PawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnTwoOnB3;
        PawnTwoOnC1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnTwoOnC1; 
        PawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnTwoOnC2; 
        PawnTwoOnC3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnTwoOnC3; 
        PawnThreeOnA3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnThreeOnA3;
        PawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnThreeOnB2;
        PawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnThreeOnB3;
        PawnThreeOnC1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnThreeOnC1;
        PawnThreeOnC2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnThreeOnC2;
        PawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnThreeOnC3;
        otherPawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnOneOnB1;
        otherPawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnOneOnB2;
        otherPawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnOneOnC1;
        otherPawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnTwoOnB1;
        otherPawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnTwoOnB2;
        otherPawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnTwoOnB3;
        otherPawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnTwoOnC2;
        otherPawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnThreeOnB2;
        otherPawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnThreeOnB3;
        otherPawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnThreeOnC3;
        if(playerTwoTurn)
        {
            if(PawnOneOnA1)
            {
                if((otherPawnOneOnB1 || otherPawnTwoOnB1 || PawnTwoOnB1) && (!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2))
                {
                    pawnOneCantMove = true;
                }
            }
            else if(PawnOneOnB1)
            {
                if(otherPawnOneOnC1 && !otherPawnTwoOnC2)
                {
                    pawnOneCantMove = true;
                }
            }
            else if(PawnOneOnB2)
            {
                if(otherPawnTwoOnC2 && !otherPawnOneOnC1 && !otherPawnThreeOnC3)
                {
                    pawnOneCantMove = true;
                }
            }
            if(PawnTwoOnA2)
            {
                if((otherPawnOneOnB2 || otherPawnTwoOnB2 || otherPawnThreeOnB2 || PawnOneOnB2 || PawnThreeOnB2) && (!otherPawnOneOnB1 && !otherPawnTwoOnB1) && (!otherPawnTwoOnB3 && !otherPawnThreeOnB3))
                {
                    pawnTwoCantMove = true;
                } 
            }
            else if(PawnTwoOnB2)
            {
                if(otherPawnTwoOnC2 && !otherPawnOneOnC1 && !otherPawnThreeOnC3)
                {
                    pawnTwoCantMove = true;
                }
            }
            else if(PawnTwoOnB1)
            {
                if(otherPawnOneOnC1 && !otherPawnTwoOnC2)
                {
                    pawnTwoCantMove = true;
                }
            }
            else if(PawnTwoOnB3)
            {   
                if(otherPawnThreeOnC3 && !otherPawnTwoOnC2)
                {
                    pawnTwoCantMove = true;
                }
            }
            if(PawnThreeOnA3)
            {
               if((otherPawnTwoOnB3 || otherPawnThreeOnB3 || PawnTwoOnB3) && (!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2))
                {
                    pawnThreeCantMove = true;
                }
            }
            else if(PawnThreeOnB3)
            {
                if(otherPawnThreeOnC3 && !otherPawnTwoOnC2)
                {
                    pawnThreeCantMove = true;
                } 
            }
            else if(PawnThreeOnB2)
            {
                if(otherPawnTwoOnC2 && !otherPawnOneOnC1 && !otherPawnThreeOnC3)
                {
                    pawnThreeCantMove = true;
                }
            }  
        }
    }

    void addPhysics2DRaycaster() 
    {
        Physics2DRaycaster physicsRaycaster = GameObject.FindObjectOfType<Physics2DRaycaster>();
        if (physicsRaycaster == null) 
        {
            Camera.main.gameObject.AddComponent<Physics2DRaycaster>();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }
 
    public void OnPointerUp(PointerEventData eventData)
    {
    }

    public void OnPointerClick(PointerEventData eventData)
    {    
    }

    public void selectPlayerPawnOne()
    {
        if(playerTwoTurn)
        {
            pawnOneClicked = true; 
            pawnTwoClicked = false;
            pawnThreeClicked = false;
            pawnHighlight.SetActive(true);
            pawnHighlight.transform.position = playerPawnOne.transform.position;
            squareHighlight.SetActive(false);
            squarePawnHighlight.SetActive(false);
            squarePawnHighlightTwo.SetActive(false);
            if(PawnOneOnA1)
            {
                if(!otherPawnOneOnB1 && !otherPawnTwoOnB1 && !PawnTwoOnB1)
                {
                    squareHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squareHighlight.transform.position = b1.transform.position;   
                }
                if(otherPawnOneOnB2 || otherPawnTwoOnB2 || otherPawnThreeOnB2)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squarePawnHighlight.transform.position = b2.transform.position; 
                }
            }
            else if(PawnOneOnB1)
            {   
                if(!otherPawnOneOnC1)
                {
                    squareHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squareHighlight.transform.position = c1.transform.position;  
                }
                if(otherPawnTwoOnC2)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squarePawnHighlight.transform.position = c2.transform.position; 
                }
            }
            else if(PawnOneOnB2)
            {
                if(!otherPawnTwoOnC2)
                {
                    squareHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squareHighlight.transform.position = c2.transform.position;
                }
                if(otherPawnOneOnC1)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squarePawnHighlight.transform.position = c1.transform.position;
                }
                if(otherPawnThreeOnC3)
                {
                    squarePawnHighlightTwo.SetActive(true);
                    pawnOneCantMove = false;
                    squarePawnHighlightTwo.transform.position = c3.transform.position;
                }
            }
        }
    }


    public void selectPlayerPawnTwo()
    {
        if(playerTwoTurn)
        {
            pawnOneClicked = false; 
            pawnTwoClicked = true;
            pawnThreeClicked = false;
            pawnHighlight.SetActive(true);
            squareHighlight.SetActive(false);
            squarePawnHighlight.SetActive(false);
            squarePawnHighlightTwo.SetActive(false);
            pawnHighlight.transform.position = playerPawnTwo.transform.position;
            if(PawnTwoOnA2)
            {
                if(!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB3 && !PawnOneOnB2 && !PawnThreeOnB2)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = b2.transform.position;
                }
                if(otherPawnOneOnB1 || otherPawnTwoOnB1)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = b1.transform.position;
                }
                if(otherPawnTwoOnB3 || otherPawnThreeOnB3)
                {
                    squarePawnHighlightTwo.SetActive(true);
                    pawnTwoCantMove = false;
                    squarePawnHighlightTwo.transform.position = b3.transform.position;
                }
                
            }
            else if(PawnTwoOnB2)
            {
                if(!otherPawnTwoOnC2)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = c2.transform.position;
                }
                if(otherPawnOneOnC1)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = c1.transform.position;
                }
                if(otherPawnThreeOnC3)
                {
                    squarePawnHighlightTwo.SetActive(true);
                    pawnTwoCantMove = false;
                    squarePawnHighlightTwo.transform.position = c3.transform.position;
                }
                
            }
            else if(PawnTwoOnB1)
            {
                if(!otherPawnOneOnC1)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = c3.transform.position;
                }
                if(otherPawnTwoOnC2)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = c2.transform.position; 
                }
            }
            else if(PawnTwoOnB3)
            {   
                if(!otherPawnThreeOnC3)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = c3.transform.position;
                }
                if(otherPawnTwoOnC2)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = c2.transform.position;
                }
            }
        }
    }

    public void selectPlayerPawnThree()
    {
        if(playerTwoTurn)
        {
            pawnOneClicked = false; 
            pawnTwoClicked = false;
            pawnThreeClicked = true;
            pawnHighlight.SetActive(true);
            squareHighlight.SetActive(false);
            squarePawnHighlight.SetActive(false);
            squarePawnHighlightTwo.SetActive(false);
            pawnHighlight.transform.position = playerPawnThree.transform.position;
            if(PawnThreeOnA3)
            {
                if(!otherPawnTwoOnB3 && !otherPawnThreeOnB3 && !PawnTwoOnB3)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = b3.transform.position;
                }
                if(otherPawnOneOnB2 || otherPawnTwoOnB2 || otherPawnThreeOnB2)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = b2.transform.position;
                }
            }
            else if(PawnThreeOnB3)
            {
                if(!otherPawnThreeOnC3)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = c3.transform.position;
                }
                if(otherPawnTwoOnC2)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = c2.transform.position;
                }
            }
            else if(PawnThreeOnB2)
            {
                if(!otherPawnTwoOnC2)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = c2.transform.position;
                }
                if(otherPawnOneOnC1)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = c1.transform.position;
                }
                if(otherPawnThreeOnC3)
                {
                    squarePawnHighlightTwo.SetActive(true);
                    pawnThreeCantMove = false;
                    squarePawnHighlightTwo.transform.position = c3.transform.position;
                }
            }
        }
    }

    public void TakeOpponentPawnOne()
    {
        if(playerTwoTurn)
        {
            if(pawnOneClicked)
            {
                if(PawnOneOnA1)
                {
                    if(otherPawnOneOnB2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnOne.transform.position = opponentPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnOneOnB2)
                {
                    if(otherPawnOneOnC1)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnOne.transform.position = opponentPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    } 
                }
            }
            if(pawnTwoClicked)
            {
                if(PawnTwoOnA2)
                {
                    if(otherPawnOneOnB1)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnTwo.transform.position = opponentPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnTwoOnB2)
                {
                    if(otherPawnOneOnC1)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnTwo.transform.position = opponentPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    } 
                }
            }
            if(pawnThreeClicked)
            {
                if(PawnThreeOnA3)
                {
                    if(otherPawnOneOnB2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnThree.transform.position = opponentPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnThreeOnB2)
                {
                    if(otherPawnOneOnC1)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnThree.transform.position = opponentPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    } 
                }
            }
        }
    }
    public void TakeOpponentPawnTwo()
    {
        if(playerTwoTurn)
        {
            if(pawnOneClicked)
            {
            if(PawnOneOnA1)
                {
                    if(otherPawnTwoOnB2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnOne.transform.position = opponentPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnOneOnB1)
                {
                    if(otherPawnTwoOnC2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnOne.transform.position = opponentPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    } 
                }
            }   
            if(pawnTwoClicked)
            {
                if(PawnTwoOnA2)
                {
                    if(otherPawnTwoOnB1)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnTwo.transform.position = opponentPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnTwoOnB3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnTwo.transform.position = opponentPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnTwoOnB1)
                {
                    if(otherPawnTwoOnC2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnTwo.transform.position = opponentPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    } 
                }
                else if(PawnTwoOnB3)
                {
                    if(otherPawnTwoOnC2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnTwo.transform.position = opponentPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    } 
                }
            }
            if(pawnThreeClicked)
            {
                if(PawnThreeOnA3)
                {
                    if(otherPawnTwoOnB2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnThree.transform.position = opponentPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnThreeOnB3)
                {
                    if(otherPawnTwoOnC2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnThree.transform.position = opponentPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    } 
                }
            }
        }
    }
    public void TakeOpponentPawnThree()
    {
        if(playerTwoTurn)
        {
            if(pawnOneClicked)
            {
                if(PawnOneOnA1)
                {
                    if(otherPawnThreeOnB2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnOne.transform.position = opponentPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnOneOnB2)
                {
                    if(otherPawnThreeOnC3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnOne.transform.position = opponentPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    } 
                }
            }
            if(pawnTwoClicked)
            {
                if(PawnTwoOnA2)
                {
                    if(otherPawnThreeOnB3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnTwo.transform.position = opponentPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnTwoOnB2)
                {
                    if(otherPawnThreeOnC3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnTwo.transform.position = opponentPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    } 
                }
            }
            if(pawnThreeClicked)
            {
                if(PawnThreeOnA3)
                {
                    if(otherPawnThreeOnB2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnThree.transform.position = opponentPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnThreeOnB2)
                {
                    if(otherPawnThreeOnC3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerPawnThree.transform.position = opponentPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    } 
                }
            }
        }
    }

    public void clickOnB1()
    {
        if(playerTwoTurn)
        {
            if(PawnOneOnA1 && pawnOneClicked == true)
            {
                if(!otherPawnOneOnB1 && !otherPawnTwoOnB1)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerPawnOne.transform.position = b1.transform.position;
                    pawnOneClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
        }
    }
    public void clickOnB2()
    {
        if(playerTwoTurn)
        {
            if(PawnTwoOnA2 && pawnTwoClicked == true)
            {
                if(!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerPawnTwo.transform.position = b2.transform.position;
                    pawnTwoClicked = false;
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns(); 
                }
            }
        }
    }
    public void clickOnB3()
    {
        if(playerTwoTurn)
        {
            if(PawnThreeOnA3 && pawnThreeClicked == true)
            {
                if(!otherPawnTwoOnB3 && !otherPawnThreeOnB3)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerPawnThree.transform.position = b3.transform.position;
                    pawnThreeClicked = false;
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
        }
    }
    public void clickOnC1()
    {
        if(playerTwoTurn)
        {
            if(PawnOneOnB1 && pawnOneClicked == true)
            {
                if(!otherPawnOneOnC1)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerPawnOne.transform.position = c1.transform.position;
                    pawnOneClicked = false;
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            if(PawnTwoOnB1 && pawnTwoClicked == true)
            {
                if(!otherPawnOneOnC1)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerPawnTwo.transform.position = c1.transform.position;
                    pawnTwoClicked = false;
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
        }
    }
    public void clickOnC2()
    {
        if(playerTwoTurn)
        {
            if(PawnOneOnB2 && pawnOneClicked == true)
            {
                if(!otherPawnTwoOnC2)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerPawnOne.transform.position = c2.transform.position;
                    pawnOneClicked = false;
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            if(PawnTwoOnB2 && pawnTwoClicked == true)
            {
                if(!otherPawnTwoOnC2)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerPawnTwo.transform.position = c2.transform.position;
                    pawnTwoClicked = false;
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            } 
            if(PawnThreeOnB2 && pawnThreeClicked == true)
            {
                if(!otherPawnTwoOnC2)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerPawnThree.transform.position = c2.transform.position;
                    pawnThreeClicked = false;
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }   
        }
    }
    public void clickOnC3()
    {
        if(playerTwoTurn)
        {
            if(PawnTwoOnB3 && pawnTwoClicked == true)
            {
                if(!otherPawnThreeOnC3)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerPawnTwo.transform.position = c3.transform.position;
                    pawnTwoClicked = false;
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            if(PawnThreeOnB3 && pawnThreeClicked == true)
            {
                if(!otherPawnThreeOnC3)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerPawnThree.transform.position = c3.transform.position;
                    pawnThreeClicked = false;
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
        }
    }

    void swapTurns()
    {
        playerTwoTurn = false;
        playerOneMoveScript.playerOneTurn = true;
    }
}
