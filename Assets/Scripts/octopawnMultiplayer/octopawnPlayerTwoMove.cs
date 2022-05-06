using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class octopawnPlayerTwoMove : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
    public GameObject playerTwoPawnOne;
    public GameObject playerTwoPawnTwo;
    public GameObject playerTwoPawnThree;
    public GameObject playerTwoPawnFour;
    public GameObject playerOnePawnOne;
    public GameObject playerOnePawnTwo;
    public GameObject playerOnePawnThree;
    public GameObject playerOnePawnFour;
    public GameObject pawnHighlight;
    public GameObject squareHighlight;
    public GameObject squarePawnHighlight;
    public GameObject squarePawnHighlightTwo;
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
    public octopawnPlayerOneMove playerOneScript;
    bool pawnOneClicked;
    bool pawnTwoClicked;
    bool pawnThreeClicked;
    bool pawnFourClicked;
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
    public bool playerTwoTurn;
    public int playerOnePawnNumber;
    public bool pawnOneCantMove;
    public bool pawnTwoCantMove;
    public bool pawnThreeCantMove;
    public bool pawnFourCantMove;
    // Start is called before the first frame update
    void Start()
    {
        playerOneScript = GameObject.FindWithTag("GameController").GetComponent<octopawnPlayerOneMove>();
        addPhysics2DRaycaster();
        playerTwoPawnOne = GameObject.FindWithTag("player-2-pawn-1");
        playerTwoPawnTwo = GameObject.FindWithTag("player-2-pawn-2");
        playerTwoPawnThree = GameObject.FindWithTag("player-2-pawn-3");
        playerTwoPawnFour = GameObject.FindWithTag("player-2-pawn-4");
        playerOnePawnOne = GameObject.FindWithTag("Player-1");
        playerOnePawnTwo = GameObject.FindWithTag("Player-2");
        playerOnePawnThree = GameObject.FindWithTag("Player-3");
        playerOnePawnFour = GameObject.FindWithTag("Player-4");
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
        pawnOneClicked = false;
        pawnTwoClicked = false;
        pawnThreeClicked = false;
        pawnFourClicked = false;
        playerTwoTurn = true;
        playerOnePawnNumber = 4;
        pawnOneCantMove = false;
        pawnTwoCantMove = false;
        pawnThreeCantMove = false;
        pawnFourCantMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        PawnOneOnA1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnOneOnA1;
        PawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnOneOnB1;
        PawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnOneOnB2;
        PawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnOneOnC1;
        PawnOneOnC2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnOneOnC2;
        PawnOneOnC3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnOneOnC3; 
        PawnOneOnD1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnOneOnD1;
        PawnOneOnD2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnOneOnD2;
        PawnOneOnD3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnOneOnD3; 
        PawnOneOnD4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnOneOnD4; 
        PawnTwoOnA2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnA2; 
        PawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnB1;
        PawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnB2;
        PawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnB3;
        PawnTwoOnC1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnC1; 
        PawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnC2; 
        PawnTwoOnC3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnC3; 
        PawnTwoOnC4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnC4;
        PawnTwoOnD1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnD1;
        PawnTwoOnD2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnD2;
        PawnTwoOnD3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnD3; 
        PawnTwoOnD4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnD4;  
        PawnThreeOnA3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnA3;
        PawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnB2;
        PawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnB3;
        PawnThreeOnB4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnB4;
        PawnThreeOnC1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnC1;
        PawnThreeOnC2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnC2;
        PawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnC3;
        PawnThreeOnC4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnC4;
        PawnThreeOnD1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnD1;
        PawnThreeOnD2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnD2;
        PawnThreeOnD3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnD3;
        PawnThreeOnD4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnD4;
        PawnFourOnA4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnFourOnA4;
        PawnFourOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnFourOnB3;
        PawnFourOnB4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnFourOnB4;
        PawnFourOnC2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnFourOnC2;
        PawnFourOnC3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnFourOnC3;
        PawnFourOnC4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnFourOnC4;
        PawnFourOnD1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnFourOnD1;
        PawnFourOnD2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnFourOnD2;
        PawnFourOnD3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnFourOnD3;
        PawnFourOnD4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnFourOnD4;
        otherPawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnOneOnB1;
        otherPawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnOneOnB2;
        otherPawnOneOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnOneOnB3;
        otherPawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnOneOnC1;
        otherPawnOneOnC2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnOneOnC2;
        otherPawnOneOnD1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnOneOnD1;
        otherPawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnB1;
        otherPawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnB2;
        otherPawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnB3;
        otherPawnTwoOnB4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnB4;
        otherPawnTwoOnC1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnC1;
        otherPawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnC2;
        otherPawnTwoOnC3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnC3;
        otherPawnTwoOnD2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnD2;
        otherPawnThreeOnB1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnB1;
        otherPawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnB2;
        otherPawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnB3;
        otherPawnThreeOnB4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnB4;
        otherPawnThreeOnC2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnC2;
        otherPawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnC3;
        otherPawnThreeOnC4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnC4;
        otherPawnThreeOnD3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnD3;
        otherPawnFourOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnFourOnB2;
        otherPawnFourOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnFourOnB3;
        otherPawnFourOnB4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnFourOnB4;
        otherPawnFourOnC3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnFourOnC3;
        otherPawnFourOnC4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnFourOnC4;
        otherPawnFourOnD4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnFourOnD4;
        if(playerTwoTurn)
        {
            //Pawn one invalid move check
            if(PawnOneOnA1)
            {
                if((otherPawnOneOnB1 || otherPawnTwoOnB1 || otherPawnThreeOnB1) && (!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2 && !otherPawnFourOnB2))
                {
                    pawnOneCantMove = true;
                }
            }
            else if(PawnOneOnB1)
            {
                if((otherPawnOneOnC1 || otherPawnTwoOnC1) && (!otherPawnOneOnC2 && !otherPawnTwoOnC2 && !otherPawnThreeOnC2))
                {
                    pawnOneCantMove = true;
                }
            }
            else if(PawnOneOnB2)
            {
                if((otherPawnOneOnC2 || otherPawnTwoOnC2 || otherPawnThreeOnC2) && (!otherPawnOneOnC1 && !otherPawnTwoOnC2) && (!otherPawnTwoOnC3 && !otherPawnThreeOnC3 && !otherPawnFourOnC3))
                {
                    pawnOneCantMove = true;
                }

            }
            else if(PawnOneOnC1)
            {
                if(otherPawnOneOnD1 && !otherPawnTwoOnD2)
                {
                    pawnOneCantMove = true;
                }
            }
            else if(PawnOneOnC2)
            {
                if(otherPawnTwoOnD2 && !otherPawnOneOnD1 && !otherPawnThreeOnD3)
                {
                    pawnOneCantMove = true;
                }
            }
            else if(PawnOneOnC3)
            {
                if(otherPawnThreeOnD3 && !otherPawnTwoOnD2 && !otherPawnFourOnD4)
                {
                    pawnOneCantMove = true;
                }
            }

            //Pawn two invalid move check
            if(PawnTwoOnA2)
            {
                if((otherPawnOneOnB2 || otherPawnTwoOnB2 || otherPawnThreeOnB2 || otherPawnThreeOnB2 || otherPawnFourOnB2)
                    && (!otherPawnOneOnB1 && !otherPawnTwoOnB1 && !otherPawnThreeOnB1) 
                    && (!otherPawnOneOnB3 && !otherPawnTwoOnB3 && !otherPawnThreeOnB3 && !otherPawnFourOnB3))
                {
                    pawnTwoCantMove = true;
                }
            }
            else if(PawnTwoOnB1)
            {
                if((otherPawnOneOnC1 || otherPawnTwoOnC1) && (!otherPawnOneOnC2 && !otherPawnTwoOnC2 && !otherPawnThreeOnC2))
                {
                    pawnTwoCantMove = true;
                }
            }
            else if(PawnTwoOnB2)
            {
                if((otherPawnOneOnC2 || otherPawnTwoOnC2 || otherPawnThreeOnC2) && (!otherPawnOneOnC1 && !otherPawnTwoOnC1)
                    && (!otherPawnTwoOnC3 && !otherPawnThreeOnC3 && !otherPawnFourOnC3))
                {
                    pawnTwoCantMove = true;
                }
            }
            else if(PawnTwoOnB3)
            {
                if((otherPawnTwoOnC3 || otherPawnThreeOnC3 || otherPawnFourOnC3)
                && (!otherPawnOneOnC2 && !otherPawnTwoOnC2 && !otherPawnThreeOnC2)
                && (!otherPawnThreeOnC4 && !otherPawnFourOnC4))
                {
                    pawnTwoCantMove = true;
                }
            }
            else if(PawnTwoOnC1)
            {
                if(otherPawnOneOnD1 && !otherPawnTwoOnD2)
                {
                    pawnTwoCantMove = true;
                }
            }
            else if(PawnTwoOnC2)
            {
                if(otherPawnTwoOnD2 && !otherPawnOneOnD1 && !otherPawnThreeOnD3)
                {
                    pawnTwoCantMove = true;
                }
            }
            else if(PawnTwoOnC3)
            {
                if(otherPawnThreeOnD3 && !otherPawnTwoOnD2 && !otherPawnFourOnD4)
                {
                    pawnTwoCantMove = true;
                }
            }
            else if(PawnTwoOnC4)
            {
                if(otherPawnFourOnD4 && !otherPawnThreeOnD3)
                {
                    pawnTwoCantMove = true;
                }
            }

            //Pawn three invalid move check
            if(PawnThreeOnA3)
            {
                if((otherPawnOneOnB3 || otherPawnTwoOnB3 || otherPawnThreeOnB3 || otherPawnFourOnB3)
                && (!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2 && !otherPawnFourOnB2)
                && (!otherPawnThreeOnB4 && !otherPawnFourOnB4))
                {
                    pawnThreeCantMove = true;
                }
            }
            else if(PawnThreeOnB2)
            {
                if((otherPawnOneOnC2 || otherPawnTwoOnC2  || otherPawnThreeOnC2)
                && (!otherPawnOneOnC1 && !otherPawnTwoOnC1)
                && (!otherPawnThreeOnC3 && !otherPawnFourOnC3))
                {
                    pawnThreeCantMove = true;
                }
            }
            else if(PawnThreeOnB3)
            {
                if((otherPawnTwoOnC3 || otherPawnThreeOnC3 || otherPawnFourOnC3)
                && (!otherPawnOneOnC2 && !otherPawnTwoOnC2 && !otherPawnThreeOnC2)
                && (!otherPawnThreeOnC4 && !otherPawnFourOnC4))
                {
                    pawnThreeCantMove = true;
                }
            }
            else if(PawnThreeOnB4)
            {
                if((otherPawnThreeOnC4 || otherPawnFourOnC4) && (!otherPawnThreeOnC3 && !otherPawnFourOnC3))
                {
                    pawnThreeCantMove = true;
                }
            }
            else if(PawnThreeOnC1)
            {
                if(otherPawnOneOnD1 && !otherPawnTwoOnD2)
                {
                    pawnThreeCantMove = true;
                }
            }
            else if(PawnThreeOnC2)
            {
                if(otherPawnTwoOnD2 && !otherPawnOneOnD1 && !otherPawnThreeOnD3)
                {
                    pawnThreeCantMove = true;
                }
            }
            else if(PawnThreeOnC3)
            {
                if(otherPawnThreeOnD3 && !otherPawnTwoOnD2 && !otherPawnFourOnD4)
                {
                    pawnThreeCantMove = true;
                }
            }
            else if(PawnThreeOnC4)
            {
                if(otherPawnFourOnD4 && !otherPawnThreeOnD3)
                {
                    pawnThreeCantMove = true;
                }
            }

            //Pawn four invalid move check
            if(PawnFourOnA4)
            {
                if((otherPawnTwoOnB4 || otherPawnThreeOnB4 || otherPawnFourOnB4)
                && (!otherPawnOneOnB3 && !otherPawnTwoOnB3 && !otherPawnThreeOnB3 && !otherPawnFourOnB3))
                {
                    pawnFourCantMove = true;
                }
            }
            else if(PawnFourOnB3)
            {
                if((otherPawnTwoOnC3 || otherPawnThreeOnC3 || otherPawnFourOnC3)
                && (!otherPawnOneOnC2 && !otherPawnTwoOnC2)
                && (!otherPawnThreeOnC4 && !otherPawnFourOnC4))
                {
                    pawnFourCantMove = true;
                }
            }
            else if(PawnFourOnB4)
            {
                if((otherPawnThreeOnC4 || otherPawnFourOnC4)
                && (!otherPawnTwoOnC3 && !otherPawnThreeOnC3 && !otherPawnFourOnC3))
                {
                    pawnFourCantMove = true;
                }
            }
            else if(PawnFourOnC2)
            {
                if(otherPawnTwoOnD2 && !otherPawnOneOnD1 && !otherPawnThreeOnD3)
                {
                    pawnFourCantMove = true;
                }
            }
            else if(PawnFourOnC3)
            {
                if(otherPawnThreeOnD3 && !otherPawnTwoOnD2 && !otherPawnFourOnD4)
                {
                    pawnFourCantMove = true;
                }
            }
            else if(PawnFourOnC4)
            {
                if(otherPawnFourOnD4 && !otherPawnThreeOnD3)
                {
                    pawnFourCantMove = true;
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

    public void selectplayerTwoPawnOne()
    {
        if(playerTwoTurn)
        {
            pawnOneClicked = true; 
            pawnTwoClicked = false;
            pawnThreeClicked = false;
            pawnFourClicked = false;
            pawnHighlight.SetActive(true);
            pawnHighlight.transform.position = playerTwoPawnOne.transform.position;
            squareHighlight.SetActive(false);
            squarePawnHighlight.SetActive(false);
            squarePawnHighlightTwo.SetActive(false);
            if(PawnOneOnA1)
            {
                if(otherPawnOneOnB2 || otherPawnTwoOnB2 || otherPawnThreeOnB2 || otherPawnFourOnB2)
                { 
                    squarePawnHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squarePawnHighlight.transform.position = b2.transform.position;
                }
                if(!otherPawnOneOnB1 && !otherPawnTwoOnB1 && !otherPawnThreeOnB1 && !PawnTwoOnB1)
                {
                    squareHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squareHighlight.transform.position = b1.transform.position;
                }
            }
            else if(PawnOneOnB1)
            {
                if(otherPawnOneOnC2 || otherPawnTwoOnC2 || otherPawnThreeOnC2)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squarePawnHighlight.transform.position = c2.transform.position;
                }
                if(!otherPawnOneOnC1 && !otherPawnTwoOnC1 && !PawnTwoOnC1 && !PawnThreeOnC1)
                {
                    squareHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squareHighlight.transform.position = c1.transform.position;
                }
            }
            else if(PawnOneOnB2)
            {
                if(otherPawnOneOnC1 || otherPawnTwoOnC1)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squarePawnHighlight.transform.position = c1.transform.position;
                }
                if(otherPawnTwoOnC3 || otherPawnThreeOnC3 || otherPawnFourOnC3)
                {
                    squarePawnHighlightTwo.SetActive(true);
                    pawnOneCantMove = false;
                    squarePawnHighlightTwo.transform.position = c3.transform.position;
                }
                if(!otherPawnOneOnC2 && !otherPawnTwoOnC2 && !otherPawnThreeOnC2 && !PawnTwoOnC2 && !PawnThreeOnC2 && !PawnFourOnC2)
                {
                    squareHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squareHighlight.transform.position = c2.transform.position;
                }
            }
            else if(PawnOneOnC1)
            {   
                if(otherPawnTwoOnD2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnOneCantMove = false;
                    squarePawnHighlight.transform.position = d2.transform.position;
                }
                if(!otherPawnOneOnD1)
                {
                    squareHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squareHighlight.transform.position = d1.transform.position;
                }
            }
            else if(PawnOneOnC2)
            {
                if(otherPawnOneOnD1)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnOneCantMove = false;
                    squarePawnHighlight.transform.position = d1.transform.position;
                }
                if(otherPawnThreeOnD3)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnOneCantMove = false;
                    squarePawnHighlightTwo.transform.position = d3.transform.position;
                }
                if(!otherPawnTwoOnD2)
                {
                    squareHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squareHighlight.transform.position = d2.transform.position;
                }
            }
            else if(PawnOneOnC3)
            {
                if(otherPawnTwoOnD2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnOneCantMove = false;
                    squarePawnHighlight.transform.position = d2.transform.position;
                }
                if(otherPawnFourOnD4)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnOneCantMove = false;
                    squarePawnHighlightTwo.transform.position = d4.transform.position;
                }
                if(!otherPawnThreeOnD3)
                {
                    squareHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squareHighlight.transform.position = d3.transform.position;
                }
            }
        }
    }


    public void selectplayerTwoPawnTwo()
    {
        if(playerTwoTurn)
        {
            pawnOneClicked = false; 
            pawnTwoClicked = true;
            pawnThreeClicked = false;
            pawnFourClicked = false;
            pawnHighlight.SetActive(true);
            squareHighlight.SetActive(false);
            squarePawnHighlight.SetActive(false);
            squarePawnHighlightTwo.SetActive(false);
            pawnHighlight.transform.position = playerTwoPawnTwo.transform.position;
            if(PawnTwoOnA2)
            {
                if(otherPawnOneOnB1 || otherPawnTwoOnB1 || otherPawnThreeOnB1)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = b1.transform.position;
                }
                if(otherPawnOneOnB3 || otherPawnTwoOnB3 || otherPawnThreeOnB3 || otherPawnFourOnB3)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlightTwo.transform.position = b3.transform.position;
                }
                if(!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2 && !otherPawnFourOnB2 && !PawnOneOnB2 && !PawnThreeOnB2)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = b2.transform.position;
                }
            }
            else if(PawnTwoOnB1)
            {   
                if(otherPawnOneOnC2 || otherPawnTwoOnC2 || otherPawnThreeOnC2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = c2.transform.position;
                }
                if(!otherPawnOneOnC1 && !otherPawnTwoOnC1 && !PawnOneOnC1 && !PawnThreeOnC1)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = c1.transform.position;
                }
            }
            else if(PawnTwoOnB2)
            {   
                if(otherPawnOneOnC1 || otherPawnTwoOnC1)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = c1.transform.position;
                }
                if(otherPawnTwoOnC3 || otherPawnThreeOnC3 || otherPawnFourOnC3)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlightTwo.transform.position = c3.transform.position;
                }
                if(!otherPawnOneOnC2 && !otherPawnTwoOnC2 && !otherPawnThreeOnC2 && !PawnOneOnC2 && !PawnThreeOnC2 && !PawnFourOnC2)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = c2.transform.position;
                }
            }
            else if(PawnTwoOnB3)
            {   
                if(otherPawnOneOnC2 || otherPawnTwoOnC2 || otherPawnThreeOnC2)
                {
                    squarePawnHighlight.SetActive(true);        
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = c2.transform.position;
                }
                if(otherPawnThreeOnC4 || otherPawnFourOnC4)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlightTwo.transform.position = c4.transform.position;
                }
                if(!otherPawnTwoOnC3 && !otherPawnThreeOnC3 && !otherPawnFourOnC3 && !PawnOneOnC3 && !PawnThreeOnC3 && !PawnFourOnC3)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = c3.transform.position;
                }
            }
            else if(PawnTwoOnC1)
            {
                if(otherPawnTwoOnD2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = d2.transform.position;
                }
                if(!otherPawnOneOnD1)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = d1.transform.position;
                }
            } 
            else if(PawnTwoOnC2)
            {
                if(otherPawnOneOnD1)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = d1.transform.position;
                }
                if(otherPawnThreeOnD3)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlightTwo.transform.position = d3.transform.position;
                }
                if(!otherPawnTwoOnD2)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = d2.transform.position;
                }
            } 
            else if(PawnTwoOnC3)
            {   
                if(otherPawnTwoOnD2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = d2.transform.position;
                }
                if(otherPawnFourOnD4)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlightTwo.transform.position = d4.transform.position;
                }
                if(!otherPawnThreeOnD3)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = d3.transform.position;
                }
            }
            else if(PawnTwoOnC4)
            {   
                if(otherPawnThreeOnD3)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = d4.transform.position;
                }
                if(!otherPawnFourOnD4)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = d4.transform.position;
                }
            }
        }
    }

    public void selectplayerTwoPawnThree()
    {
        if(playerTwoTurn)
        {
            pawnOneClicked = false; 
            pawnTwoClicked = false;
            pawnThreeClicked = true;
            pawnFourClicked = false;
            pawnHighlight.SetActive(true);
            squareHighlight.SetActive(false);
            squarePawnHighlight.SetActive(false);
            squarePawnHighlightTwo.SetActive(false);
            pawnHighlight.transform.position = playerTwoPawnThree.transform.position;
            if(PawnThreeOnA3)
            {
                if(otherPawnOneOnB2 || otherPawnTwoOnB2 || otherPawnThreeOnB2 || otherPawnFourOnB2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = b2.transform.position;
                }
                if(otherPawnTwoOnB4 || otherPawnThreeOnB4 || otherPawnFourOnB4)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlightTwo.transform.position = b4.transform.position;
                }
                if(!otherPawnOneOnB3 && !otherPawnTwoOnB3 && !otherPawnThreeOnB3 && !otherPawnFourOnB3 && !PawnTwoOnB3 && !PawnFourOnB3)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = b3.transform.position;
                }
            }
            else if(PawnThreeOnB2)
            {   
                if(otherPawnOneOnC1 || otherPawnTwoOnC1)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = c1.transform.position;
                }
                if(otherPawnTwoOnC3 || otherPawnThreeOnC3 || otherPawnFourOnC3)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlightTwo.transform.position = c3.transform.position;
                }
                if(!otherPawnOneOnC2 && !otherPawnTwoOnC2 && !otherPawnThreeOnC2 && !PawnOneOnC2 && !PawnTwoOnC2 && !PawnFourOnC2)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = c2.transform.position;
                }
            }
            else if(PawnThreeOnB3)
            {   
                if(otherPawnOneOnC2 || otherPawnTwoOnC2 || otherPawnThreeOnC2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = c2.transform.position;
                }
                if(otherPawnThreeOnC4 || otherPawnFourOnC4)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlightTwo.transform.position = c4.transform.position;
                }
                if(!otherPawnTwoOnC3 && !otherPawnThreeOnC3 && !otherPawnFourOnC3 && !PawnOneOnC3 && !PawnTwoOnC3 && !PawnFourOnC3)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = c3.transform.position;
                }
            }
            else if(PawnThreeOnB4)
            {   
                if(otherPawnTwoOnC3 || otherPawnThreeOnC3 || otherPawnFourOnC3)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = c3.transform.position;
                }
                if(!otherPawnThreeOnC4 && !otherPawnFourOnC4 && !PawnTwoOnC4 && !PawnFourOnC4)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = c4.transform.position;
                }
            }
            else if(PawnThreeOnC1)
            {
                if(otherPawnTwoOnD2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = d2.transform.position;
                }
                if(!otherPawnOneOnD1)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = d1.transform.position;
                }
            }
            else if(PawnThreeOnC2)
            {
                if(otherPawnOneOnD1)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = d1.transform.position;
                }
                if(otherPawnThreeOnD3)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlightTwo.transform.position = d3.transform.position;
                }
                if(!otherPawnTwoOnD2)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = d2.transform.position;
                }
            }
            else if(PawnThreeOnC3)
            {
                if(otherPawnTwoOnD2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = d2.transform.position;
                }
                if(otherPawnFourOnD4)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlightTwo.transform.position = d4.transform.position;
                }
                if(!otherPawnThreeOnD3)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = d3.transform.position;
                }
            }
            else if(PawnThreeOnC4)
            {
                if(otherPawnThreeOnD3)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = d3.transform.position;
                }
                if(!otherPawnFourOnD4)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = d4.transform.position;
                }
            }
        }
    }

    public void selectplayerTwoPawnFour()
    {
        if(playerTwoTurn)
        {
            pawnOneClicked = false; 
            pawnTwoClicked = false;
            pawnThreeClicked = false;
            pawnFourClicked = true;
            pawnHighlight.SetActive(true);
            squareHighlight.SetActive(false);
            squarePawnHighlight.SetActive(false);
            squarePawnHighlightTwo.SetActive(false);
            pawnHighlight.transform.position = playerTwoPawnFour.transform.position;
            if(PawnFourOnA4)
            {
                if(otherPawnOneOnB3 || otherPawnTwoOnB3 || otherPawnThreeOnB3 || otherPawnFourOnB3)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnFourCantMove = false;
                    squarePawnHighlight.transform.position = b3.transform.position;
                }
                if(!otherPawnTwoOnB4 && !otherPawnThreeOnB4 && !otherPawnFourOnB4 && !PawnThreeOnB4)
                {
                    squareHighlight.SetActive(true);
                    pawnFourCantMove = false;
                    squareHighlight.transform.position = b4.transform.position;
                }
            }
            else if(PawnFourOnB3)
            {   
                if(otherPawnOneOnC2 || otherPawnTwoOnC2 || otherPawnThreeOnC2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnFourCantMove = false;
                    squarePawnHighlight.transform.position = c2.transform.position;
                }
                if(otherPawnThreeOnC4 || otherPawnFourOnC4)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnFourCantMove = false;
                    squarePawnHighlightTwo.transform.position = c4.transform.position;
                }
                if(!otherPawnTwoOnC3 && !otherPawnThreeOnC3 && !otherPawnFourOnC3 && !PawnOneOnC3 && !PawnTwoOnC3 && !PawnThreeOnC3)
                {
                    squareHighlight.SetActive(true);
                    pawnFourCantMove = false;
                    squareHighlight.transform.position = c3.transform.position;
                }
            }
            else if(PawnFourOnB4)
            {   
                if(otherPawnTwoOnC3 || otherPawnThreeOnC3 || otherPawnFourOnC3)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnFourCantMove = false;
                    squarePawnHighlight.transform.position = c3.transform.position;
                }
                if(!otherPawnThreeOnC4 && !otherPawnFourOnC4 && !PawnTwoOnC4 && !PawnThreeOnC4)
                {
                    squareHighlight.SetActive(true);
                    pawnFourCantMove = false;
                    squareHighlight.transform.position = c4.transform.position;
                }
            }
            else if(PawnFourOnC2)
            {
                if(otherPawnOneOnD1)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnFourCantMove = false;
                    squarePawnHighlight.transform.position = d1.transform.position;
                }
                if(otherPawnThreeOnD3)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnFourCantMove = false;
                    squarePawnHighlightTwo.transform.position = d3.transform.position;
                }
                if(!otherPawnTwoOnD2)
                {
                    squareHighlight.SetActive(true);
                    pawnFourCantMove = false;
                    squareHighlight.transform.position = d2.transform.position;
                }
            }
            else if(PawnFourOnC3)
            {
                if(otherPawnTwoOnD2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnFourCantMove = false;
                    squarePawnHighlight.transform.position = d2.transform.position;
                }
                if(otherPawnFourOnD4)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnFourCantMove = false;
                    squarePawnHighlightTwo.transform.position = d4.transform.position;
                }
                if(!otherPawnThreeOnD3)
                {
                    squareHighlight.SetActive(true);
                    pawnFourCantMove = false;
                    squareHighlight.transform.position = d3.transform.position;
                }
            }
            else if(PawnFourOnC4)
            {
                if(otherPawnThreeOnD3)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnFourCantMove = false;
                    squarePawnHighlight.transform.position = d3.transform.position;
                }
                if(!otherPawnFourOnD4)
                {
                    squareHighlight.SetActive(true);
                    pawnFourCantMove = false;
                    squareHighlight.transform.position = d4.transform.position;
                }
            }
        }
    }


    public void TakeplayerTwoPawnOne()
    {
        if(playerTwoTurn)
        {
            if(pawnOneClicked)
            {
                  if(PawnOneOnA1)
                  {
                      if(otherPawnOneOnB2)
                      {
                        playerTwoPawnOne.transform.position = playerOnePawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                      }
                  }
                  else if(PawnOneOnB1)
                  {
                      if(otherPawnOneOnC2)
                      {
                        playerTwoPawnOne.transform.position = playerOnePawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                      }
                  }
                  else if(PawnOneOnB2)
                  {
                      if(otherPawnOneOnC1)
                      {
                        playerTwoPawnOne.transform.position = playerOnePawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                      }
                  }
                  else if(PawnOneOnC2)
                  {
                      if(otherPawnOneOnD1)
                      {
                        playerTwoPawnOne.transform.position = playerOnePawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnOne.SetActive(false);
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
                        playerTwoPawnTwo.transform.position = playerOnePawnOne.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                    if(otherPawnOneOnB3)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnOne.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnB1)
                {
                    if(otherPawnOneOnC2)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnOne.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnB2)
                {
                    if(otherPawnOneOnC1)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnOne.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnB3)
                {
                    if(otherPawnOneOnC2)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnOne.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnC2)
                {
                    if(otherPawnOneOnD1)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnOne.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnOne.SetActive(false);
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
                        playerTwoPawnThree.transform.position = playerOnePawnOne.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                   }
               }
               else if(PawnThreeOnB2)
               {
                   if(otherPawnOneOnC1)
                   {
                        playerTwoPawnThree.transform.position = playerOnePawnOne.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                   }
               }
               else if(PawnThreeOnB3)
               {
                   if(otherPawnOneOnC2)
                   {
                        playerTwoPawnThree.transform.position = playerOnePawnOne.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                   }
               }
               else if(PawnOneOnC2)
               {
                   if(otherPawnOneOnD1)
                   {
                        playerTwoPawnThree.transform.position = playerOnePawnOne.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                   }
               }
            }
            if(pawnFourClicked)
            {
                if(PawnFourOnA4)
                {
                    if(otherPawnOneOnB3)
                    {
                        playerTwoPawnFour.transform.position = playerOnePawnOne.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnFourOnB3)
                {
                    if(otherPawnOneOnC2)
                    {
                        playerTwoPawnFour.transform.position = playerOnePawnOne.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnFourOnC2)
                {
                    if(otherPawnOneOnD1)
                    {
                        playerTwoPawnFour.transform.position = playerOnePawnOne.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnOne.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
            }
        }
    }
    public void TakeplayerTwoPawnTwo()
    {
        if(playerTwoTurn)
        {
            if(pawnOneClicked)
            {
                if(PawnOneOnA1)
                {
                    if(otherPawnTwoOnB2)
                    {
                        playerTwoPawnOne.transform.position = playerOnePawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnOneOnB1)
                {
                    if(otherPawnTwoOnC2)
                    {
                        playerTwoPawnOne.transform.position = playerOnePawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnOneOnB2)
                {
                    if(otherPawnTwoOnC1)
                    {
                        playerTwoPawnOne.transform.position = playerOnePawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnTwoOnC3)
                    {
                        playerTwoPawnOne.transform.position = playerOnePawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnOneOnC1)
                {
                    if(otherPawnTwoOnD2)
                    {
                        playerTwoPawnOne.transform.position = playerOnePawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnOneOnC3)
                {
                    if(otherPawnTwoOnD2)
                    {
                        playerTwoPawnOne.transform.position = playerOnePawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
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
                        playerTwoPawnTwo.transform.position = playerOnePawnTwo.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnTwoOnB3)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnTwo.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnTwoOnB1)
                {
                    if(otherPawnTwoOnC2)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnTwo.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnTwoOnB2)
                {
                    if(otherPawnTwoOnC1)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnTwo.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnTwoOnC3)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnTwo.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnTwoOnB3)
                {
                    if(otherPawnTwoOnC2)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnTwo.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnTwoOnC1)
                {
                    if(otherPawnTwoOnD2)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnTwo.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnTwoOnC3)
                {
                    if(otherPawnTwoOnD2)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnTwo.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
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
                        playerTwoPawnThree.transform.position = playerOnePawnTwo.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnTwoOnB4)
                    {
                        playerTwoPawnThree.transform.position = playerOnePawnTwo.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
               }
               else if(PawnThreeOnB2)
               {
                    if(otherPawnTwoOnC1)
                    {
                        playerTwoPawnThree.transform.position = playerOnePawnTwo.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnTwoOnC3)
                    {
                        playerTwoPawnThree.transform.position = playerOnePawnTwo.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
               }
               else if(PawnThreeOnB3)
               {
                    if(otherPawnTwoOnC2)
                    {
                        playerTwoPawnThree.transform.position = playerOnePawnTwo.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
               }
               else if(PawnThreeOnB4)
               {
                    if(otherPawnTwoOnC3)
                    {
                        playerTwoPawnThree.transform.position = playerOnePawnTwo.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
               }
               else if(PawnThreeOnC1)
               {
                    if(otherPawnTwoOnD2)
                    {
                        playerTwoPawnThree.transform.position = playerOnePawnTwo.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
               }
               else if(PawnThreeOnC3)
               {
                    if(otherPawnTwoOnD2)
                    {
                        playerTwoPawnThree.transform.position = playerOnePawnTwo.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
               }
            }
            if(pawnFourClicked)
            {
                if(PawnFourOnA4)
                {
                    if(otherPawnTwoOnB3)
                    {
                        playerTwoPawnFour.transform.position = playerOnePawnTwo.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnFourOnB3)
                {
                    if(otherPawnTwoOnC2)
                    {
                        playerTwoPawnFour.transform.position = playerOnePawnTwo.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnFourOnB4)
                {
                    if(otherPawnTwoOnC3)
                    {
                        playerTwoPawnFour.transform.position = playerOnePawnTwo.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnFourOnC3)
                {
                    if(otherPawnTwoOnD2)
                    {
                        playerTwoPawnFour.transform.position = playerOnePawnTwo.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnTwo.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
            }
        }
    }
    public void TakeplayerTwoPawnThree()
    {
        if(playerTwoTurn)
        {
            if(pawnOneClicked)
            {
                if(PawnOneOnA1)
                {
                    if(otherPawnThreeOnB2)
                    {
                        playerTwoPawnOne.transform.position = playerOnePawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnOneOnB1)
                {
                    if(otherPawnThreeOnC2)
                    {
                        playerTwoPawnOne.transform.position = playerOnePawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnOneOnB2)
                {
                    if(otherPawnThreeOnC3)
                    {
                        playerTwoPawnOne.transform.position = playerOnePawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnOneOnC2)
                {
                    if(otherPawnThreeOnD3)
                    {
                        playerTwoPawnOne.transform.position = playerOnePawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
            }
            if(pawnTwoClicked)
            {
                if(PawnTwoOnA2)
                {
                    if(otherPawnThreeOnB1)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnThree.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnThreeOnB3)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnThree.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnB1)
                {
                    if(otherPawnThreeOnC2)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnThree.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnB2)
                {
                    if(otherPawnThreeOnC3)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnThree.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnB3)
                {
                    if(otherPawnThreeOnC2)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnThree.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnThreeOnC4)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnThree.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnC2)
                {
                    if(otherPawnThreeOnD3)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnThree.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnC4)
                {
                    if(otherPawnThreeOnD3)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnThree.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
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
                        playerTwoPawnThree.transform.position = playerOnePawnThree.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnThreeOnB4)
                    {
                        playerTwoPawnThree.transform.position = playerOnePawnThree.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnThreeOnB2)
                {
                    if(otherPawnThreeOnC3)
                    {
                        playerTwoPawnThree.transform.position = playerOnePawnThree.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnThreeOnB3)
                {
                    if(otherPawnThreeOnC2)
                    {
                        playerTwoPawnThree.transform.position = playerOnePawnThree.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnThreeOnC4)
                    {
                        playerTwoPawnThree.transform.position = playerOnePawnThree.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnThreeOnB4)
                {
                    if(otherPawnThreeOnC3)
                    {
                        playerTwoPawnThree.transform.position = playerOnePawnThree.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnThreeOnC2)
                {
                    if(otherPawnThreeOnD3)
                    {
                        playerTwoPawnThree.transform.position = playerOnePawnThree.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnThreeOnC4)
                {
                    if(otherPawnThreeOnD3)
                    {
                        playerTwoPawnThree.transform.position = playerOnePawnThree.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
            }
            if(pawnFourClicked)
            {
                if(PawnFourOnA4)
                {
                    if(otherPawnThreeOnB3)
                    {
                        playerTwoPawnFour.transform.position = playerOnePawnThree.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnFourOnB3)
                {
                    if(otherPawnThreeOnC2)
                    {
                        playerTwoPawnFour.transform.position = playerOnePawnThree.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                    if(otherPawnThreeOnC4)
                    {
                        playerTwoPawnFour.transform.position = playerOnePawnThree.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnFourOnB4)
                {
                    if(otherPawnThreeOnC3)
                    {
                        playerTwoPawnFour.transform.position = playerOnePawnThree.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnFourOnC2)
                {
                    if(otherPawnThreeOnD3)
                    {
                        playerTwoPawnFour.transform.position = playerOnePawnThree.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnFourOnC4)
                {
                    if(otherPawnThreeOnD3)
                    {
                        playerTwoPawnFour.transform.position = playerOnePawnThree.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnThree.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
            }
        }
    }

     public void TakeplayerTwoPawnFour()
    {
        if(playerTwoTurn)
        {
            if(pawnOneClicked)
            {
                if(PawnOneOnA1)
                {
                    if(otherPawnFourOnB2)
                    {
                        playerTwoPawnOne.transform.position = playerOnePawnFour.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnFour.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnOneOnB2)
                {
                    if(otherPawnFourOnC3)
                    {
                        playerTwoPawnOne.transform.position = playerOnePawnFour.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnFour.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnOneOnC3)
                {
                    if(otherPawnFourOnD4)
                    {
                        playerTwoPawnOne.transform.position = playerOnePawnFour.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnFour.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns(); 
                    }
                }
            }
            if(pawnTwoClicked)
            {
                if(PawnTwoOnA2)
                {
                    if(otherPawnFourOnB3)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnFour.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnFour.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnB2)
                {
                    if(otherPawnFourOnC3)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnFour.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnFour.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnB3)
                {
                    if(otherPawnFourOnC4)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnFour.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnFour.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnC3)
                {
                    if(otherPawnFourOnD4)
                    {
                        playerTwoPawnTwo.transform.position = playerOnePawnFour.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnFour.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
            }
            if(pawnThreeClicked)
            {
               if(PawnThreeOnA3)
               {
                   if(otherPawnFourOnB2)
                   {
                        playerTwoPawnThree.transform.position = playerOnePawnFour.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnFour.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                   }
                   else if(otherPawnFourOnB4)
                   {
                        playerTwoPawnThree.transform.position = playerOnePawnFour.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnFour.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                   }
               }
               if(PawnThreeOnB2)
               {
                   if(otherPawnFourOnC3)
                   {
                        playerTwoPawnThree.transform.position = playerOnePawnFour.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnFour.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                   }
               }
               if(PawnThreeOnB3)
               {    
                   if(otherPawnFourOnC4)
                   {
                        playerTwoPawnThree.transform.position = playerOnePawnFour.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnFour.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                   }
               }
               if(PawnThreeOnB4)
               {
                   if(otherPawnFourOnC3)
                   {
                        playerTwoPawnThree.transform.position = playerOnePawnFour.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnFour.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                   }
               }
               if(PawnThreeOnC3)
               {
                    if(otherPawnFourOnD4)
                    {
                        playerTwoPawnThree.transform.position = playerOnePawnFour.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnFour.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
               }
            }
            if(pawnFourClicked)
            {
                if(PawnFourOnA4)
                {
                    if(otherPawnFourOnB3)
                    {
                        playerTwoPawnFour.transform.position = playerOnePawnFour.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnFour.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnFourOnB3)
                {
                    if(otherPawnFourOnC4)
                    {
                        playerTwoPawnFour.transform.position = playerOnePawnFour.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnFour.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnFourOnB4)
                {
                    if(otherPawnFourOnC3)
                    {
                        playerTwoPawnFour.transform.position = playerOnePawnFour.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnFour.SetActive(false);
                        playerOnePawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnFourOnC3)
                {
                    if(otherPawnFourOnD4)
                    {
                        playerTwoPawnFour.transform.position = playerOnePawnFour.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerOnePawnFour.SetActive(false);
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
            if(pawnOneClicked && PawnOneOnA1)
            {
                if(!otherPawnOneOnB1 && !otherPawnTwoOnB1)
                {
                    playerTwoPawnOne.transform.position = b1.transform.position;
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
            if(pawnTwoClicked && PawnTwoOnA2)
            {
                if(!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2)
                {
                    playerTwoPawnTwo.transform.position = b2.transform.position;
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
            if(pawnThreeClicked && PawnThreeOnA3)
            {
                if(!otherPawnTwoOnB3 && !otherPawnThreeOnB3 && !otherPawnFourOnB3)
                {
                    playerTwoPawnThree.transform.position = b3.transform.position;
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
    public void clickOnB4()
    {
        if(playerTwoTurn)
        {
            if(pawnFourClicked && PawnFourOnA4)
            {
                if(!otherPawnThreeOnB4 && !otherPawnFourOnB4)
                {
                    playerTwoPawnFour.transform.position = b4.transform.position;
                    pawnFourClicked = false; 
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
            if(pawnOneClicked && PawnOneOnB1)
            {
                if(!otherPawnOneOnC1 && !otherPawnTwoOnC1)
                {
                    playerTwoPawnOne.transform.position = c1.transform.position;
                    pawnOneClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            else if(pawnTwoClicked && PawnTwoOnB1)
            {
                if(!otherPawnOneOnC1 && !otherPawnTwoOnC1 && !PawnThreeOnC1)
                {
                    playerTwoPawnTwo.transform.position = c1.transform.position;
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
            if(pawnOneClicked && PawnOneOnB2)
            {
                if(!otherPawnOneOnC2 && !otherPawnTwoOnC2 && !otherPawnThreeOnC2 && !PawnThreeOnC2 && !PawnFourOnC2)
                {
                    playerTwoPawnOne.transform.position = c2.transform.position;
                    pawnOneClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            else if(pawnTwoClicked && PawnTwoOnB2)
            {
                if(!otherPawnOneOnC2 && !otherPawnTwoOnC2 && !otherPawnThreeOnC2 && !PawnThreeOnC2 && !PawnFourOnC2)
                {
                    playerTwoPawnTwo.transform.position = c2.transform.position;
                    pawnTwoClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            if(pawnThreeClicked && PawnThreeOnB2)
            {
                if(!otherPawnOneOnC2 && !otherPawnTwoOnC2 && !otherPawnThreeOnC2 && !PawnThreeOnC2 && !PawnFourOnC2)
                {
                    playerTwoPawnThree.transform.position = c2.transform.position;
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
            if(pawnTwoClicked && PawnTwoOnB3)
            {
                if(!otherPawnTwoOnC3 && !otherPawnThreeOnC3 && !otherPawnFourOnC3)
                {
                    playerTwoPawnTwo.transform.position = c3.transform.position;
                    pawnTwoClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            } 
            else if(pawnThreeClicked && PawnThreeOnB3)
            {
                if(!otherPawnTwoOnC3 && !otherPawnThreeOnC3 && !otherPawnFourOnC3)
                {
                    playerTwoPawnThree.transform.position = c3.transform.position;
                    pawnThreeClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            } 
            else if(pawnFourClicked && PawnFourOnB3)
            {
                if(!otherPawnTwoOnC3 && !otherPawnThreeOnC3 && !otherPawnFourOnC3)
                {
                    playerTwoPawnFour.transform.position = c3.transform.position;
                    pawnFourClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            } 
        }
    }
    public void clickOnC4()
    {
        if(playerTwoTurn)
        {
            if(pawnThreeClicked && PawnThreeOnB4)
            {
                if(!otherPawnThreeOnC4 && !otherPawnFourOnC4)
                {
                    playerTwoPawnThree.transform.position = c4.transform.position;
                    pawnThreeClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            else if(pawnFourClicked && PawnFourOnB4)
            {
                if(!otherPawnThreeOnC4 && !otherPawnFourOnC4)
                {
                    playerTwoPawnFour.transform.position = c4.transform.position;
                    pawnFourClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
        }
    }
    public void clickOnD1()
    {
        if(playerTwoTurn)
        {
            if(pawnOneClicked && PawnOneOnC1)
            {
                if(!otherPawnOneOnD1)
                {
                    playerTwoPawnOne.transform.position = d1.transform.position;
                    pawnOneClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            else if(pawnTwoClicked && PawnTwoOnC1)
            {
                if(!otherPawnOneOnD1)
                {
                    playerTwoPawnTwo.transform.position = d1.transform.position;
                    pawnTwoClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            else if(pawnThreeClicked && PawnThreeOnC1)
            {
                if(!otherPawnOneOnD1)
                {
                    playerTwoPawnThree.transform.position = d1.transform.position;
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
    public void clickOnD2()
    {
        if(playerTwoTurn)
        {
            if(pawnOneClicked && PawnOneOnC2)
            {
                if(!otherPawnTwoOnD2)
                {
                    playerTwoPawnOne.transform.position = d2.transform.position;
                    pawnOneClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            else if(pawnTwoClicked && PawnTwoOnC2)
            {
                if(!otherPawnTwoOnD2)
                {
                    playerTwoPawnTwo.transform.position = d2.transform.position;
                    pawnTwoClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            else if(pawnThreeClicked && PawnThreeOnC2)
            {
                if(!otherPawnTwoOnD2)
                {
                    playerTwoPawnThree.transform.position = d2.transform.position;
                    pawnThreeClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            else if(pawnFourClicked && PawnFourOnC2)
            {
                if(!otherPawnTwoOnD2)
                {
                    playerTwoPawnFour.transform.position = d2.transform.position;
                    pawnFourClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
        }
    }
    public void clickOnD3()
    {
        if(playerTwoTurn)
        {
            if(pawnOneClicked && PawnOneOnC3)
            {
                if(!otherPawnThreeOnD3)
                {
                    playerTwoPawnOne.transform.position = d3.transform.position;
                    pawnOneClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            else if(pawnTwoClicked && PawnTwoOnC3)
            {
                if(!otherPawnThreeOnD3)
                {
                    playerTwoPawnTwo.transform.position = d3.transform.position;
                    pawnTwoClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            else if(pawnThreeClicked && PawnThreeOnC3)
            {
                if(!otherPawnThreeOnD3)
                {
                    playerTwoPawnThree.transform.position = d3.transform.position;
                    pawnThreeClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            else if(pawnFourClicked && PawnFourOnC3)
            {
                if(!otherPawnThreeOnD3)
                {
                    playerTwoPawnFour.transform.position = d3.transform.position;
                    pawnFourClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
        }
    }
    public void clickOnD4()
    {
        if(playerTwoTurn)
        {
            if(pawnTwoClicked && PawnTwoOnC4)
            {
                if(!otherPawnFourOnD4)
                {
                    playerTwoPawnTwo.transform.position = d4.transform.position;
                    pawnTwoClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            else if(pawnThreeClicked && PawnThreeOnC4)
            {
                if(!otherPawnFourOnD4)
                {
                    playerTwoPawnThree.transform.position = d4.transform.position;
                    pawnThreeClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            else if(pawnFourClicked && PawnFourOnC4)
            {
                if(!otherPawnFourOnD4)
                {
                    playerTwoPawnFour.transform.position = d4.transform.position;
                    pawnFourClicked = false; 
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
        playerOneScript.playerOneTurn = true;
    }
}