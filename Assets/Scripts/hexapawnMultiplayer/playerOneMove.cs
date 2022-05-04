using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerOneMove : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
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
    public playerTwoMove playerTwoMoveScript;
    bool pawnOneClicked;
    bool pawnTwoClicked;
    bool pawnThreeClicked;
    bool PawnOneOnA1;
    bool PawnOneOnA2;
    bool PawnOneOnA3;
    bool PawnOneOnB1;
    bool PawnOneOnB2;
    bool PawnOneOnC1;
    bool PawnTwoOnA1;
    bool PawnTwoOnA2;
    bool PawnTwoOnA3;
    bool PawnTwoOnB1;
    bool PawnTwoOnB2;
    bool PawnTwoOnB3;
    bool PawnTwoOnC2; 
    bool PawnThreeOnA1;
    bool PawnThreeOnA2;
    bool PawnThreeOnA3;
    bool PawnThreeOnB2;
    bool PawnThreeOnB3;
    bool PawnThreeOnC3;
    bool otherPawnOneOnA1;
    bool otherPawnOneOnB1;
    bool otherPawnOneOnB2;
    bool otherPawnTwoOnA2;
    bool otherPawnTwoOnB1;
    bool otherPawnTwoOnB2;
    bool otherPawnTwoOnB3; 
    bool otherPawnThreeOnA3;
    bool otherPawnThreeOnB2;
    bool otherPawnThreeOnB3;
    public bool playerOneTurn;
    public int playerTwoPawnNumber;
    public bool pawnOneCantMove;
    public bool pawnTwoCantMove;
    public bool pawnThreeCantMove;
    // Start is called before the first frame update
    void Start()
    {
        playerTwoMoveScript = GameObject.FindWithTag("GameController").GetComponent<playerTwoMove>();
        addPhysics2DRaycaster();
        playerPawnOne = GameObject.FindWithTag("Player-1");
        playerPawnTwo = GameObject.FindWithTag("Player-2");
        playerPawnThree = GameObject.FindWithTag("Player-3");
        opponentPawnOne = GameObject.FindWithTag("player-2-pawn-1");
        opponentPawnTwo = GameObject.FindWithTag("player-2-pawn-2");
        opponentPawnThree = GameObject.FindWithTag("player-2-pawn-3");
        pawnHighlight = GameObject.FindWithTag("pawn-Highlight");
        squareHighlight = GameObject.FindWithTag("square-Highlight");
        squarePawnHighlight = GameObject.FindWithTag("Square-Pawn-Highlight");
        squarePawnHighlightTwo = GameObject.FindWithTag("Square-Pawn-Two-Highlight");
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
        playerOneTurn = true;
        playerTwoPawnNumber = 3;
        pawnOneCantMove = false;
        pawnTwoCantMove = false;
        pawnThreeCantMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        PawnOneOnA1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnOneOnA1;
        PawnOneOnA2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnOneOnA2;
        PawnOneOnA3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnOneOnA3;
        PawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnOneOnB1;
        PawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnOneOnB2;
        PawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnOneOnC1;
        PawnTwoOnA1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnTwoOnA1; 
        PawnTwoOnA2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnTwoOnA2; 
        PawnTwoOnA3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnTwoOnA3; 
        PawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnTwoOnB1;
        PawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnTwoOnB2;
        PawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnTwoOnB3; 
        PawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnTwoOnC2; 
        PawnThreeOnA1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnThreeOnA1;
        PawnThreeOnA2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnThreeOnA2;
        PawnThreeOnA3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnThreeOnA3;
        PawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnThreeOnB2;
        PawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnThreeOnB3;
        PawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerOnePawnThreeOnC3;
        otherPawnOneOnA1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnOneOnA1;
        otherPawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnOneOnB1;
        otherPawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnOneOnB2;
        otherPawnTwoOnA2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnTwoOnA2;
        otherPawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnTwoOnB1;
        otherPawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnTwoOnB2;
        otherPawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnTwoOnB3; 
        otherPawnThreeOnA3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnThreeOnA3;
        otherPawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnThreeOnB2;
        otherPawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerBoardState>().playerTwoPawnThreeOnB3;
        if(playerOneTurn)
        {
            if(PawnOneOnC1)
            {
                if((otherPawnOneOnB1 || otherPawnTwoOnB1 || PawnTwoOnB1) && (!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2))
                {
                    pawnOneCantMove = true;
                }
            }
            else if(PawnOneOnB1)
            {
                if(otherPawnOneOnA1 && !otherPawnTwoOnA2)
                {
                    pawnOneCantMove = true;
                }
            }
            else if(PawnOneOnB2)
            {
                if(otherPawnTwoOnA2 && !otherPawnOneOnA1 && !otherPawnThreeOnA3)
                {
                    pawnOneCantMove = true;
                }
            }
            if(PawnTwoOnC2)
            {
                if((otherPawnOneOnB2 || otherPawnTwoOnB2 || otherPawnThreeOnB2 || PawnOneOnB2 || PawnThreeOnB2) && (!otherPawnOneOnB1 && !otherPawnTwoOnB1) && (!otherPawnTwoOnB3 && !otherPawnThreeOnB3))
                {
                    pawnTwoCantMove = true;
                } 
            }
            else if(PawnTwoOnB2)
            {
                if(otherPawnTwoOnA2 && !otherPawnOneOnA1 && !otherPawnThreeOnA3)
                {
                    pawnTwoCantMove = true;
                }
            }
            else if(PawnTwoOnB1)
            {
                if(otherPawnOneOnA1 && !otherPawnTwoOnA2)
                {
                    pawnTwoCantMove = true;
                }
            }
            else if(PawnTwoOnB3)
            {   
                if(otherPawnThreeOnA3 && !otherPawnTwoOnA2)
                {
                    pawnTwoCantMove = true;
                }
            }
            if(PawnThreeOnC3)
            {
               if((otherPawnTwoOnB3 || otherPawnThreeOnB3 || PawnTwoOnB3) && (!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2))
                {
                    pawnThreeCantMove = true;
                }
            }
            else if(PawnThreeOnB3)
            {
                if(otherPawnThreeOnA3 && !otherPawnTwoOnA2)
                {
                    pawnThreeCantMove = true;
                } 
            }
            else if(PawnThreeOnB2)
            {
                if(otherPawnTwoOnA2 && !otherPawnOneOnA1 && !otherPawnThreeOnA3)
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
        if(playerOneTurn)
        {
            pawnOneClicked = true; 
            pawnTwoClicked = false;
            pawnThreeClicked = false;
            pawnHighlight.SetActive(true);
            pawnHighlight.transform.position = playerPawnOne.transform.position;
            squareHighlight.SetActive(false);
            squarePawnHighlight.SetActive(false);
            squarePawnHighlightTwo.SetActive(false);
            if(PawnOneOnC1)
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
                if(!otherPawnOneOnA1)
                {
                    squareHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squareHighlight.transform.position = a1.transform.position;  
                }
                if(otherPawnTwoOnA2)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squarePawnHighlight.transform.position = a2.transform.position; 
                }
            }
            else if(PawnOneOnB2)
            {
                if(!otherPawnTwoOnA2)
                {
                    squareHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squareHighlight.transform.position = a2.transform.position;
                }
                if(otherPawnOneOnA1)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squarePawnHighlight.transform.position = a1.transform.position;
                }
                if(otherPawnThreeOnA3)
                {
                    squarePawnHighlightTwo.SetActive(true);
                    pawnOneCantMove = false;
                    squarePawnHighlightTwo.transform.position = a3.transform.position;
                }
            }
        }
    }


    public void selectPlayerPawnTwo()
    {
        if(playerOneTurn)
        {
            pawnOneClicked = false; 
            pawnTwoClicked = true;
            pawnThreeClicked = false;
            pawnHighlight.SetActive(true);
            squareHighlight.SetActive(false);
            squarePawnHighlight.SetActive(false);
            squarePawnHighlightTwo.SetActive(false);
            pawnHighlight.transform.position = playerPawnTwo.transform.position;
            if(PawnTwoOnC2)
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
                if(!otherPawnTwoOnA2)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = a2.transform.position;
                }
                if(otherPawnOneOnA1)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = a1.transform.position;
                }
                if(otherPawnThreeOnA3)
                {
                    squarePawnHighlightTwo.SetActive(true);
                    pawnTwoCantMove = false;
                    squarePawnHighlightTwo.transform.position = a3.transform.position;
                }
                
            }
            else if(PawnTwoOnB1)
            {
                if(!otherPawnOneOnA1)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = a3.transform.position;
                }
                if(otherPawnTwoOnA2)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = a2.transform.position; 
                }
            }
            else if(PawnTwoOnB3)
            {   
                if(!otherPawnThreeOnA3)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = a3.transform.position;
                }
                if(otherPawnTwoOnA2)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = a2.transform.position;
                }
            }
        }
    }

    public void selectPlayerPawnThree()
    {
        if(playerOneTurn)
        {
            pawnOneClicked = false; 
            pawnTwoClicked = false;
            pawnThreeClicked = true;
            pawnHighlight.SetActive(true);
            squareHighlight.SetActive(false);
            squarePawnHighlight.SetActive(false);
            squarePawnHighlightTwo.SetActive(false);
            pawnHighlight.transform.position = playerPawnThree.transform.position;
            if(PawnThreeOnC3)
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
                if(!otherPawnThreeOnA3)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = a3.transform.position;
                }
                if(otherPawnTwoOnA2)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = a2.transform.position;
                }
            }
            else if(PawnThreeOnB2)
            {
                if(!otherPawnTwoOnA2)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = a2.transform.position;
                }
                if(otherPawnOneOnA1)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = a1.transform.position;
                }
                if(otherPawnThreeOnA3)
                {
                    squarePawnHighlightTwo.SetActive(true);
                    pawnThreeCantMove = false;
                    squarePawnHighlightTwo.transform.position = a3.transform.position;
                }
            }
        }
    }

    public void TakeOpponentPawnOne()
    {
        if(playerOneTurn)
        {
            if(pawnOneClicked)
            {
                if(PawnOneOnC1)
                {
                    if(otherPawnOneOnB2)
                    {
                        playerPawnOne.transform.position = opponentPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnOneOnB2)
                {
                    if(otherPawnOneOnA1)
                    {
                        playerPawnOne.transform.position = opponentPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    } 
                }
            }
            if(pawnTwoClicked)
            {
                if(PawnTwoOnC2)
                {
                    if(otherPawnOneOnB1)
                    {
                        playerPawnTwo.transform.position = opponentPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnTwoOnB2)
                {
                    if(otherPawnOneOnA1)
                    {
                        playerPawnTwo.transform.position = opponentPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    } 
                }
            }
            if(pawnThreeClicked)
            {
                if(PawnThreeOnC3)
                {
                    if(otherPawnOneOnB2)
                    {
                        playerPawnThree.transform.position = opponentPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnThreeOnB2)
                {
                    if(otherPawnOneOnA1)
                    {
                        playerPawnThree.transform.position = opponentPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    } 
                }
            }
        }
    }
    public void TakeOpponentPawnTwo()
    {
        if(playerOneTurn)
        {
            if(pawnOneClicked)
            {
            if(PawnOneOnC1)
                {
                    if(otherPawnTwoOnB2)
                    {
                        playerPawnOne.transform.position = opponentPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnOneOnB1)
                {
                    if(otherPawnTwoOnA2)
                    {
                        playerPawnOne.transform.position = opponentPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    } 
                }
            }   
            if(pawnTwoClicked)
            {
                if(PawnTwoOnC2)
                {
                    if(otherPawnTwoOnB1)
                    {
                        playerPawnTwo.transform.position = opponentPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnTwoOnB3)
                    {
                        playerPawnTwo.transform.position = opponentPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnTwoOnB1)
                {
                    if(otherPawnTwoOnA2)
                    {
                        playerPawnTwo.transform.position = opponentPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    } 
                }
                else if(PawnTwoOnB3)
                {
                    if(otherPawnTwoOnA2)
                    {
                        playerPawnTwo.transform.position = opponentPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    } 
                }
            }
            if(pawnThreeClicked)
            {
                if(PawnThreeOnC3)
                {
                    if(otherPawnTwoOnB2)
                    {
                        playerPawnThree.transform.position = opponentPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnThreeOnB3)
                {
                    if(otherPawnTwoOnA2)
                    {
                        playerPawnThree.transform.position = opponentPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    } 
                }
            }
        }
    }
    public void TakeOpponentPawnThree()
    {
        if(playerOneTurn)
        {
            if(pawnOneClicked)
            {
                if(PawnOneOnC1)
                {
                    if(otherPawnThreeOnB2)
                    {
                        playerPawnOne.transform.position = opponentPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnOneOnB2)
                {
                    if(otherPawnThreeOnA3)
                    {
                        playerPawnOne.transform.position = opponentPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    } 
                }
            }
            if(pawnTwoClicked)
            {
                if(PawnTwoOnC2)
                {
                    if(otherPawnThreeOnB3)
                    {
                        playerPawnTwo.transform.position = opponentPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnTwoOnB2)
                {
                    if(otherPawnThreeOnA3)
                    {
                        playerPawnTwo.transform.position = opponentPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    } 
                }
            }
            if(pawnThreeClicked)
            {
                if(PawnThreeOnC3)
                {
                    if(otherPawnThreeOnB2)
                    {
                        playerPawnThree.transform.position = opponentPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnThreeOnB2)
                {
                    if(otherPawnThreeOnA3)
                    {
                        playerPawnThree.transform.position = opponentPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        opponentPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    } 
                }
            }
        }
    }

    public void clickOnA1()
    {
        if(playerOneTurn)
        {
            if(PawnOneOnB1 && pawnOneClicked == true)
            {
                if(!otherPawnOneOnA1)
                {
                    playerPawnOne.transform.position = a1.transform.position;
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
                if(!otherPawnOneOnA1)
                {
                    playerPawnTwo.transform.position = a1.transform.position;
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
    public void clickOnA2()
    {
        if(playerOneTurn)
        {
            if(PawnOneOnB2 && pawnOneClicked == true)
            {
                if(!otherPawnTwoOnA2)
                {
                    playerPawnOne.transform.position = a2.transform.position;
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
                if(!otherPawnTwoOnA2)
                {
                    playerPawnTwo.transform.position = a2.transform.position;
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
                if(!otherPawnTwoOnA2)
                {
                    playerPawnThree.transform.position = a2.transform.position;
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
    public void clickOnA3()
    {
        if(playerOneTurn)
        {
            if(PawnTwoOnB3 && pawnTwoClicked == true)
            {
                if(!otherPawnThreeOnA3)
                {
                    playerPawnTwo.transform.position = a3.transform.position;
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
                if(!otherPawnThreeOnA3)
                {
                    playerPawnThree.transform.position = a3.transform.position;
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
    public void clickOnB1()
    {
        if(playerOneTurn)
        {
            if(PawnOneOnC1 && pawnOneClicked == true)
            {
                if(!otherPawnOneOnB1 && !otherPawnTwoOnB1)
                {
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
        if(playerOneTurn)
        {
            if(PawnTwoOnC2 && pawnTwoClicked == true)
            {
                if(!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2)
                {
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
        if(playerOneTurn)
        {
            if(PawnThreeOnC3 && pawnThreeClicked == true)
            {
                if(!otherPawnTwoOnB3 && !otherPawnThreeOnB3)
                {
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

    void swapTurns()
    {
        playerOneTurn = false;
        playerTwoMoveScript.playerTwoTurn = true;
    }
}
