using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class octopawnPlayerOneMove : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
    public GameObject playerOnePawnOne;
    public GameObject playerOnePawnTwo;
    public GameObject playerOnePawnThree;
    public GameObject playerOnePawnFour;
    public GameObject playerTwoPawnOne;
    public GameObject playerTwoPawnTwo;
    public GameObject playerTwoPawnThree;
    public GameObject playerTwoPawnFour;
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
    public octopawnPlayerTwoMove playerTwoScript;
    public AudioSource audioSource;
    public AudioClip pawnMove;
    public AudioClip takePawn;
    public float volume;
    public float turnTimer;
    bool pawnOneClicked;
    bool pawnTwoClicked;
    bool pawnThreeClicked;
    bool pawnFourClicked;
    bool PawnOneOnA1;
    bool PawnOneOnA2;
    bool PawnOneOnA3;
    bool PawnOneOnA4;
    bool PawnOneOnB1;
    bool PawnOneOnB2;
    bool PawnOneOnB3;
    bool PawnOneOnC1;
    bool PawnOneOnC2;
    bool PawnOneOnD1;
    bool PawnTwoOnA1;
    bool PawnTwoOnA2;
    bool PawnTwoOnA3;
    bool PawnTwoOnA4;
    bool PawnTwoOnB1;
    bool PawnTwoOnB2;
    bool PawnTwoOnB3;
    bool PawnTwoOnB4;
    bool PawnTwoOnC1; 
    bool PawnTwoOnC2; 
    bool PawnTwoOnC3; 
    bool PawnTwoOnD2; 
    bool PawnThreeOnA1;
    bool PawnThreeOnA2;
    bool PawnThreeOnA3;
    bool PawnThreeOnA4;
    bool PawnThreeOnB1;
    bool PawnThreeOnB2;
    bool PawnThreeOnB3;
    bool PawnThreeOnB4;
    bool PawnThreeOnC2;
    bool PawnThreeOnC3;
    bool PawnThreeOnC4;
    bool PawnThreeOnD3;
    bool PawnFourOnA1;
    bool PawnFourOnA2;
    bool PawnFourOnA3;
    bool PawnFourOnA4;
    bool PawnFourOnB2;
    bool PawnFourOnB3;
    bool PawnFourOnB4;
    bool PawnFourOnC3;
    bool PawnFourOnC4;
    bool PawnFourOnD4;
    bool otherPawnOneOnA1;
    bool otherPawnOneOnB1;
    bool otherPawnOneOnB2;
    bool otherPawnOneOnC1;
    bool otherPawnOneOnC2;
    bool otherPawnOneOnC3;
    bool otherPawnTwoOnA2;
    bool otherPawnTwoOnB1;
    bool otherPawnTwoOnB2;
    bool otherPawnTwoOnB3; 
    bool otherPawnTwoOnC1;
    bool otherPawnTwoOnC2;
    bool otherPawnTwoOnC3;
    bool otherPawnTwoOnC4;
    bool otherPawnThreeOnA3;
    bool otherPawnThreeOnB2;
    bool otherPawnThreeOnB3;
    bool otherPawnThreeOnB4;
    bool otherPawnThreeOnC1;
    bool otherPawnThreeOnC2;
    bool otherPawnThreeOnC3;
    bool otherPawnThreeOnC4;
    bool otherPawnFourOnA4;
    bool otherPawnFourOnB3;
    bool otherPawnFourOnB4;
    bool otherPawnFourOnC2;
    bool otherPawnFourOnC3;
    bool otherPawnFourOnC4;
    public bool playerOneTurn;
    public int playerTwoPawnNumber;
    public bool pawnOneCantMove;
    public bool pawnTwoCantMove;
    public bool pawnThreeCantMove;
    public bool pawnFourCantMove;
    public bool timeLoss;
    public Text uiText;
    // Start is called before the first frame update
    void Start()
    {
        playerTwoScript = GameObject.FindWithTag("GameController").GetComponent<octopawnPlayerTwoMove>();
        addPhysics2DRaycaster();
        playerOnePawnOne = GameObject.FindWithTag("Player-1");
        playerOnePawnTwo = GameObject.FindWithTag("Player-2");
        playerOnePawnThree = GameObject.FindWithTag("Player-3");
        playerOnePawnFour = GameObject.FindWithTag("Player-4");
        playerTwoPawnOne = GameObject.FindWithTag("player-2-pawn-1");
        playerTwoPawnTwo = GameObject.FindWithTag("player-2-pawn-2");
        playerTwoPawnThree = GameObject.FindWithTag("player-2-pawn-3");
        playerTwoPawnFour = GameObject.FindWithTag("player-2-pawn-4");
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
        playerOneTurn = true;
        playerTwoPawnNumber = 4;
        pawnOneCantMove = false;
        pawnTwoCantMove = false;
        pawnThreeCantMove = false;
        pawnFourCantMove = false;
        volume = 1.0f;
        turnTimer = 3.0f;
        timeLoss = false;
    }

    // Update is called once per frame
    void Update()
    {
        PawnOneOnA1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnOneOnA1;
        PawnOneOnA2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnOneOnA2;
        PawnOneOnA3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnOneOnA3;
        PawnOneOnA4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnOneOnA4;
        PawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnOneOnB1;
        PawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnOneOnB2;
        PawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnOneOnB3;
        PawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnOneOnC1;
        PawnOneOnC2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnOneOnC2;
        PawnOneOnD1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnOneOnD1;
        PawnTwoOnA1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnA1; 
        PawnTwoOnA2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnA2; 
        PawnTwoOnA3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnA3; 
        PawnTwoOnA4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnA4; 
        PawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnB1;
        PawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnB2;
        PawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnB3;
        PawnTwoOnB4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnB4;  
        PawnTwoOnC1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnC1; 
        PawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnC2; 
        PawnTwoOnC3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnC3; 
        PawnTwoOnD2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnTwoOnD2; 
        PawnThreeOnA1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnA1;
        PawnThreeOnA2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnA2;
        PawnThreeOnA3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnA3;
        PawnThreeOnA4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnA4;
        PawnThreeOnB1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnB1;
        PawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnB2;
        PawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnB3;
        PawnThreeOnB4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnB4;
        PawnThreeOnC2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnC2;
        PawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnC3;
        PawnThreeOnC4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnC4;
        PawnThreeOnD3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnThreeOnD3;
        PawnFourOnA1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnFourOnA1;
        PawnFourOnA2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnFourOnA2;
        PawnFourOnA3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnFourOnA3;
        PawnFourOnA4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnFourOnA4;
        PawnFourOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnFourOnB2;
        PawnFourOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnFourOnB3;
        PawnFourOnB4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnFourOnB4;
        PawnFourOnC3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnFourOnC3;
        PawnFourOnC4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnFourOnC4;
        PawnFourOnD4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerOnePawnFourOnD4;
        otherPawnOneOnA1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnOneOnA1;
        otherPawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnOneOnB1;
        otherPawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnOneOnB2;
        otherPawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnOneOnC1;
        otherPawnOneOnC2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnOneOnC2;
        otherPawnOneOnC3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnOneOnC3;
        otherPawnTwoOnA2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnA2;
        otherPawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnB1;
        otherPawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnB2;
        otherPawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnB3; 
        otherPawnTwoOnC1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnC1;
        otherPawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnC2;
        otherPawnTwoOnC3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnC3;
        otherPawnTwoOnC4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnTwoOnC4; 
        otherPawnThreeOnA3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnA3;
        otherPawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnB2;
        otherPawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnB3;
        otherPawnThreeOnB4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnB4;
        otherPawnThreeOnC1 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnC1;
        otherPawnThreeOnC2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnC2;
        otherPawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnC3;
        otherPawnThreeOnC4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnThreeOnC4;
        otherPawnFourOnA4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnFourOnA4;
        otherPawnFourOnB3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnFourOnB3;
        otherPawnFourOnB4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnFourOnB4;
        otherPawnFourOnC2 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnFourOnC2;
        otherPawnFourOnC3 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnFourOnC3;
        otherPawnFourOnC4 = GameObject.FindWithTag("GameController").GetComponent<multiplayerOctopawnBoardState>().playerTwoPawnFourOnC4;
        if(playerOneTurn)
        {
            uiText.text = turnTimer.ToString();
            turnTimer -= 1.0f * Time.deltaTime;
            if(turnTimer <= 0.0f)
            {
                timeLoss = true;
            }
            //Pawn one invalid move check
            if(PawnOneOnD1)
            {
                if((otherPawnOneOnC1 || otherPawnTwoOnC1 || otherPawnThreeOnC1) && (!otherPawnOneOnC2 && !otherPawnTwoOnC2 && !otherPawnThreeOnC2 && !otherPawnFourOnC2))
                {
                    pawnOneCantMove = true;
                }
            }
            else if(PawnOneOnC1)
            {
                if((otherPawnOneOnB1 || otherPawnTwoOnB1) && (!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2))
                {
                    pawnOneCantMove = true;
                }
            }
            else if(PawnOneOnC2)
            {
                if((otherPawnOneOnB2 || otherPawnTwoOnB2 || otherPawnThreeOnB2) && (!otherPawnOneOnB1 && !otherPawnTwoOnB2) && (!otherPawnTwoOnB3 && !otherPawnThreeOnB3 && !otherPawnFourOnB3))
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
            else if(PawnOneOnB3)
            {
                if(otherPawnThreeOnA3 && !otherPawnTwoOnA2 && !otherPawnFourOnA4)
                {
                    pawnOneCantMove = true;
                }
            }

            //Pawn two invalid move check
            if(PawnTwoOnD2)
            {
                if((otherPawnOneOnC2 || otherPawnTwoOnC2 || otherPawnThreeOnC2 || otherPawnThreeOnC2 || otherPawnFourOnC2)
                    && (!otherPawnOneOnC1 && !otherPawnTwoOnC1 && !otherPawnThreeOnC1) 
                    && (!otherPawnOneOnC3 && !otherPawnTwoOnC3 && !otherPawnThreeOnC3 && !otherPawnFourOnC3))
                {
                    pawnTwoCantMove = true;
                }
            }
            else if(PawnTwoOnC1)
            {
                if((otherPawnOneOnB1 || otherPawnTwoOnB1) && (!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2))
                {
                    pawnTwoCantMove = true;
                }
            }
            else if(PawnTwoOnC2)
            {
                if((otherPawnOneOnB2 || otherPawnTwoOnB2 || otherPawnThreeOnB2) && (!otherPawnOneOnB1 && !otherPawnTwoOnB1)
                    && (!otherPawnTwoOnB3 && !otherPawnThreeOnB3 && !otherPawnFourOnB3))
                {
                    pawnTwoCantMove = true;
                }
            }
            else if(PawnTwoOnC3)
            {
                if((otherPawnTwoOnB3 || otherPawnThreeOnB3 || otherPawnFourOnB3)
                && (!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2)
                && (!otherPawnThreeOnB4 && !otherPawnFourOnB4))
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
            else if(PawnTwoOnB2)
            {
                if(otherPawnTwoOnA2 && !otherPawnOneOnA1 && !otherPawnThreeOnA3)
                {
                    pawnTwoCantMove = true;
                }
            }
            else if(PawnTwoOnB3)
            {
                if(otherPawnThreeOnA3 && !otherPawnTwoOnA2 && !otherPawnFourOnA4)
                {
                    pawnTwoCantMove = true;
                }
            }
            else if(PawnTwoOnB4)
            {
                if(otherPawnFourOnA4 && !otherPawnThreeOnA3)
                {
                    pawnTwoCantMove = true;
                }
            }

            //Pawn three invalid move check
            if(PawnThreeOnD3)
            {
                if((otherPawnOneOnC3 || otherPawnTwoOnC3 || otherPawnThreeOnC3 || otherPawnFourOnC3)
                && (!otherPawnOneOnC2 && !otherPawnTwoOnC2 && !otherPawnThreeOnC2 && !otherPawnFourOnC2)
                && (!otherPawnThreeOnC4 && !otherPawnFourOnC4))
                {
                    pawnThreeCantMove = true;
                }
            }
            else if(PawnThreeOnC2)
            {
                if((otherPawnOneOnB2 || otherPawnTwoOnB2  || otherPawnThreeOnB2)
                && (!otherPawnOneOnB1 && !otherPawnTwoOnB1)
                && (!otherPawnThreeOnB3 && !otherPawnFourOnB3))
                {
                    pawnThreeCantMove = true;
                }
            }
            else if(PawnThreeOnC3)
            {
                if((otherPawnTwoOnB3 || otherPawnThreeOnB3 || otherPawnFourOnB3)
                && (!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2)
                && (!otherPawnThreeOnB4 && !otherPawnFourOnB4))
                {
                    pawnThreeCantMove = true;
                }
            }
            else if(PawnThreeOnC4)
            {
                if((otherPawnThreeOnB4 || otherPawnFourOnB4) && (!otherPawnThreeOnB3 && !otherPawnFourOnB3))
                {
                    pawnThreeCantMove = true;
                }
            }
            else if(PawnThreeOnB1)
            {
                if(otherPawnOneOnA1 && !otherPawnTwoOnA2)
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
            else if(PawnThreeOnB3)
            {
                if(otherPawnThreeOnA3 && !otherPawnTwoOnA2 && !otherPawnFourOnA4)
                {
                    pawnThreeCantMove = true;
                }
            }
            else if(PawnThreeOnB4)
            {
                if(otherPawnFourOnA4 && !otherPawnThreeOnA3)
                {
                    pawnThreeCantMove = true;
                }
            }

            //Pawn four invalid move check
            if(PawnFourOnD4)
            {
                if((otherPawnTwoOnC4 || otherPawnThreeOnC4 || otherPawnFourOnC4)
                && (!otherPawnOneOnC3 && !otherPawnTwoOnC3 && !otherPawnThreeOnC3 && !otherPawnFourOnC3))
                {
                    pawnFourCantMove = true;
                }
            }
            else if(PawnFourOnC3)
            {
                if((otherPawnTwoOnB3 || otherPawnThreeOnB3 || otherPawnFourOnB3)
                && (!otherPawnOneOnB2 && !otherPawnTwoOnB2)
                && (!otherPawnThreeOnB4 && !otherPawnFourOnB4))
                {
                    pawnFourCantMove = true;
                }
            }
            else if(PawnFourOnC4)
            {
                if((otherPawnThreeOnB4 || otherPawnFourOnB4)
                && (!otherPawnTwoOnB3 && !otherPawnThreeOnB3 && !otherPawnFourOnB3))
                {
                    pawnFourCantMove = true;
                }
            }
            else if(PawnFourOnB2)
            {
                if(otherPawnTwoOnA2 && !otherPawnOneOnA1 && !otherPawnThreeOnA3)
                {
                    pawnFourCantMove = true;
                }
            }
            else if(PawnFourOnB3)
            {
                if(otherPawnThreeOnA3 && !otherPawnTwoOnA2 && !otherPawnFourOnA4)
                {
                    pawnFourCantMove = true;
                }
            }
            else if(PawnFourOnB4)
            {
                if(otherPawnFourOnA4 && !otherPawnThreeOnA3)
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

    public void selectplayerOnePawnOne()
    {
        if(playerOneTurn)
        {
            pawnOneClicked = true; 
            pawnTwoClicked = false;
            pawnThreeClicked = false;
            pawnFourClicked = false;
            pawnHighlight.SetActive(true);
            pawnHighlight.transform.position = playerOnePawnOne.transform.position;
            squareHighlight.SetActive(false);
            squarePawnHighlight.SetActive(false);
            squarePawnHighlightTwo.SetActive(false);
            if(PawnOneOnD1)
            {
                if(otherPawnOneOnC2 || otherPawnTwoOnC2 || otherPawnThreeOnC2 || otherPawnFourOnC2)
                { 
                    squarePawnHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squarePawnHighlight.transform.position = c2.transform.position;
                }
                if(!otherPawnOneOnC1 && !otherPawnTwoOnC1 && !otherPawnThreeOnC1 && !PawnTwoOnC1)
                {
                    squareHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squareHighlight.transform.position = c1.transform.position;
                }
            }
            else if(PawnOneOnC1)
            {
                if(otherPawnOneOnB2 || otherPawnTwoOnB2 || otherPawnThreeOnB2)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squarePawnHighlight.transform.position = b2.transform.position;
                }
                if(!otherPawnOneOnB1 && !otherPawnTwoOnB1 && !PawnTwoOnB1 && !PawnThreeOnB1)
                {
                    squareHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squareHighlight.transform.position = b1.transform.position;
                }
            }
            else if(PawnOneOnC2)
            {
                if(otherPawnOneOnB1 || otherPawnTwoOnB1)
                {
                    squarePawnHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squarePawnHighlight.transform.position = b1.transform.position;
                }
                if(otherPawnTwoOnB3 || otherPawnThreeOnB3 || otherPawnFourOnB3)
                {
                    squarePawnHighlightTwo.SetActive(true);
                    pawnOneCantMove = false;
                    squarePawnHighlightTwo.transform.position = b3.transform.position;
                }
                if(!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2 && !PawnTwoOnB2 && !PawnThreeOnB2 && !PawnFourOnB2)
                {
                    squareHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squareHighlight.transform.position = b2.transform.position;
                }
            }
            else if(PawnOneOnB1)
            {   
                if(otherPawnTwoOnA2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnOneCantMove = false;
                    squarePawnHighlight.transform.position = a2.transform.position;
                }
                if(!otherPawnOneOnA1)
                {
                    squareHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squareHighlight.transform.position = a1.transform.position;
                }
            }
            else if(PawnOneOnB2)
            {
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
                if(!otherPawnTwoOnA2)
                {
                    squareHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squareHighlight.transform.position = a2.transform.position;
                }
            }
            else if(PawnOneOnB3)
            {
                if(otherPawnTwoOnA2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnOneCantMove = false;
                    squarePawnHighlight.transform.position = a2.transform.position;
                }
                if(otherPawnFourOnA4)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnOneCantMove = false;
                    squarePawnHighlightTwo.transform.position = a4.transform.position;
                }
                if(!otherPawnThreeOnA3)
                {
                    squareHighlight.SetActive(true);
                    pawnOneCantMove = false;
                    squareHighlight.transform.position = a3.transform.position;
                }
            }
        }
    }


    public void selectplayerOnePawnTwo()
    {
        if(playerOneTurn)
        {
            pawnOneClicked = false; 
            pawnTwoClicked = true;
            pawnThreeClicked = false;
            pawnFourClicked = false;
            pawnHighlight.SetActive(true);
            squareHighlight.SetActive(false);
            squarePawnHighlight.SetActive(false);
            squarePawnHighlightTwo.SetActive(false);
            pawnHighlight.transform.position = playerOnePawnTwo.transform.position;
            if(PawnTwoOnD2)
            {
                if(otherPawnOneOnC1 || otherPawnTwoOnC1 || otherPawnThreeOnC1)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = c1.transform.position;
                }
                if(otherPawnOneOnC3 || otherPawnTwoOnC3 || otherPawnThreeOnC3 || otherPawnFourOnC3)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlightTwo.transform.position = c3.transform.position;
                }
                if(!otherPawnOneOnC2 && !otherPawnTwoOnC2 && !otherPawnThreeOnC2 && !otherPawnFourOnC2 && !PawnOneOnC2 && !PawnThreeOnC2)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = c2.transform.position;
                }
            }
            else if(PawnTwoOnC1)
            {   
                if(otherPawnOneOnB2 || otherPawnTwoOnB2 || otherPawnThreeOnB2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = b2.transform.position;
                }
                if(!otherPawnOneOnB1 && !otherPawnTwoOnB1 && !PawnOneOnB1 && !PawnThreeOnB1)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = b1.transform.position;
                }
            }
            else if(PawnTwoOnC2)
            {   
                if(otherPawnOneOnB1 || otherPawnTwoOnB1)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = b1.transform.position;
                }
                if(otherPawnTwoOnB3 || otherPawnThreeOnB3 || otherPawnFourOnB3)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlightTwo.transform.position = b3.transform.position;
                }
                if(!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2 && !PawnOneOnB2 && !PawnThreeOnB2 && !PawnFourOnB2)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = b2.transform.position;
                }
            }
            else if(PawnTwoOnC3)
            {   
                if(otherPawnOneOnB2 || otherPawnTwoOnB2 || otherPawnThreeOnB2)
                {
                    squarePawnHighlight.SetActive(true);        
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = b2.transform.position;
                }
                if(otherPawnThreeOnB4 || otherPawnFourOnB4)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlightTwo.transform.position = b4.transform.position;
                }
                if(!otherPawnTwoOnB3 && !otherPawnThreeOnB3 && !otherPawnFourOnB3 && !PawnOneOnB3 && !PawnThreeOnB3 && !PawnFourOnB3)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = b3.transform.position;
                }
            }
            else if(PawnTwoOnB1)
            {
                if(otherPawnTwoOnA2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = a2.transform.position;
                }
                if(!otherPawnOneOnA1)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = a1.transform.position;
                }
            } 
            else if(PawnTwoOnB2)
            {
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
                if(!otherPawnTwoOnA2)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = a2.transform.position;
                }
            } 
            else if(PawnTwoOnB3)
            {   
                if(otherPawnTwoOnA2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = a2.transform.position;
                }
                if(otherPawnFourOnA4)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlightTwo.transform.position = a4.transform.position;
                }
                if(!otherPawnThreeOnA3)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = a3.transform.position;
                }
            }
            else if(PawnTwoOnB4)
            {   
                if(otherPawnThreeOnA3)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnTwoCantMove = false;
                    squarePawnHighlight.transform.position = a4.transform.position;
                }
                if(!otherPawnFourOnA4)
                {
                    squareHighlight.SetActive(true);
                    pawnTwoCantMove = false;
                    squareHighlight.transform.position = a4.transform.position;
                }
            }
        }
    }

    public void selectplayerOnePawnThree()
    {
        if(playerOneTurn)
        {
            pawnOneClicked = false; 
            pawnTwoClicked = false;
            pawnThreeClicked = true;
            pawnFourClicked = false;
            pawnHighlight.SetActive(true);
            squareHighlight.SetActive(false);
            squarePawnHighlight.SetActive(false);
            squarePawnHighlightTwo.SetActive(false);
            pawnHighlight.transform.position = playerOnePawnThree.transform.position;
            if(PawnThreeOnD3)
            {
                if(otherPawnOneOnC2 || otherPawnTwoOnC2 || otherPawnThreeOnC2 || otherPawnFourOnC2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = c2.transform.position;
                }
                if(otherPawnTwoOnC4 || otherPawnThreeOnC4 || otherPawnFourOnC4)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlightTwo.transform.position = c4.transform.position;
                }
                if(!otherPawnOneOnC3 && !otherPawnTwoOnC3 && !otherPawnThreeOnC3 && !otherPawnFourOnC3 && !PawnTwoOnC3 && !PawnFourOnC3)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = c3.transform.position;
                }
            }
            else if(PawnThreeOnC2)
            {   
                if(otherPawnOneOnB1 || otherPawnTwoOnB1)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = b1.transform.position;
                }
                if(otherPawnTwoOnB3 || otherPawnThreeOnB3 || otherPawnFourOnB3)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlightTwo.transform.position = b3.transform.position;
                }
                if(!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2 && !PawnOneOnB2 && !PawnTwoOnB2 && !PawnFourOnB2)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = b2.transform.position;
                }
            }
            else if(PawnThreeOnC3)
            {   
                if(otherPawnOneOnB2 || otherPawnTwoOnB2 || otherPawnThreeOnB2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = b2.transform.position;
                }
                if(otherPawnThreeOnB4 || otherPawnFourOnB4)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlightTwo.transform.position = b4.transform.position;
                }
                if(!otherPawnTwoOnB3 && !otherPawnThreeOnB3 && !otherPawnFourOnB3 && !PawnOneOnB3 && !PawnTwoOnB3 && !PawnFourOnB3)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = b3.transform.position;
                }
            }
            else if(PawnThreeOnC4)
            {   
                if(otherPawnTwoOnB3 || otherPawnThreeOnB3 || otherPawnFourOnB3)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = b3.transform.position;
                }
                if(!otherPawnThreeOnB4 && !otherPawnFourOnB4 && !PawnTwoOnB4 && !PawnFourOnB4)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = b4.transform.position;
                }
            }
            else if(PawnThreeOnB1)
            {
                if(otherPawnTwoOnA2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = a2.transform.position;
                }
                if(!otherPawnOneOnA1)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = a1.transform.position;
                }
            }
            else if(PawnThreeOnB2)
            {
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
                if(!otherPawnTwoOnA2)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = a2.transform.position;
                }
            }
            else if(PawnThreeOnB3)
            {
                if(otherPawnTwoOnA2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = a2.transform.position;
                }
                if(otherPawnFourOnA4)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlightTwo.transform.position = a4.transform.position;
                }
                if(!otherPawnThreeOnA3)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = a3.transform.position;
                }
            }
            else if(PawnThreeOnB4)
            {
                if(otherPawnThreeOnA3)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnThreeCantMove = false;
                    squarePawnHighlight.transform.position = a3.transform.position;
                }
                if(!otherPawnFourOnA4)
                {
                    squareHighlight.SetActive(true);
                    pawnThreeCantMove = false;
                    squareHighlight.transform.position = a4.transform.position;
                }
            }
        }
    }

    public void selectplayerOnePawnFour()
    {
        if(playerOneTurn)
        {
            pawnOneClicked = false; 
            pawnTwoClicked = false;
            pawnThreeClicked = false;
            pawnFourClicked = true;
            pawnHighlight.SetActive(true);
            squareHighlight.SetActive(false);
            squarePawnHighlight.SetActive(false);
            squarePawnHighlightTwo.SetActive(false);
            pawnHighlight.transform.position = playerOnePawnFour.transform.position;
            if(PawnFourOnD4)
            {
                if(otherPawnOneOnC3 || otherPawnTwoOnC3 || otherPawnThreeOnC3 || otherPawnFourOnC3)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnFourCantMove = false;
                    squarePawnHighlight.transform.position = c3.transform.position;
                }
                if(!otherPawnTwoOnC4 && !otherPawnThreeOnC4 && !otherPawnFourOnC4 && !PawnThreeOnC4)
                {
                    squareHighlight.SetActive(true);
                    pawnFourCantMove = false;
                    squareHighlight.transform.position = c4.transform.position;
                }
            }
            else if(PawnFourOnC3)
            {   
                if(otherPawnOneOnB2 || otherPawnTwoOnB2 || otherPawnThreeOnB2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnFourCantMove = false;
                    squarePawnHighlight.transform.position = b2.transform.position;
                }
                if(otherPawnThreeOnB4 || otherPawnFourOnB4)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnFourCantMove = false;
                    squarePawnHighlightTwo.transform.position = b4.transform.position;
                }
                if(!otherPawnTwoOnB3 && !otherPawnThreeOnB3 && !otherPawnFourOnB3 && !PawnOneOnB3 && !PawnTwoOnB3 && !PawnThreeOnB3)
                {
                    squareHighlight.SetActive(true);
                    pawnFourCantMove = false;
                    squareHighlight.transform.position = b3.transform.position;
                }
            }
            else if(PawnFourOnC4)
            {   
                if(otherPawnTwoOnB3 || otherPawnThreeOnB3 || otherPawnFourOnB3)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnFourCantMove = false;
                    squarePawnHighlight.transform.position = b3.transform.position;
                }
                if(!otherPawnThreeOnB4 && !otherPawnFourOnB4 && !PawnTwoOnB4 && !PawnThreeOnB4)
                {
                    squareHighlight.SetActive(true);
                    pawnFourCantMove = false;
                    squareHighlight.transform.position = b4.transform.position;
                }
            }
            else if(PawnFourOnB2)
            {
                if(otherPawnOneOnA1)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnFourCantMove = false;
                    squarePawnHighlight.transform.position = a1.transform.position;
                }
                if(otherPawnThreeOnA3)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnFourCantMove = false;
                    squarePawnHighlightTwo.transform.position = a3.transform.position;
                }
                if(!otherPawnTwoOnA2)
                {
                    squareHighlight.SetActive(true);
                    pawnFourCantMove = false;
                    squareHighlight.transform.position = a2.transform.position;
                }
            }
            else if(PawnFourOnB3)
            {
                if(otherPawnTwoOnA2)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnFourCantMove = false;
                    squarePawnHighlight.transform.position = a2.transform.position;
                }
                if(otherPawnFourOnA4)
                {
                    squarePawnHighlightTwo.SetActive(true);    
                    pawnFourCantMove = false;
                    squarePawnHighlightTwo.transform.position = a4.transform.position;
                }
                if(!otherPawnThreeOnA3)
                {
                    squareHighlight.SetActive(true);
                    pawnFourCantMove = false;
                    squareHighlight.transform.position = a3.transform.position;
                }
            }
            else if(PawnFourOnB4)
            {
                if(otherPawnThreeOnA3)
                {
                    squarePawnHighlight.SetActive(true);    
                    pawnFourCantMove = false;
                    squarePawnHighlight.transform.position = a3.transform.position;
                }
                if(!otherPawnFourOnA4)
                {
                    squareHighlight.SetActive(true);
                    pawnFourCantMove = false;
                    squareHighlight.transform.position = a4.transform.position;
                }
            }
        }
    }


    public void TakeplayerTwoPawnOne()
    {
        if(playerOneTurn)
        {
            if(pawnOneClicked)
            {
                  if(PawnOneOnD1)
                  {
                      if(otherPawnOneOnC2)
                      {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnOne.transform.position = playerTwoPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                      }
                  }
                  else if(PawnOneOnC1)
                  {
                      if(otherPawnOneOnB2)
                      {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnOne.transform.position = playerTwoPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                      }
                  }
                  else if(PawnOneOnC2)
                  {
                      if(otherPawnOneOnC1)
                      {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnOne.transform.position = playerTwoPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                      }
                  }
                  else if(PawnOneOnB2)
                  {
                      if(otherPawnOneOnA1)
                      {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnOne.transform.position = playerTwoPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                      }
                  }
            }
            if(pawnTwoClicked)
            {
                if(PawnTwoOnD2)
                {
                    if(otherPawnOneOnC1)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnOne.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                    if(otherPawnOneOnC3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnOne.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnC1)
                {
                    if(otherPawnOneOnB2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnOne.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnC2)
                {
                    if(otherPawnOneOnB1)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnOne.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnC3)
                {
                    if(otherPawnOneOnB2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnOne.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnB2)
                {
                    if(otherPawnOneOnA1)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnOne.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
            }
            if(pawnThreeClicked)
            {
               if(PawnThreeOnD3)
               {
                   if(otherPawnOneOnC2)
                   {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnOne.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                   }
               }
               else if(PawnThreeOnC2)
               {
                   if(otherPawnOneOnB1)
                   {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnOne.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                   }
               }
               else if(PawnThreeOnC3)
               {
                   if(otherPawnOneOnB2)
                   {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnOne.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                   }
               }
               else if(PawnOneOnB2)
               {
                   if(otherPawnOneOnA1)
                   {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnOne.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                   }
               }
            }
            if(pawnFourClicked)
            {
                if(PawnFourOnD4)
                {
                    if(otherPawnOneOnC3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnFour.transform.position = playerTwoPawnOne.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnFourOnC3)
                {
                    if(otherPawnOneOnB2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnFour.transform.position = playerTwoPawnOne.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnFourOnB2)
                {
                    if(otherPawnOneOnA1)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnFour.transform.position = playerTwoPawnOne.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnOne.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
            }
        }
    }
    public void TakeplayerTwoPawnTwo()
    {
        if(playerOneTurn)
        {
            if(pawnOneClicked)
            {
                if(PawnOneOnD1)
                {
                    if(otherPawnTwoOnC2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnOne.transform.position = playerTwoPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnOneOnC1)
                {
                    if(otherPawnTwoOnB2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnOne.transform.position = playerTwoPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnOneOnC2)
                {
                    if(otherPawnTwoOnB1)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnOne.transform.position = playerTwoPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnTwoOnB3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnOne.transform.position = playerTwoPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnOneOnB1)
                {
                    if(otherPawnTwoOnA2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnOne.transform.position = playerTwoPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnOneOnB3)
                {
                    if(otherPawnTwoOnA2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnOne.transform.position = playerTwoPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
            }   
            if(pawnTwoClicked)
            {
                if(PawnTwoOnD2)
                {
                    if(otherPawnTwoOnC1)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnTwo.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnTwoOnC3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnTwo.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnTwoOnC1)
                {
                    if(otherPawnTwoOnB2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnTwo.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnTwoOnC2)
                {
                    if(otherPawnTwoOnB1)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnTwo.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnTwoOnB3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnTwo.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnTwoOnC3)
                {
                    if(otherPawnTwoOnB2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnTwo.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnTwoOnB1)
                {
                    if(otherPawnTwoOnA2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnTwo.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnTwoOnB3)
                {
                    if(otherPawnTwoOnA2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnTwo.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
            }
            if(pawnThreeClicked)
            {
               if(PawnThreeOnD3)
               {
                    if(otherPawnTwoOnC2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnTwo.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnTwoOnC4)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnTwo.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
               }
               else if(PawnThreeOnC2)
               {
                    if(otherPawnTwoOnB1)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnTwo.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnTwoOnB3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnTwo.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
               }
               else if(PawnThreeOnC3)
               {
                    if(otherPawnTwoOnB2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnTwo.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
               }
               else if(PawnThreeOnC4)
               {
                    if(otherPawnTwoOnB3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnTwo.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
               }
               else if(PawnThreeOnB1)
               {
                    if(otherPawnTwoOnA2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnTwo.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
               }
               else if(PawnThreeOnB3)
               {
                    if(otherPawnTwoOnA2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnTwo.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
               }
            }
            if(pawnFourClicked)
            {
                if(PawnFourOnD4)
                {
                    if(otherPawnTwoOnC3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnFour.transform.position = playerTwoPawnTwo.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnFourOnC3)
                {
                    if(otherPawnTwoOnB2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnFour.transform.position = playerTwoPawnTwo.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnFourOnC4)
                {
                    if(otherPawnTwoOnB3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnFour.transform.position = playerTwoPawnTwo.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                else if(PawnFourOnB3)
                {
                    if(otherPawnTwoOnA2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnFour.transform.position = playerTwoPawnTwo.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnTwo.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
            }
        }
    }
    public void TakeplayerTwoPawnThree()
    {
        if(playerOneTurn)
        {
            if(pawnOneClicked)
            {
                if(PawnOneOnD1)
                {
                    if(otherPawnThreeOnC2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnOne.transform.position = playerTwoPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnOneOnC1)
                {
                    if(otherPawnThreeOnB2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnOne.transform.position = playerTwoPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnOneOnC2)
                {
                    if(otherPawnThreeOnB3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnOne.transform.position = playerTwoPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnOneOnB2)
                {
                    if(otherPawnThreeOnA3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnOne.transform.position = playerTwoPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
            }
            if(pawnTwoClicked)
            {
                if(PawnTwoOnD2)
                {
                    if(otherPawnThreeOnC1)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnThree.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnThreeOnC3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnThree.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnC1)
                {
                    if(otherPawnThreeOnB2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnThree.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnC2)
                {
                    if(otherPawnThreeOnB3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnThree.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnC3)
                {
                    if(otherPawnThreeOnB2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnThree.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnThreeOnB4)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnThree.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnB2)
                {
                    if(otherPawnThreeOnA3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnThree.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnB4)
                {
                    if(otherPawnThreeOnA3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnThree.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
            }
            if(pawnThreeClicked)
            {
                if(PawnThreeOnD3)
                {
                    if(otherPawnThreeOnC2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnThree.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnThreeOnC4)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnThree.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnThreeOnC2)
                {
                    if(otherPawnThreeOnB3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnThree.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnThreeOnC3)
                {
                    if(otherPawnThreeOnB2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnThree.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                    else if(otherPawnThreeOnB4)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnThree.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnThreeOnC4)
                {
                    if(otherPawnThreeOnB3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnThree.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnThreeOnB2)
                {
                    if(otherPawnThreeOnA3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnThree.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnThreeOnB4)
                {
                    if(otherPawnThreeOnA3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnThree.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
            }
            if(pawnFourClicked)
            {
                if(PawnFourOnD4)
                {
                    if(otherPawnThreeOnC3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnFour.transform.position = playerTwoPawnThree.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnFourOnC3)
                {
                    if(otherPawnThreeOnB2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnFour.transform.position = playerTwoPawnThree.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                    if(otherPawnThreeOnB4)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnFour.transform.position = playerTwoPawnThree.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnFourOnC4)
                {
                    if(otherPawnThreeOnB3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnFour.transform.position = playerTwoPawnThree.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnFourOnB2)
                {
                    if(otherPawnThreeOnA3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnFour.transform.position = playerTwoPawnThree.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnFourOnB4)
                {
                    if(otherPawnThreeOnA3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnFour.transform.position = playerTwoPawnThree.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnThree.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
            }
        }
    }

     public void TakeplayerTwoPawnFour()
    {
        if(playerOneTurn)
        {
            if(pawnOneClicked)
            {
                if(PawnOneOnD1)
                {
                    if(otherPawnFourOnC2)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnOne.transform.position = playerTwoPawnFour.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnFour.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnOneOnC2)
                {
                    if(otherPawnFourOnB3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnOne.transform.position = playerTwoPawnFour.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnFour.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnOneOnB3)
                {
                    if(otherPawnFourOnA4)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnOne.transform.position = playerTwoPawnFour.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnFour.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns(); 
                    }
                }
            }
            if(pawnTwoClicked)
            {
                if(PawnTwoOnD2)
                {
                    if(otherPawnFourOnC3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnFour.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnFour.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnC2)
                {
                    if(otherPawnFourOnB3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnFour.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnFour.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnC3)
                {
                    if(otherPawnFourOnB4)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnFour.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnFour.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnTwoOnB3)
                {
                    if(otherPawnFourOnA4)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnTwo.transform.position = playerTwoPawnFour.transform.position;
                        pawnTwoClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnFour.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
            }
            if(pawnThreeClicked)
            {
               if(PawnThreeOnD3)
               {
                   if(otherPawnFourOnC2)
                   {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnFour.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnFour.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                   }
                   else if(otherPawnFourOnC4)
                   {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnFour.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnFour.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                   }
               }
               if(PawnThreeOnC2)
               {
                   if(otherPawnFourOnB3)
                   {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnFour.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnFour.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                   }
               }
               if(PawnThreeOnC3)
               {    
                   if(otherPawnFourOnB4)
                   {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnFour.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnFour.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                   }
               }
               if(PawnThreeOnC4)
               {
                   if(otherPawnFourOnB3)
                   {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnFour.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnFour.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                   }
               }
               if(PawnThreeOnB3)
               {
                    if(otherPawnFourOnA4)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnThree.transform.position = playerTwoPawnFour.transform.position;
                        pawnThreeClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnFour.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
               }
            }
            if(pawnFourClicked)
            {
                if(PawnFourOnD4)
                {
                    if(otherPawnFourOnC3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnFour.transform.position = playerTwoPawnFour.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnFour.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnFourOnC3)
                {
                    if(otherPawnFourOnB4)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnFour.transform.position = playerTwoPawnFour.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnFour.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnFourOnC4)
                {
                    if(otherPawnFourOnB3)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnFour.transform.position = playerTwoPawnFour.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnFour.SetActive(false);
                        playerTwoPawnNumber--;
                        swapTurns();
                    }
                }
                if(PawnFourOnB3)
                {
                    if(otherPawnFourOnA4)
                    {
                        audioSource.PlayOneShot(takePawn, volume);
                        playerOnePawnFour.transform.position = playerTwoPawnFour.transform.position;
                        pawnFourClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        playerTwoPawnFour.SetActive(false);
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
            if(pawnOneClicked && PawnOneOnB1)
            {
                if(!otherPawnOneOnA1)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnOne.transform.position = a1.transform.position;
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
                if(!otherPawnOneOnA1)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnTwo.transform.position = a1.transform.position;
                    pawnTwoClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            else if(pawnThreeClicked && PawnThreeOnB1)
            {
                if(!otherPawnOneOnA1)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnThree.transform.position = a1.transform.position;
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
    public void clickOnA2()
    {
        if(playerOneTurn)
        {
            if(pawnOneClicked && PawnOneOnB2)
            {
                if(!otherPawnTwoOnA2)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnOne.transform.position = a2.transform.position;
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
                if(!otherPawnTwoOnA2)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnTwo.transform.position = a2.transform.position;
                    pawnTwoClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            else if(pawnThreeClicked && PawnThreeOnB2)
            {
                if(!otherPawnTwoOnA2)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnThree.transform.position = a2.transform.position;
                    pawnThreeClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            else if(pawnFourClicked && PawnFourOnB2)
            {
                if(!otherPawnTwoOnA2)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnFour.transform.position = a2.transform.position;
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
    public void clickOnA3()
    {
        if(playerOneTurn)
        {
            if(pawnOneClicked && PawnOneOnB3)
            {
                if(!otherPawnThreeOnA3)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnOne.transform.position = a3.transform.position;
                    pawnOneClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            else if(pawnTwoClicked && PawnTwoOnB3)
            {
                if(!otherPawnThreeOnA3)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnTwo.transform.position = a3.transform.position;
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
                if(!otherPawnThreeOnA3)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnThree.transform.position = a3.transform.position;
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
                if(!otherPawnThreeOnA3)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnFour.transform.position = a3.transform.position;
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
    public void clickOnA4()
    {
        if(playerOneTurn)
        {
            if(pawnTwoClicked && PawnTwoOnB4)
            {
                if(!otherPawnFourOnA4)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnTwo.transform.position = a4.transform.position;
                    pawnTwoClicked = false; 
                    pawnHighlight.SetActive(false);
                    squareHighlight.SetActive(false);
                    squarePawnHighlight.SetActive(false);
                    squarePawnHighlightTwo.SetActive(false);
                    swapTurns();
                }
            }
            else if(pawnThreeClicked && PawnThreeOnB4)
            {
                if(!otherPawnFourOnA4)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnThree.transform.position = a4.transform.position;
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
                if(!otherPawnFourOnA4)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnFour.transform.position = a4.transform.position;
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
    public void clickOnB1()
    {
        if(playerOneTurn)
        {
            if(pawnOneClicked && PawnOneOnC1)
            {
                if(!otherPawnOneOnB1 && !otherPawnTwoOnB1)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnOne.transform.position = b1.transform.position;
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
                if(!otherPawnOneOnB1 && !otherPawnTwoOnB1)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnTwo.transform.position = b1.transform.position;
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
    public void clickOnB2()
    {
        if(playerOneTurn)
        {
            if(pawnOneClicked && PawnOneOnC2)
            {
                if(!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnOne.transform.position = b2.transform.position;
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
                if(!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnTwo.transform.position = b2.transform.position;
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
                if(!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB2)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnThree.transform.position = b2.transform.position;
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
    public void clickOnB3()
    {
        if(playerOneTurn)
        {
            if(pawnTwoClicked && PawnTwoOnC3)
            {
                if(!otherPawnTwoOnC3 && !otherPawnThreeOnC3 && !otherPawnFourOnC3)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnTwo.transform.position = b3.transform.position;
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
                if(!otherPawnTwoOnC3 && !otherPawnThreeOnC3 && !otherPawnFourOnC3)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnThree.transform.position = b3.transform.position;
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
                if(!otherPawnTwoOnC3 && !otherPawnThreeOnC3 && !otherPawnFourOnC3)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnFour.transform.position = b3.transform.position;
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
    public void clickOnB4()
    {
        if(playerOneTurn)
        {
            if(pawnThreeClicked && PawnThreeOnC4)
            {
                if(!otherPawnThreeOnC4 && !otherPawnFourOnC4)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnThree.transform.position = b4.transform.position;
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
                if(!otherPawnThreeOnC4 && !otherPawnFourOnC4)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnFour.transform.position = b4.transform.position;
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
        if(playerOneTurn)
        {
            if(pawnOneClicked && PawnOneOnD1)
            {
                if(!otherPawnOneOnC1 && !otherPawnTwoOnC1 && !otherPawnThreeOnC1)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnOne.transform.position = c1.transform.position;
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
    public void clickOnC2()
    {
        if(playerOneTurn)
        {
            if(pawnTwoClicked && PawnTwoOnD2)
            {
                if(!otherPawnOneOnC2 && !otherPawnTwoOnC2 && !otherPawnThreeOnC2 && !otherPawnThreeOnC2 && !otherPawnFourOnC2)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnTwo.transform.position = c2.transform.position;
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
    public void clickOnC3()
    {
        if(playerOneTurn)
        {
           if(pawnThreeClicked && PawnThreeOnD3)
            {
                if(!otherPawnOneOnC3 && !otherPawnTwoOnC3 && !otherPawnThreeOnC3 && !otherPawnFourOnC3)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnThree.transform.position = c3.transform.position;
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
    public void clickOnC4()
    {
        if(playerOneTurn)
        {
            if(pawnFourClicked && PawnFourOnD4)
            {
                if(!otherPawnTwoOnC4 && !otherPawnThreeOnC4 && !otherPawnFourOnC4)
                {
                    audioSource.PlayOneShot(pawnMove, volume);
                    playerOnePawnFour.transform.position = c4.transform.position;
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
        playerOneTurn = false;
        playerTwoScript.playerTwoTurn = true;
    }
}