using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerMove : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
    public GameObject playerPawnOne;
    public GameObject playerPawnTwo;
    public GameObject playerPawnThree;
    public GameObject AIPawnOne;
    public GameObject AIPawnTwo;
    public GameObject AIPawnThree;
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
    public bool playerTurn = true;
    bool aiMoved;
    Vector3 mousePos;
    Vector2 mousePos2D;
    RaycastHit2D hit;
    // Start is called before the first frame update
    void Start()
    {
        addPhysics2DRaycaster();
        playerPawnOne = GameObject.FindWithTag("Player-1");
        playerPawnTwo = GameObject.FindWithTag("Player-2");
        playerPawnThree = GameObject.FindWithTag("Player-3");
        AIPawnOne = GameObject.FindWithTag("AI-Pawn-1");
        AIPawnTwo = GameObject.FindWithTag("AI-Pawn-2");
        AIPawnThree = GameObject.FindWithTag("AI-Pawn-3");
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
    }

    // Update is called once per frame
    void Update()
    {
        PawnOneOnA1 = GameObject.FindWithTag("GameController").GetComponent<boardState>().playerPawnOneOnA1;
        PawnOneOnA2 = GameObject.FindWithTag("GameController").GetComponent<boardState>().playerPawnOneOnA2;
        PawnOneOnA3 = GameObject.FindWithTag("GameController").GetComponent<boardState>().playerPawnOneOnA3;
        PawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<boardState>().playerPawnOneOnB1;
        PawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<boardState>().playerPawnOneOnB2;
        PawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<boardState>().playerPawnOneOnC1;
        PawnTwoOnA1 = GameObject.FindWithTag("GameController").GetComponent<boardState>().playerPawnTwoOnA1; 
        PawnTwoOnA2 = GameObject.FindWithTag("GameController").GetComponent<boardState>().playerPawnTwoOnA2; 
        PawnTwoOnA3 = GameObject.FindWithTag("GameController").GetComponent<boardState>().playerPawnTwoOnA3; 
        PawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<boardState>().playerPawnTwoOnB1;
        PawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<boardState>().playerPawnTwoOnB2;
        PawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<boardState>().playerPawnTwoOnB3; 
        PawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<boardState>().playerPawnTwoOnC2; 
        PawnThreeOnA1 = GameObject.FindWithTag("GameController").GetComponent<boardState>().playerPawnThreeOnA1;
        PawnThreeOnA2 = GameObject.FindWithTag("GameController").GetComponent<boardState>().playerPawnThreeOnA2;
        PawnThreeOnA3 = GameObject.FindWithTag("GameController").GetComponent<boardState>().playerPawnThreeOnA3;
        PawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<boardState>().playerPawnThreeOnB2;
        PawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<boardState>().playerPawnThreeOnB3;
        PawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<boardState>().playerPawnThreeOnC3;
        otherPawnOneOnA1 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnOneOnA1;
        otherPawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnOneOnB1;
        otherPawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnOneOnB2;
        otherPawnTwoOnA2 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnTwoOnA2;
        otherPawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnTwoOnB1;
        otherPawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnOneOnB2;
        otherPawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnTwoOnB3; 
        otherPawnThreeOnA3 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnThreeOnA3;
        otherPawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnThreeOnB2;
        otherPawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnThreeOnB3;
        aiMoved = GameObject.FindWithTag("GameController").GetComponent<AIMove>().AITurn;
        if(!aiMoved)
        {
            playerTurn = true;
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
            if(!otherPawnOneOnB1 && !otherPawnTwoOnB1)
            {
                squareHighlight.SetActive(true);
                squareHighlight.transform.position = b1.transform.position;   
            }
            if(otherPawnOneOnB2 || otherPawnTwoOnB2 || otherPawnThreeOnB2)
            {
                squarePawnHighlight.SetActive(true);
                squarePawnHighlight.transform.position = b2.transform.position; 
            }
        }
        else if(PawnOneOnB1)
        {
            if(!otherPawnOneOnA1)
            {
                squareHighlight.SetActive(true);
                squareHighlight.transform.position = a1.transform.position;  
            }
            if(otherPawnTwoOnA2)
            {
                squarePawnHighlight.SetActive(true);
                squarePawnHighlight.transform.position = a2.transform.position; 
            }

        }
        else if(PawnOneOnB2)
        {
            if(!otherPawnTwoOnA2)
            {
                squareHighlight.SetActive(true);
                squareHighlight.transform.position = a2.transform.position;
            }
            if(otherPawnOneOnA1)
            {
                squarePawnHighlight.SetActive(true);
                squarePawnHighlight.transform.position = a1.transform.position;
            }
            if(otherPawnThreeOnA3)
            {
                squarePawnHighlightTwo.SetActive(true);
                squarePawnHighlightTwo.transform.position = a3.transform.position;
            }
        }
    }


    public void selectPlayerPawnTwo()
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
            if(!otherPawnOneOnB2 && !otherPawnTwoOnB2 && !otherPawnThreeOnB3)
            {
                squareHighlight.SetActive(true);
                squareHighlight.transform.position = b2.transform.position;
            }
            if(otherPawnOneOnB1 || otherPawnTwoOnB1)
            {
                squarePawnHighlight.SetActive(true);
                squarePawnHighlight.transform.position = b1.transform.position;
            }
            if(otherPawnTwoOnB3 || otherPawnThreeOnB3)
            {
                squarePawnHighlightTwo.SetActive(true);
                squarePawnHighlightTwo.transform.position = b3.transform.position;
            }
        }
        else if(PawnTwoOnB2)
        {
            if(!otherPawnTwoOnA2)
            {
                squareHighlight.SetActive(true);
                squareHighlight.transform.position = a2.transform.position;
            }
            if(otherPawnOneOnA1)
            {
                squarePawnHighlight.SetActive(true);
                squarePawnHighlight.transform.position = a1.transform.position;
            }
            if(otherPawnThreeOnA3)
            {
                squarePawnHighlightTwo.SetActive(true);
                squarePawnHighlightTwo.transform.position = a3.transform.position;
            }
        }
        else if(PawnTwoOnB1)
        {
            if(!otherPawnOneOnA1)
            {
                squareHighlight.SetActive(true);
                squareHighlight.transform.position = a3.transform.position;
            }
            if(otherPawnTwoOnA2)
            {
                squarePawnHighlight.SetActive(true);
                squarePawnHighlight.transform.position = a2.transform.position; 
            }
        }
        else if(PawnTwoOnB3)
        {   
            if(!otherPawnThreeOnA3)
            {
                squareHighlight.SetActive(true);
                squareHighlight.transform.position = a3.transform.position;
            }
            if(otherPawnTwoOnA2)
            {
                squarePawnHighlight.SetActive(true);
                squarePawnHighlight.transform.position = a2.transform.position;
            }
        }
    }

    public void selectPlayerPawnThree()
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
            if(!otherPawnTwoOnB3 && !otherPawnThreeOnB3)
            {
                squareHighlight.SetActive(true);
                squareHighlight.transform.position = b3.transform.position;
            }
            if(otherPawnOneOnB2 || otherPawnTwoOnB2 || otherPawnThreeOnB2)
            {
                squarePawnHighlight.SetActive(true);
                squarePawnHighlight.transform.position = b2.transform.position;
            }
        }
        else if(PawnThreeOnB3)
        {
            if(!otherPawnThreeOnA3)
            {
                squareHighlight.SetActive(true);
                squareHighlight.transform.position = a3.transform.position;
            }
            if(otherPawnTwoOnA2)
            {
                squarePawnHighlight.SetActive(true);
                squarePawnHighlight.transform.position = a2.transform.position;
            }
        }
        else if(otherPawnThreeOnB2)
        {
            if(!otherPawnTwoOnA2)
            {
                squareHighlight.SetActive(true);
                squareHighlight.transform.position = a3.transform.position;
            }
            if(otherPawnOneOnA1)
            {
                squarePawnHighlight.SetActive(true);
                squarePawnHighlight.transform.position = a1.transform.position;
            }
            if(otherPawnThreeOnA3)
            {
                squarePawnHighlightTwo.SetActive(true);
                squarePawnHighlightTwo.transform.position = a3.transform.position;
            }
        }
    }

    public void TakeAIPawnOne()
    {
        if(pawnOneClicked)
        {
            if(PawnOneOnC1)
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
                   playerTurn = false;
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
                   playerTurn = false;
               } 
           }
       }
       if(pawnTwoClicked)
       {
           if(PawnTwoOnC2)
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
                   playerTurn = false;
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
                   playerTurn = false;
               } 
           }
       }
       if(pawnThreeClicked)
       {
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
                   playerTurn = false;
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
                   playerTurn = false;
               } 
           }
       }

    }
    public void TakeAIPawnTwo()
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
                   playerTurn = false;
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
                   playerTurn = false;
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
                   playerTurn = false;
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
                   playerTurn = false;
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
                   playerTurn = false;
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
                   playerTurn = false;
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
                   playerTurn = false;
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
                   playerTurn = false;
               } 
           }
       }
    }
    public void TakeAIPawnThree()
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
                   playerTurn = false;
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
                   playerTurn = false;
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
                   playerTurn = false;
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
                    playerTurn = false;
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
                    playerTurn = false;
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
                    playerTurn = false;
                } 
            }
        }
    }

    public void clickOnA1()
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
                playerTurn = false;
            }
        }
    }
    public void clickOnA2()
    {
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
                playerTurn = false;
            }
        }
    }
    public void clickOnA3()
    {
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
                playerTurn = false;
            }
        }
    }
    public void clickOnB1()
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
                playerTurn = false;   
            }
        }
        Debug.Log(playerTurn);
    }
    public void clickOnB2()
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
                playerTurn = false;
            }
        }    
    }
    public void clickOnB3()
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
                playerTurn = false;
            }
        }
    }
}
