using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insaneAI : MonoBehaviour
{
    public bool pawnOneMove;
    public bool pawnTwoMove;
    public bool pawnThreeMove;
    bool ourTurn;
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
    // Start is called before the first frame update
    void Start()
    {
        pawnOneMove = false;
        pawnTwoMove = false;
        pawnThreeMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        ourTurn = GameObject.FindWithTag("GameController").GetComponent<insaneAIMove>().AITurn;
        PawnOneOnA1 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnOneOnA1;
        PawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnOneOnB1;
        PawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnOneOnB2;
        PawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnOneOnC1;
        PawnOneOnC2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnOneOnC2;
        PawnOneOnC3 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnOneOnC3; 
        PawnTwoOnA2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnTwoOnA2; 
        PawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnTwoOnB1;
        PawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnTwoOnB2;
        PawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnTwoOnB3;
        PawnTwoOnC1 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnTwoOnC1; 
        PawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnTwoOnC2; 
        PawnTwoOnC3 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnTwoOnC3; 
        PawnThreeOnA3 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnThreeOnA3;
        PawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnThreeOnB2;
        PawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnThreeOnB3;
        PawnThreeOnC1 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnThreeOnC1;
        PawnThreeOnC2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnThreeOnC2;
        PawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().AIPawnThreeOnC3;
        otherPawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnOneOnB1;
        otherPawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnOneOnB2;
        otherPawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnOneOnC1;
        otherPawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnTwoOnB1;
        otherPawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnTwoOnB2;
        otherPawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnTwoOnB3;
        otherPawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnTwoOnC2;
        otherPawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnThreeOnB2;
        otherPawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnThreeOnB3;
        otherPawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<insaneBoardState>().playerPawnThreeOnC3;
         if(ourTurn)
        {
            StartCoroutine(moveAI());
        }
    }

    public IEnumerator moveAI()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        if((PawnOneOnA1 && otherPawnOneOnB2) || (PawnOneOnA1 && otherPawnTwoOnB2) || (PawnOneOnA1 && otherPawnThreeOnB2)
            || (PawnOneOnB1 && otherPawnTwoOnC2) || (PawnOneOnB2 && otherPawnOneOnC1) || (PawnOneOnB2 && otherPawnThreeOnC3))
        {
            pawnOneMove = true;
            pawnTwoMove = false;
            pawnThreeMove = false;
        }
        else if(((PawnOneOnA1 && !otherPawnOneOnB1) && (PawnOneOnA1 && !otherPawnTwoOnB1))
                || ((PawnOneOnB1 && !otherPawnOneOnC1) && (PawnOneOnB2 && !otherPawnTwoOnC2)))
        {
            pawnOneMove = true;
            pawnTwoMove = false;
            pawnThreeMove = false;
        }
        if((PawnTwoOnA2 && otherPawnOneOnB1) || (PawnTwoOnA2 && otherPawnTwoOnB1) || (PawnTwoOnA2 && otherPawnTwoOnB3)|| (PawnTwoOnA2 && otherPawnThreeOnB3)
            || (PawnTwoOnB1 && otherPawnTwoOnC2) || (PawnTwoOnB2 && otherPawnOneOnC1) || (PawnTwoOnB2 && otherPawnThreeOnC3) || (PawnTwoOnB3 && otherPawnTwoOnC2))
        {
            pawnOneMove = false;
            pawnTwoMove = true;
            pawnThreeMove = false;
        }
        else if(((PawnTwoOnA2 && !otherPawnOneOnB2) && (PawnTwoOnA2 && !otherPawnTwoOnB2) && (PawnTwoOnA2 && !otherPawnThreeOnB2))
                || ((PawnTwoOnB1 && !otherPawnOneOnC1) && (PawnTwoOnB2 && !otherPawnTwoOnC2) && (PawnTwoOnB3 && !otherPawnThreeOnC3)))
        {
            pawnOneMove = false;
            pawnTwoMove = true;
            pawnThreeMove = false;
        }
        if((PawnThreeOnA3 && otherPawnOneOnB2) || (PawnThreeOnA3 && otherPawnTwoOnB2) || (PawnThreeOnA3 && otherPawnThreeOnB2) 
            || (PawnThreeOnB2 && otherPawnOneOnC1) || (PawnThreeOnB2 && otherPawnThreeOnC3) || (PawnThreeOnB3 && otherPawnTwoOnC2))
        {
            pawnOneMove = false;
            pawnTwoMove = false;
            pawnThreeMove = true;
        }
        else if(((PawnThreeOnA3 && !otherPawnThreeOnB3) && (PawnThreeOnA3 && !otherPawnTwoOnB3))
                || ((PawnThreeOnB2 && !otherPawnTwoOnC2) && (PawnThreeOnB3 && !otherPawnThreeOnC3)))
        {
            pawnOneMove = false;
            pawnTwoMove = false;
            pawnThreeMove = true;
        }
    }
}
