using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class octopawnPlayerMove : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
    public GameObject playerPawnOne;
    public GameObject playerPawnTwo;
    public GameObject playerPawnThree;
    public GameObject playerPawnFour;
    public GameObject AIPawnOne;
    public GameObject AIPawnTwo;
    public GameObject AIPawnThree;
    public GameObject AIPawnFour;
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
    public octopawnAIMove AIScript;
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
    public bool playerTurn;
    public int AIPawnNumber;
    public bool pawnOneCantMove;
    public bool pawnTwoCantMove;
    public bool pawnThreeCantMove;
    public bool pawnFourCantMove;
    // Start is called before the first frame update
    void Start()
    {
        AIScript = GameObject.FindWithTag("GameController").GetComponent<octopawnAIMove>();
        addPhysics2DRaycaster();
        playerPawnOne = GameObject.FindWithTag("Player-1");
        playerPawnTwo = GameObject.FindWithTag("Player-2");
        playerPawnThree = GameObject.FindWithTag("Player-3");
        playerPawnFour = GameObject.FindWithTag("Player-4");
        AIPawnOne = GameObject.FindWithTag("AI-Pawn-1");
        AIPawnTwo = GameObject.FindWithTag("AI-Pawn-2");
        AIPawnThree = GameObject.FindWithTag("AI-Pawn-3");
        AIPawnFour = GameObject.FindWithTag("AI-Pawn-4");
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
        playerTurn = true;
        AIPawnNumber = 4;
        pawnOneCantMove = false;
        pawnTwoCantMove = false;
        pawnThreeCantMove = false;
        pawnFourCantMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        PawnOneOnA1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnOneOnA1;
        PawnOneOnA2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnOneOnA2;
        PawnOneOnA3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnOneOnA3;
        PawnOneOnA4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnOneOnA4;
        PawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnOneOnB1;
        PawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnOneOnB2;
        PawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnOneOnB3;
        PawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnOneOnC1;
        PawnOneOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnOneOnC2;
        PawnOneOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnOneOnD1;
        PawnTwoOnA1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnA1; 
        PawnTwoOnA2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnA2; 
        PawnTwoOnA3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnA3; 
        PawnTwoOnA4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnA4; 
        PawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnB1;
        PawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnB2;
        PawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnB3;
        PawnTwoOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnB4;  
        PawnTwoOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnC1; 
        PawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnC2; 
        PawnTwoOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnC3; 
        PawnTwoOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnTwoOnD2; 
        PawnThreeOnA1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnA1;
        PawnThreeOnA2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnA2;
        PawnThreeOnA3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnA3;
        PawnThreeOnA4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnA4;
        PawnThreeOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnB1;
        PawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnB2;
        PawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnB3;
        PawnThreeOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnB4;
        PawnThreeOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnC2;
        PawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnC3;
        PawnThreeOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnC4;
        PawnThreeOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnThreeOnD3;
        PawnFourOnA1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnFourOnA1;
        PawnFourOnA2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnFourOnA2;
        PawnFourOnA3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnFourOnA3;
        PawnFourOnA4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnFourOnA4;
        PawnFourOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnFourOnB2;
        PawnFourOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnFourOnB3;
        PawnFourOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnFourOnB4;
        PawnFourOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnFourOnC3;
        PawnFourOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnFourOnC4;
        PawnFourOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().playerPawnFourOnD4;
        otherPawnOneOnA1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnOneOnA1;
        otherPawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnOneOnB1;
        otherPawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnOneOnB2;
        otherPawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnOneOnC1;
        otherPawnOneOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnOneOnC2;
        otherPawnOneOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnOneOnC3;
        otherPawnTwoOnA2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnA2;
        otherPawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnB1;
        otherPawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnB2;
        otherPawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnB3; 
        otherPawnTwoOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnC1;
        otherPawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnC2;
        otherPawnTwoOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnC3;
        otherPawnTwoOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnTwoOnC4; 
        otherPawnThreeOnA3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnA3;
        otherPawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnB2;
        otherPawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnB3;
        otherPawnThreeOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnB4;
        otherPawnThreeOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnC1;
        otherPawnThreeOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnC2;
        otherPawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnC3;
        otherPawnThreeOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnThreeOnC4;
        otherPawnFourOnA4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnFourOnA4;
        otherPawnFourOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnFourOnB3;
        otherPawnFourOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnFourOnB4;
        otherPawnFourOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnFourOnC2;
        otherPawnFourOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnFourOnC3;
        otherPawnFourOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnBoardState>().AIPawnFourOnC4;
        if(playerTurn)
        {
            if(PawnOneOnC1)
            {
                if((otherPawnOneOnB1 || otherPawnTwoOnB1 || PawnTwoOnB1) && (!otherPawnOneOnB2 && !otherPawnTwoOnB2 & !otherPawnThreeOnB2))
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
        if(playerTurn)
        {
            pawnOneClicked = true; 
            pawnTwoClicked = false;
            pawnThreeClicked = false;
            pawnFourClicked = false;
            pawnHighlight.SetActive(true);
            pawnHighlight.transform.position = playerPawnOne.transform.position;
            squareHighlight.SetActive(false);
            squarePawnHighlight.SetActive(false);
            squarePawnHighlightTwo.SetActive(false);
            if(PawnOneOnD1)
            {
                
            }
            else if(PawnOneOnC1)
            {

            }
            else if(PawnOneOnC2)
            {
                
            }
            else if(PawnOneOnB1)
            {   
                
            }
            else if(PawnOneOnB2)
            {
                
            }
            else if(PawnOneOnB3)
            {
                
            }
        }
    }


    public void selectPlayerPawnTwo()
    {
        if(playerTurn)
        {
            pawnOneClicked = false; 
            pawnTwoClicked = true;
            pawnThreeClicked = false;
            pawnFourClicked = false;
            pawnHighlight.SetActive(true);
            squareHighlight.SetActive(false);
            squarePawnHighlight.SetActive(false);
            squarePawnHighlightTwo.SetActive(false);
            pawnHighlight.transform.position = playerPawnTwo.transform.position;
            if(PawnTwoOnD2)
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
            else if(PawnTwoOnB1)
            {

            } 
            else if(PawnTwoOnB2)
            {
                
            } 
            else if(PawnTwoOnB3)
            {   
                
            }
            else if(PawnTwoOnB4)
            {   
                
            }
        }
    }

    public void selectPlayerPawnThree()
    {
        if(playerTurn)
        {
            pawnOneClicked = false; 
            pawnTwoClicked = false;
            pawnThreeClicked = true;
            pawnFourClicked = false;
            pawnHighlight.SetActive(true);
            squareHighlight.SetActive(false);
            squarePawnHighlight.SetActive(false);
            squarePawnHighlightTwo.SetActive(false);
            pawnHighlight.transform.position = playerPawnThree.transform.position;
            if(PawnThreeOnD3)
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
            else if(PawnThreeOnB1)
            {
                
            }
            else if(PawnThreeOnB2)
            {
                
            }
            else if(PawnThreeOnB3)
            {
                
            }
            else if(PawnThreeOnB4)
            {
                
            }
        }
    }

    public void selectPlayerPawnFour()
    {
        if(playerTurn)
        {
            pawnOneClicked = false; 
            pawnTwoClicked = false;
            pawnThreeClicked = false;
            pawnFourClicked = true;
            pawnHighlight.SetActive(true);
            squareHighlight.SetActive(false);
            squarePawnHighlight.SetActive(false);
            squarePawnHighlightTwo.SetActive(false);
            pawnHighlight.transform.position = playerPawnFour.transform.position;
            if(PawnFourOnD4)
            {
                
            }
            else if(PawnFourOnC3)
            {   
                
            }
            else if(PawnFourOnC4)
            {   
                
            }
            else if(PawnFourOnB2)
            {
                
            }
            else if(PawnFourOnB3)
            {
                
            }
            else if(PawnFourOnB4)
            {
                
            }
        }
    }


    public void TakeAIPawnOne()
    {
        if(playerTurn)
        {
            if(pawnOneClicked)
            {
                if(PawnOneOnD1)
                {
                    if(otherPawnOneOnC2)
                    {
                        playerPawnOne.transform.position = AIPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnOne.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    }
                }
                else if(PawnOneOnC1)
                {
                    if(otherPawnOneOnB2)
                    {
                        playerPawnOne.transform.position = AIPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnOne.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    }
                }
                else if(PawnOneOnC2)
                {
                    if(otherPawnOneOnB1)
                    {
                        playerPawnOne.transform.position = AIPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnOne.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    } 
                }
                else if(PawnOneOnB2)
                {
                    if(otherPawnOneOnA1)
                    {
                        playerPawnOne.transform.position = AIPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnOne.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    } 
                }
            }
            if(pawnTwoClicked)
            {
                if(PawnTwoOnD2)
                {
                    if(otherPawnOneOnC1)
                    {
                        playerPawnTwo.transform.position = AIPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnOne.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    }
                    else if(otherPawnOneOnC3)
                    {
                        playerPawnTwo.transform.position = AIPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnOne.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    }
                }
                else if(PawnTwoOnC1)
                {
                    if(otherPawnOneOnB2)
                    {
                        playerPawnTwo.transform.position = AIPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnOne.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    }
                }
                else if(PawnTwoOnC2)
                {
                    if(otherPawnOneOnB1)
                    {
                        playerPawnTwo.transform.position = AIPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnOne.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    }
                }
                else if(PawnTwoOnC3)
                {
                    if(otherPawnOneOnB2)
                    {
                        playerPawnTwo.transform.position = AIPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnOne.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    }
                }
                else if(PawnTwoOnB2)
                {
                    if(otherPawnOneOnA1)
                    {
                        playerPawnTwo.transform.position = AIPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnOne.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    } 
                }
            }
            if(pawnThreeClicked)
            {
                if(PawnThreeOnD3)
                {
                    if(otherPawnOneOnC2)
                    {
                        playerPawnThree.transform.position = AIPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnOne.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    }
                }
                if(PawnThreeOnC3)
                {
                    if(otherPawnOneOnB2)
                    {
                        playerPawnThree.transform.position = AIPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnOne.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    }
                }
                if(PawnThreeOnC2)
                {
                    if(otherPawnOneOnB1)
                    {
                        playerPawnThree.transform.position = AIPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnOne.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    }
                }
                else if(PawnThreeOnB2)
                {
                    if(otherPawnOneOnA1)
                    {
                        playerPawnThree.transform.position = AIPawnOne.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnOne.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    } 
                }
            }
        }
    }
    public void TakeAIPawnTwo()
    {
        if(playerTurn)
        {
            if(pawnOneClicked)
            {
            if(PawnOneOnC1)
                {
                    if(otherPawnTwoOnB2)
                    {
                        playerPawnOne.transform.position = AIPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnTwo.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    }
                }
                else if(PawnOneOnB1)
                {
                    if(otherPawnTwoOnA2)
                    {
                        playerPawnOne.transform.position = AIPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnTwo.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    } 
                }
            }   
            if(pawnTwoClicked)
            {
                if(PawnTwoOnC2)
                {
                    if(otherPawnTwoOnB1)
                    {
                        playerPawnTwo.transform.position = AIPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnTwo.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    }
                    else if(otherPawnTwoOnB3)
                    {
                        playerPawnTwo.transform.position = AIPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnTwo.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    }
                }
                else if(PawnTwoOnB1)
                {
                    if(otherPawnTwoOnA2)
                    {
                        playerPawnTwo.transform.position = AIPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnTwo.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    } 
                }
                else if(PawnTwoOnB3)
                {
                    if(otherPawnTwoOnA2)
                    {
                        playerPawnTwo.transform.position = AIPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnTwo.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    } 
                }
            }
            if(pawnThreeClicked)
            {
                if(PawnThreeOnC3)
                {
                    if(otherPawnTwoOnB2)
                    {
                        playerPawnThree.transform.position = AIPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnTwo.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    }
                }
                else if(PawnThreeOnB3)
                {
                    if(otherPawnTwoOnA2)
                    {
                        playerPawnThree.transform.position = AIPawnTwo.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnTwo.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    } 
                }
            }
        }
    }
    public void TakeAIPawnThree()
    {
        if(playerTurn)
        {
            if(pawnOneClicked)
            {
                if(PawnOneOnC1)
                {
                    if(otherPawnThreeOnB2)
                    {
                        playerPawnOne.transform.position = AIPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnThree.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    }
                }
                else if(PawnOneOnB2)
                {
                    if(otherPawnThreeOnA3)
                    {
                        playerPawnOne.transform.position = AIPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnThree.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    } 
                }
            }
            if(pawnTwoClicked)
            {
                if(PawnTwoOnC2)
                {
                    if(otherPawnThreeOnB3)
                    {
                        playerPawnTwo.transform.position = AIPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnThree.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    }
                }
                else if(PawnTwoOnB2)
                {
                    if(otherPawnThreeOnA3)
                    {
                        playerPawnTwo.transform.position = AIPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnThree.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    } 
                }
            }
            if(pawnThreeClicked)
            {
                if(PawnThreeOnC3)
                {
                    if(otherPawnThreeOnB2)
                    {
                        playerPawnThree.transform.position = AIPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnThree.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    }
                }
                else if(PawnThreeOnB2)
                {
                    if(otherPawnThreeOnA3)
                    {
                        playerPawnThree.transform.position = AIPawnThree.transform.position;
                        pawnOneClicked = false; 
                        pawnHighlight.SetActive(false);
                        squareHighlight.SetActive(false);
                        squarePawnHighlight.SetActive(false);
                        squarePawnHighlightTwo.SetActive(false);
                        AIPawnThree.SetActive(false);
                        AIPawnNumber--;
                        swapToAITurn();
                    } 
                }
            }
        }
    }

    public void clickOnA1()
    {
        if(playerTurn)
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
                    swapToAITurn();
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
                    swapToAITurn();
                }
            }
        }
    }
    public void clickOnA2()
    {
        if(playerTurn)
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
                    swapToAITurn(); 
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
                    swapToAITurn(); 
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
                    swapToAITurn(); 
                }
            }
        }
    }
    public void clickOnA3()
    {
        if(playerTurn)
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
                    swapToAITurn();
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
                    swapToAITurn();
                }
            }
        }
    }
    public void clickOnB1()
    {
        if(playerTurn)
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
                    swapToAITurn();
                }
            }
        }
    }
    public void clickOnB2()
    {
        if(playerTurn)
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
                    swapToAITurn();
                }
            }    
        }
    }
    public void clickOnB3()
    {
        if(playerTurn)
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
                    swapToAITurn();
                }
            }
        }
    }

    void swapToAITurn()
    {
        playerTurn = false;
        AIScript.AITurn = true;
    }
}
