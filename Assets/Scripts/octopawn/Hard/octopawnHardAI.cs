using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class octopawnHardAI : MonoBehaviour
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
        ourTurn = GameObject.FindWithTag("GameController").GetComponent<octopawnHardAIMove>().AITurn;
        PawnOneOnA1 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnOneOnA1;
        PawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnOneOnB1;
        PawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnOneOnB2;
        PawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnOneOnC1;
        PawnOneOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnOneOnC2;
        PawnOneOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnOneOnC3; 
        PawnOneOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnOneOnD1;
        PawnOneOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnOneOnD2;
        PawnOneOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnOneOnD3; 
        PawnOneOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnOneOnD4; 
        PawnTwoOnA2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnTwoOnA2; 
        PawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnTwoOnB1;
        PawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnTwoOnB2;
        PawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnTwoOnB3;
        PawnTwoOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnTwoOnC1; 
        PawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnTwoOnC2; 
        PawnTwoOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnTwoOnC3; 
        PawnTwoOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnTwoOnC4;
        PawnTwoOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnTwoOnD1;
        PawnTwoOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnTwoOnD2;
        PawnTwoOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnTwoOnD3; 
        PawnTwoOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnTwoOnD4;  
        PawnThreeOnA3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnThreeOnA3;
        PawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnThreeOnB2;
        PawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnThreeOnB3;
        PawnThreeOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnThreeOnB4;
        PawnThreeOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnThreeOnC1;
        PawnThreeOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnThreeOnC2;
        PawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnThreeOnC3;
        PawnThreeOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnThreeOnC4;
        PawnThreeOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnThreeOnD1;
        PawnThreeOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnThreeOnD2;
        PawnThreeOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnThreeOnD3;
        PawnThreeOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnThreeOnD4;
        PawnFourOnA4 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnFourOnA4;
        PawnFourOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnFourOnB3;
        PawnFourOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnFourOnB4;
        PawnFourOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnFourOnC2;
        PawnFourOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnFourOnC3;
        PawnFourOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnFourOnC4;
        PawnFourOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnFourOnD1;
        PawnFourOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnFourOnD2;
        PawnFourOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnFourOnD3;
        PawnFourOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().AIPawnFourOnD4;
        otherPawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnOneOnB1;
        otherPawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnOneOnB2;
        otherPawnOneOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnOneOnB3;
        otherPawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnOneOnC1;
        otherPawnOneOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnOneOnC2;
        otherPawnOneOnD1 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnOneOnD1;
        otherPawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnTwoOnB1;
        otherPawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnTwoOnB2;
        otherPawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnTwoOnB3;
        otherPawnTwoOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnTwoOnB4;
        otherPawnTwoOnC1 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnTwoOnC1;
        otherPawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnTwoOnC2;
        otherPawnTwoOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnTwoOnC3;
        otherPawnTwoOnD2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnTwoOnD2;
        otherPawnThreeOnB1 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnThreeOnB1;
        otherPawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnThreeOnB2;
        otherPawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnThreeOnB3;
        otherPawnThreeOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnThreeOnB4;
        otherPawnThreeOnC2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnThreeOnC2;
        otherPawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnThreeOnC3;
        otherPawnThreeOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnThreeOnC4;
        otherPawnThreeOnD3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnThreeOnD3;
        otherPawnFourOnB2 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnFourOnB2;
        otherPawnFourOnB3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnFourOnB3;
        otherPawnFourOnB4 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnFourOnB4;
        otherPawnFourOnC3 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnFourOnC3;
        otherPawnFourOnC4 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnFourOnC4;
        otherPawnFourOnD4 = GameObject.FindWithTag("GameController").GetComponent<octopawnHardBoardState>().playerPawnFourOnD4;
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