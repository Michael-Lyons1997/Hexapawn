using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public GameObject playerPawnOne;
    public GameObject playerPawnTwo;
    public GameObject playerPawnThree;
    public GameObject pawnHighlight;
    public GameObject squareHighlight;
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
    public bool playerTurn = true;
    bool aiMoved;
    Vector3 mousePos;
    Vector2 mousePos2D;
    RaycastHit2D hit;
    // Start is called before the first frame update
    void Start()
    {
        playerPawnOne = GameObject.FindWithTag("Player-1");
        playerPawnTwo = GameObject.FindWithTag("Player-2");
        playerPawnThree = GameObject.FindWithTag("Player-3");
        pawnHighlight = GameObject.FindWithTag("pawn-Highlight");
        squareHighlight = GameObject.FindWithTag("square-Highlight");
        pawnHighlight.SetActive(false);
        squareHighlight.SetActive(false);
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
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos2D = new Vector2(mousePos.x, mousePos.y); // get the 2D co-ordinates of the mousePosition
        hit = Physics2D.Raycast(mousePos2D, Vector2.zero); // Make a ray starting at the mouse position and ending at (0,0)
        Debug.DrawLine(mousePos2D, Vector2.zero, Color.green);
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
        aiMoved = GameObject.FindWithTag("GameController").GetComponent<AIMove>().AITurn;
        if(!aiMoved)
        {
            playerTurn = true;
            if(Input.GetMouseButtonDown(0))
            {
                if(hit.rigidbody != null)
                {
                    //Debug.Log("click on " + hit.collider.gameObject.name);
                    switch(hit.rigidbody.gameObject.tag) 
                    {
                        case "Player-1":
                            pawnOneClicked = true; 
                            pawnTwoClicked = false;
                            pawnThreeClicked = false;
                            pawnHighlight.SetActive(true);
                            pawnHighlight.transform.position = playerPawnOne.transform.position;
                            if(PawnOneOnC1)
                            {
                                squareHighlight.SetActive(true);
                                squareHighlight.transform.position = b1.transform.position;
                            }
                            else if(PawnOneOnB1)
                            {
                                squareHighlight.SetActive(true);
                                squareHighlight.transform.position = a1.transform.position;
                            }
                            break;
                        case "Player-2":
                            pawnOneClicked = false; 
                            pawnTwoClicked = true;
                            pawnThreeClicked = false;
                            pawnHighlight.SetActive(true);
                            pawnHighlight.transform.position = playerPawnTwo.transform.position;
                            if(PawnTwoOnC2)
                            {
                                squareHighlight.SetActive(true);
                                squareHighlight.transform.position = b2.transform.position;
                            }
                            else if(PawnTwoOnB2)
                            {
                                squareHighlight.SetActive(true);
                                squareHighlight.transform.position = a2.transform.position;
                            }
                            break;
                        case "Player-3":
                            pawnOneClicked = false; 
                            pawnTwoClicked = false;
                            pawnThreeClicked = true;
                            pawnHighlight.SetActive(true);
                            pawnHighlight.transform.position = playerPawnThree.transform.position;
                            if(PawnThreeOnC3)
                            {
                                squareHighlight.SetActive(true);
                                squareHighlight.transform.position = b3.transform.position;
                            }
                            else if(PawnThreeOnB3)
                            {
                                squareHighlight.SetActive(true);
                                squareHighlight.transform.position = a3.transform.position;
                            }
                            break;
                        default:
                        break; 
                    }   
                }
                if (hit.collider != null) //Don't enter the check if nothing was clicked.
                {
                    //Debug.Log("click on " + hit.collider.gameObject.name);
                    switch(hit.collider.gameObject.tag) 
                    {
                        case "A1":
                            if(PawnOneOnB1 && pawnOneClicked == true)
                            {
                                playerPawnOne.transform.position = a1.transform.position;
                                pawnOneClicked = false; 
                                pawnHighlight.SetActive(false);
                                squareHighlight.SetActive(false);
                                playerTurn = false;
                            }
                            break;
                        case "A2":
                            if(PawnTwoOnB2 && pawnTwoClicked == true)
                            {
                                playerPawnTwo.transform.position = a2.transform.position;
                                pawnTwoClicked = false;
                                pawnHighlight.SetActive(false);
                                squareHighlight.SetActive(false);
                                playerTurn = false;
                            }   
                            break;
                        case "A3":
                            if(PawnThreeOnB3 && pawnThreeClicked == true)
                            {
                                playerPawnThree.transform.position = a3.transform.position;
                                pawnThreeClicked = false;
                                pawnHighlight.SetActive(false);
                                squareHighlight.SetActive(false);
                                playerTurn = false;
                            }
                            break;
                        case "B1":
                            if(PawnOneOnC1 && pawnOneClicked == true)
                            {
                                playerPawnOne.transform.position = b1.transform.position;
                                pawnOneClicked = false;
                                pawnHighlight.SetActive(false);
                                squareHighlight.SetActive(false);
                                playerTurn = false;
                            }
                            break;
                        case "B2":
                            if(PawnTwoOnC2 && pawnTwoClicked == true)
                            {
                                playerPawnTwo.transform.position = b2.transform.position;
                                pawnTwoClicked = false;
                                pawnHighlight.SetActive(false);
                                squareHighlight.SetActive(false);
                                playerTurn = false;
                            }
                            break;
                        case "B3":
                            if(PawnThreeOnC3 && pawnThreeClicked == true)
                            {
                                playerPawnThree.transform.position = b3.transform.position;
                                pawnThreeClicked = false;
                                pawnHighlight.SetActive(false);
                                squareHighlight.SetActive(false);
                                playerTurn = false;
                            }
                            break; 
                        default:
                            break;                           
                    }
                }
            }
        }
    }
}
