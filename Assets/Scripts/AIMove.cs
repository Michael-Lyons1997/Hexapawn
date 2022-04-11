using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{
    public GameObject AIPawnOne;
    public GameObject AIPawnTwo;
    public GameObject AIPawnThree;
    public GameObject a1;
    public GameObject a2;
    public GameObject a3;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
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
    bool playerMoved;
    bool movePawnOne;
    bool movePawnTwo;
    bool movePawnThree;
    public bool AITurn;
    // Start is called before the first frame update
    void Start()
    {
        AIPawnOne = GameObject.FindWithTag("AI-Pawn-1");
        AIPawnTwo = GameObject.FindWithTag("AI-Pawn-2");
        AIPawnThree = GameObject.FindWithTag("AI-Pawn-3");
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
    }

    // Update is called once per frame
    void Update()
    {
        PawnOneOnA1 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnOneOnA1;
        PawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnOneOnB1;
        PawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnOneOnB2;
        PawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnOneOnC1;
        PawnOneOnC2 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnOneOnC2;
        PawnOneOnC3 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnOneOnC3; 
        PawnTwoOnA2 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnTwoOnA2; 
        PawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnTwoOnB1;
        PawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnTwoOnB2;
        PawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnTwoOnB3;
        PawnTwoOnC1 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnTwoOnC1; 
        PawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnTwoOnC2; 
        PawnTwoOnC3 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnTwoOnC3; 
        PawnThreeOnA3 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnThreeOnA3;
        PawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnThreeOnB2;
        PawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnThreeOnB3;
        PawnThreeOnC1 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnThreeOnC1;
        PawnThreeOnC2 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnThreeOnC2;
        PawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<boardState>().AIPawnThreeOnC3;
        movePawnOne = GameObject.FindWithTag("GameController").GetComponent<AI>().pawnOneMove;
        movePawnTwo = GameObject.FindWithTag("GameController").GetComponent<AI>().pawnTwoMove;
        movePawnThree = GameObject.FindWithTag("GameController").GetComponent<AI>().pawnThreeMove;
        playerMoved = GameObject.FindWithTag("GameController").GetComponent<playerMove>().playerTurn;
        if(!playerMoved)
        {
            AITurn = true;
            if(movePawnOne)
            {
                if(PawnOneOnA1)
                {
                    AIPawnOne.transform.position = b1.transform.position;
                }
                else
                {
                    AIPawnOne.transform.position = c1.transform.position;
                }
                AITurn = false;
            }
            if(movePawnTwo)
            {

                if(PawnTwoOnA2)
                {
                    AIPawnTwo.transform.position = b2.transform.position;
                }
                else
                {
                    AIPawnTwo.transform.position = c2.transform.position;
                }
                AITurn = false;
            }
            if(movePawnThree)
            {
                if(PawnThreeOnA3)
                {
                    AIPawnThree.transform.position = b3.transform.position;
                }
                else
                {
                    AIPawnThree.transform.position = c3.transform.position;
                }
                AITurn = false;
            }
        
        }
    }
}
