using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class octopawnInsaneAI : MonoBehaviour
{
    public bool pawnOneMove;
    public bool pawnTwoMove;
    public bool pawnThreeMove;
    public bool pawnFourMove;
    bool ourTurn;
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
    // Start is called before the first frame update
    void Start()
    {
        pawnOneMove = false;
        pawnTwoMove = false;
        pawnThreeMove = false;
        pawnFourMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        ourTurn = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneAIMove>().AITurn;
        PawnOneOnA1 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnOneOnA1;
        PawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnOneOnB1;
        PawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnOneOnB2;
        PawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnOneOnC1;
        PawnOneOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnOneOnC2;
        PawnOneOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnOneOnC3; 
        PawnOneOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnOneOnD1;
        PawnOneOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnOneOnD2;
        PawnOneOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnOneOnD3; 
        PawnOneOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnOneOnD4; 
        PawnTwoOnA2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnTwoOnA2; 
        PawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnTwoOnB1;
        PawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnTwoOnB2;
        PawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnTwoOnB3;
        PawnTwoOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnTwoOnC1; 
        PawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnTwoOnC2; 
        PawnTwoOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnTwoOnC3; 
        PawnTwoOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnTwoOnC4;
        PawnTwoOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnTwoOnD1;
        PawnTwoOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnTwoOnD2;
        PawnTwoOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnTwoOnD3; 
        PawnTwoOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnTwoOnD4;  
        PawnThreeOnA3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnThreeOnA3;
        PawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnThreeOnB2;
        PawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnThreeOnB3;
        PawnThreeOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnThreeOnB4;
        PawnThreeOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnThreeOnC1;
        PawnThreeOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnThreeOnC2;
        PawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnThreeOnC3;
        PawnThreeOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnThreeOnC4;
        PawnThreeOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnThreeOnD1;
        PawnThreeOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnThreeOnD2;
        PawnThreeOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnThreeOnD3;
        PawnThreeOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnThreeOnD4;
        PawnFourOnA4 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnFourOnA4;
        PawnFourOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnFourOnB3;
        PawnFourOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnFourOnB4;
        PawnFourOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnFourOnC2;
        PawnFourOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnFourOnC3;
        PawnFourOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnFourOnC4;
        PawnFourOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnFourOnD1;
        PawnFourOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnFourOnD2;
        PawnFourOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnFourOnD3;
        PawnFourOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().AIPawnFourOnD4;
        otherPawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnOneOnB1;
        otherPawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnOneOnB2;
        otherPawnOneOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnOneOnB3;
        otherPawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnOneOnC1;
        otherPawnOneOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnOneOnC2;
        otherPawnOneOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnOneOnD1;
        otherPawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnTwoOnB1;
        otherPawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnTwoOnB2;
        otherPawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnTwoOnB3;
        otherPawnTwoOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnTwoOnB4;
        otherPawnTwoOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnTwoOnC1;
        otherPawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnTwoOnC2;
        otherPawnTwoOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnTwoOnC3;
        otherPawnTwoOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnTwoOnD2;
        otherPawnThreeOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnThreeOnB1;
        otherPawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnThreeOnB2;
        otherPawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnThreeOnB3;
        otherPawnThreeOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnThreeOnB4;
        otherPawnThreeOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnThreeOnC2;
        otherPawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnThreeOnC3;
        otherPawnThreeOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnThreeOnC4;
        otherPawnThreeOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnThreeOnD3;
        otherPawnFourOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnFourOnB2;
        otherPawnFourOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnFourOnB3;
        otherPawnFourOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnFourOnB4;
        otherPawnFourOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnFourOnC3;
        otherPawnFourOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnFourOnC4;
        otherPawnFourOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnInsaneBoardState>().playerPawnFourOnD4;
        if(ourTurn)
        {
            StartCoroutine(moveAI());
        }
    }

    public IEnumerator moveAI()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        if((PawnOneOnA1 && otherPawnOneOnB2) || (PawnOneOnA1 && otherPawnTwoOnB2) || (PawnOneOnA1 && otherPawnThreeOnB2) || (PawnOneOnA1 && otherPawnFourOnB2) 
            || (PawnOneOnB1 && otherPawnOneOnC2) || (PawnOneOnB1 && otherPawnTwoOnC2) || (PawnOneOnB1 && otherPawnThreeOnC2)
            || (PawnOneOnB2 && otherPawnOneOnC1) || (PawnOneOnB2 && otherPawnTwoOnC1) || (PawnOneOnB2 && otherPawnTwoOnC3) || (PawnOneOnB2 && otherPawnFourOnC3)
            || (PawnOneOnC1 && otherPawnTwoOnD2) || (PawnOneOnC2 && otherPawnOneOnD1) || (PawnOneOnC2 && otherPawnThreeOnD3) || (PawnOneOnC3 && otherPawnTwoOnD2) || (PawnOneOnC3 && otherPawnFourOnD4))
        {
            pawnOneMove = true;
            pawnTwoMove = false;
            pawnThreeMove = false;
            pawnFourMove = false;
        }
        else if(((PawnOneOnA1 && !otherPawnOneOnB1) && (PawnOneOnA1 && !otherPawnTwoOnB1) && (PawnOneOnA1 && !otherPawnThreeOnB1))    
                || ((PawnOneOnB1 && !otherPawnOneOnC1) && (PawnOneOnB1 && !otherPawnTwoOnC1))
                || ((PawnOneOnB2 && !otherPawnOneOnC2) && (PawnOneOnB2 && !otherPawnTwoOnC2) && (PawnOneOnB2 && !otherPawnThreeOnC2))
                || ((PawnOneOnC1 && !otherPawnOneOnD1) && (PawnOneOnC2 && !otherPawnTwoOnD2) && (PawnOneOnC3 && !otherPawnThreeOnD3)))
        {
            pawnOneMove = true;
            pawnTwoMove = false;
            pawnThreeMove = false;
            pawnFourMove = false;
        }
        if((PawnTwoOnA2 && otherPawnOneOnB1) || (PawnTwoOnA2 && otherPawnTwoOnB1) || (PawnTwoOnA2 && otherPawnThreeOnB1) || (PawnTwoOnA2 && otherPawnTwoOnB3) || (PawnTwoOnA2 && otherPawnThreeOnB3) || (PawnTwoOnA2 && otherPawnFourOnB3)
            || (PawnTwoOnB1 && otherPawnOneOnC2) || (PawnTwoOnB1 && otherPawnTwoOnC2) || (PawnTwoOnB1 && otherPawnThreeOnC2)
            || (PawnTwoOnB2 && otherPawnOneOnC1) || (PawnTwoOnB2 && otherPawnTwoOnC1) || (PawnTwoOnB2 && otherPawnTwoOnC3) || (PawnTwoOnB2 && otherPawnThreeOnC3) || (PawnTwoOnB2 && otherPawnFourOnC3)
            || (PawnTwoOnB3 && otherPawnOneOnC2) || (PawnTwoOnB3 && otherPawnTwoOnC2) || (PawnTwoOnB3 && otherPawnThreeOnC2) || (PawnTwoOnB3 && otherPawnThreeOnC4) || (PawnTwoOnB3 && otherPawnFourOnC4)
            || (PawnTwoOnC1 && otherPawnTwoOnD2) || (PawnTwoOnC2 && otherPawnOneOnC1) || (PawnTwoOnC2 && otherPawnThreeOnC3) || (PawnTwoOnC3 && otherPawnTwoOnD2) || (PawnTwoOnC3 && otherPawnFourOnD4) || (PawnTwoOnC4 && otherPawnThreeOnD3))
        {
            pawnOneMove = false;
            pawnTwoMove = true;
            pawnThreeMove = false;
            pawnFourMove = false;
        }
        else if(((PawnTwoOnA2 && !otherPawnOneOnB2) && (PawnTwoOnA2 && !otherPawnTwoOnB2) && (PawnTwoOnA2 && !otherPawnThreeOnB2) && (PawnTwoOnA2 && !otherPawnFourOnB2))
            || ((PawnTwoOnB1 && !otherPawnOneOnC1) && (PawnTwoOnB1 && !otherPawnTwoOnC1))
            || ((PawnTwoOnB2 && !otherPawnOneOnC2) && (PawnTwoOnB2 && !otherPawnTwoOnC2) && (PawnTwoOnB2 && !otherPawnThreeOnC2))
            || ((PawnTwoOnB3 && !otherPawnTwoOnC3) && (PawnTwoOnB3 && !otherPawnThreeOnC3) && (PawnTwoOnB3 && !otherPawnFourOnC3))
            || ((PawnTwoOnC1 && !otherPawnOneOnD1) && (PawnTwoOnC2 && !otherPawnTwoOnD2) && (PawnTwoOnC3 && !otherPawnThreeOnD3) && (PawnTwoOnC4 && !otherPawnFourOnD4)))
        {
            pawnOneMove = false;
            pawnTwoMove = true;
            pawnThreeMove = false;
            pawnFourMove = false;
        }
        if((PawnThreeOnA3 && otherPawnOneOnB2) || (PawnThreeOnA3 && otherPawnTwoOnB2) || (PawnThreeOnA3 && otherPawnThreeOnB2) || (PawnThreeOnA3 && otherPawnTwoOnB4) || (PawnThreeOnA3 && otherPawnThreeOnB4) || (PawnThreeOnA3 && otherPawnFourOnB4)
            || (PawnThreeOnB2 && otherPawnOneOnC1) || (PawnThreeOnB2 && otherPawnTwoOnC1)|| (PawnThreeOnB2 && otherPawnTwoOnC3) || (PawnThreeOnB2 && otherPawnThreeOnC3) || (PawnThreeOnB2 && otherPawnFourOnC3)
            || (PawnThreeOnB3 && otherPawnOneOnC2) || (PawnThreeOnB3 && otherPawnTwoOnC2) || (PawnThreeOnB3 && otherPawnThreeOnC2) || (PawnThreeOnB3 && otherPawnThreeOnC4) || (PawnThreeOnB3 && otherPawnFourOnC4)
            || (PawnThreeOnB4 && otherPawnTwoOnC3) || (PawnThreeOnB4 && otherPawnThreeOnC3) || (PawnThreeOnB4 && otherPawnFourOnC3)
            || (PawnTwoOnC1 && otherPawnTwoOnD2) || (PawnTwoOnC2 && otherPawnOneOnD1) || (PawnTwoOnC2 && otherPawnThreeOnD3) || (PawnTwoOnC3 && otherPawnTwoOnD2) || (PawnTwoOnC3 && otherPawnFourOnD4) || (PawnTwoOnC4 && otherPawnThreeOnD3))
        {
            pawnOneMove = false;
            pawnTwoMove = false;
            pawnThreeMove = true;
            pawnFourMove = false;
        }
        else if(((PawnThreeOnA3 && !otherPawnOneOnB3) && (PawnThreeOnA3 && !otherPawnTwoOnB3) && (PawnThreeOnA3 && !otherPawnThreeOnB3) && (PawnThreeOnA3 && !otherPawnTwoOnB3))
            || ((PawnThreeOnB2 && !otherPawnOneOnC2) && (PawnThreeOnB2 && !otherPawnTwoOnC2) && (PawnThreeOnB2 && !otherPawnThreeOnC2))
            || ((PawnThreeOnB3 && !otherPawnTwoOnC3) && (PawnThreeOnB3 && !otherPawnThreeOnC3) && (PawnThreeOnB3 && !otherPawnFourOnC3))
            || ((PawnThreeOnB4 && !otherPawnThreeOnC4) && (PawnThreeOnB4 && !otherPawnFourOnC4))
            || ((PawnTwoOnC1 && !otherPawnOneOnD1) && (PawnTwoOnC2 && !otherPawnTwoOnD2) && (PawnTwoOnC3 && !otherPawnThreeOnD3) && (PawnTwoOnC4 && !otherPawnFourOnD4)))
        {
            pawnOneMove = false;
            pawnTwoMove = false;
            pawnThreeMove = true;
            pawnFourMove = false;
        }
        if((PawnFourOnA4 && otherPawnOneOnB3) || (PawnFourOnA4 && otherPawnTwoOnB3) || (PawnFourOnA4 && otherPawnThreeOnB3) || (PawnFourOnA4 && otherPawnFourOnB3) 
            || (PawnFourOnB3 && otherPawnOneOnC2) || (PawnFourOnB3 && otherPawnTwoOnC2) || (PawnFourOnB3 && otherPawnThreeOnC2) || (PawnFourOnB3 && otherPawnThreeOnC4) || (PawnFourOnB3 && otherPawnFourOnC4)
            || (PawnFourOnB4 && otherPawnTwoOnC3) || (PawnFourOnB4 && otherPawnThreeOnC3) || (PawnFourOnB4 && otherPawnFourOnC3)
            || (PawnFourOnC2 && otherPawnOneOnD1) || (PawnFourOnC2 && otherPawnThreeOnD3) || (PawnFourOnC3 && otherPawnTwoOnD2) || (PawnFourOnC3 && otherPawnFourOnD4) || (PawnFourOnC4 && otherPawnThreeOnD3))
        {
            pawnOneMove = false;
            pawnTwoMove = false;
            pawnThreeMove = false;
            pawnFourMove = true;
        }
        else if(((PawnFourOnA4 && !otherPawnTwoOnB4) && (PawnFourOnA4 && !otherPawnThreeOnB4) && (PawnFourOnA4 && !otherPawnFourOnB4))
            || ((PawnFourOnB3 && !otherPawnTwoOnC3) && (PawnFourOnB3 && !otherPawnThreeOnC3) && (PawnFourOnB3 && !otherPawnFourOnC3))
            || ((PawnFourOnB4 && !otherPawnThreeOnC4) && (PawnFourOnB4 && !otherPawnFourOnC4))
            || ((PawnFourOnC2 && !otherPawnTwoOnD2) && (PawnFourOnC3 && !otherPawnThreeOnD3) && (PawnFourOnC4 && !otherPawnFourOnD4)))
        {
            pawnOneMove = false;
            pawnTwoMove = false;
            pawnThreeMove = false;
            pawnFourMove = true;
        }
    }
}