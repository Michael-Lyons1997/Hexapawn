using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hardAI : MonoBehaviour
{
    int whichPawnToMove = 0;
    public bool pawnOneMove;
    public bool pawnTwoMove;
    public bool pawnThreeMove;
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
        PawnOneOnA1 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().AIPawnOneOnA1;
        PawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().AIPawnOneOnB1;
        PawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().AIPawnOneOnB2;
        PawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().AIPawnOneOnC1;
        PawnOneOnC2 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().AIPawnOneOnC2;
        PawnOneOnC3 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().AIPawnOneOnC3; 
        PawnTwoOnA2 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().AIPawnTwoOnA2; 
        PawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().AIPawnTwoOnB1;
        PawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().AIPawnTwoOnB2;
        PawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().AIPawnTwoOnB3;
        PawnTwoOnC1 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().AIPawnTwoOnC1; 
        PawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().AIPawnTwoOnC2; 
        PawnTwoOnC3 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().AIPawnTwoOnC3; 
        PawnThreeOnA3 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().AIPawnThreeOnA3;
        PawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().AIPawnThreeOnB2;
        PawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().AIPawnThreeOnB3;
        PawnThreeOnC1 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().AIPawnThreeOnC1;
        PawnThreeOnC2 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().AIPawnThreeOnC2;
        PawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().AIPawnThreeOnC3;
        otherPawnOneOnB1 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().playerPawnOneOnB1;
        otherPawnOneOnB2 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().playerPawnOneOnB2;
        otherPawnOneOnC1 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().playerPawnOneOnC1;
        otherPawnTwoOnB1 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().playerPawnTwoOnB1;
        otherPawnTwoOnB2 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().playerPawnTwoOnB2;
        otherPawnTwoOnB3 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().playerPawnTwoOnB3;
        otherPawnTwoOnC2 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().playerPawnTwoOnC2;
        otherPawnThreeOnB2 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().playerPawnThreeOnB2;
        otherPawnThreeOnB3 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().playerPawnThreeOnB3;
        otherPawnThreeOnC3 = GameObject.FindWithTag("GameController").GetComponent<hardBoardState>().playerPawnThreeOnC3;
        if(PawnOneOnA1)
        {
            if(otherPawnOneOnB2)
            {
                pawnOneMove = true;
                pawnTwoMove = false;
                pawnThreeMove = false;
            }
            else if(otherPawnTwoOnB2)
            {
                pawnOneMove = true;
                pawnTwoMove = false;
                pawnThreeMove = false;
            }
            else
            {
                whichPawnToMove = Random.Range(1, 4);
                switch(whichPawnToMove)
                {
                    case 1:
                        pawnOneMove = true;
                        pawnTwoMove = false;
                        pawnThreeMove = false;
                        break;
                    case 2:
                        pawnOneMove = false;
                        pawnTwoMove = true;
                        pawnThreeMove = false;
                        break;
                    case 3: 
                        pawnOneMove = false;
                        pawnTwoMove = false;
                        pawnThreeMove = true;
                        break;
                    default:
                        break;
                }
            }
        }
        else if(PawnOneOnB1)
        {
            if(otherPawnTwoOnC2)
            {
                pawnOneMove = true;
                pawnTwoMove = false;
                pawnThreeMove = false;
            }
            else
            {
                whichPawnToMove = Random.Range(1, 4);
                switch(whichPawnToMove)
                {
                    case 1:
                        pawnOneMove = true;
                        pawnTwoMove = false;
                        pawnThreeMove = false;
                        break;
                    case 2:
                        pawnOneMove = false;
                        pawnTwoMove = true;
                        pawnThreeMove = false;
                        break;
                    case 3: 
                        pawnOneMove = false;
                        pawnTwoMove = false;
                        pawnThreeMove = true;
                        break;
                    default:
                        break;
                }
            }
        }
        else if(PawnOneOnB2)
        {
            if(otherPawnOneOnC1)
            {
                pawnOneMove = true;
                pawnTwoMove = false;
                pawnThreeMove = false;
            }
            else if(otherPawnThreeOnC3)
            {
                pawnOneMove = true;
                pawnTwoMove = false;
                pawnThreeMove = false;
            }
            else
            {
                whichPawnToMove = Random.Range(1, 4);
                switch(whichPawnToMove)
                {
                    case 1:
                        pawnOneMove = true;
                        pawnTwoMove = false;
                        pawnThreeMove = false;
                        break;
                    case 2:
                        pawnOneMove = false;
                        pawnTwoMove = true;
                        pawnThreeMove = false;
                        break;
                    case 3: 
                        pawnOneMove = false;
                        pawnTwoMove = false;
                        pawnThreeMove = true;
                        break;
                    default:
                        break;
                }
            }
        }

        if(PawnTwoOnA2)
        {
            if(otherPawnOneOnB1)
            {
                pawnOneMove = false;
                pawnTwoMove = true;
                pawnThreeMove = false;
            }
            else if(otherPawnTwoOnB1)
            {
                pawnOneMove = false;
                pawnTwoMove = true;
                pawnThreeMove = false;
            }
            else if(otherPawnTwoOnB3)
            {
                pawnOneMove = false;
                pawnTwoMove = true;
                pawnThreeMove = false;
            }
            else if(otherPawnThreeOnB3)
            {
                pawnOneMove = false;
                pawnTwoMove = true;
                pawnThreeMove = false;
            }
            else
            {
                whichPawnToMove = Random.Range(1, 4);
                switch(whichPawnToMove)
                {
                    case 1:
                        pawnOneMove = true;
                        pawnTwoMove = false;
                        pawnThreeMove = false;
                        break;
                    case 2:
                        pawnOneMove = false;
                        pawnTwoMove = true;
                        pawnThreeMove = false;
                        break;
                    case 3: 
                        pawnOneMove = false;
                        pawnTwoMove = false;
                        pawnThreeMove = true;
                        break;
                    default:
                        break;
                }
            }
        }
        else if(PawnTwoOnB2)
        {
            if(otherPawnOneOnC1)
            {
                pawnOneMove = false;
                pawnTwoMove = true;
                pawnThreeMove = false;
            }
            else if(otherPawnThreeOnC3)
            {
                pawnOneMove = false;
                pawnTwoMove = true;
                pawnThreeMove = false;
            }
            else
            {
                whichPawnToMove = Random.Range(1, 4);
                switch(whichPawnToMove)
                {
                    case 1:
                        pawnOneMove = true;
                        pawnTwoMove = false;
                        pawnThreeMove = false;
                        break;
                    case 2:
                        pawnOneMove = false;
                        pawnTwoMove = true;
                        pawnThreeMove = false;
                        break;
                    case 3: 
                        pawnOneMove = false;
                        pawnTwoMove = false;
                        pawnThreeMove = true;
                        break;
                    default:
                        break;
                }
            }
        }
        else if(PawnTwoOnB1)
        {
            if(otherPawnTwoOnC2)
            {
                pawnOneMove = false;
                pawnTwoMove = true;
                pawnThreeMove = false;
            }
            else
            {
                whichPawnToMove = Random.Range(1, 4);
                switch(whichPawnToMove)
                {
                    case 1:
                        pawnOneMove = true;
                        pawnTwoMove = false;
                        pawnThreeMove = false;
                        break;
                    case 2:
                        pawnOneMove = false;
                        pawnTwoMove = true;
                        pawnThreeMove = false;
                        break;
                    case 3: 
                        pawnOneMove = false;
                        pawnTwoMove = false;
                        pawnThreeMove = true;
                        break;
                    default:
                        break;
                }
            }
        }
        else if(PawnTwoOnB3)
        { 
            if(otherPawnTwoOnC2)
            {
                pawnOneMove = false;
                pawnTwoMove = true;
                pawnThreeMove = false;
            }
            else
            {
                whichPawnToMove = Random.Range(1, 4);
                switch(whichPawnToMove)
                {
                    case 1:
                        pawnOneMove = true;
                        pawnTwoMove = false;
                        pawnThreeMove = false;
                        break;
                    case 2:
                        pawnOneMove = false;
                        pawnTwoMove = true;
                        pawnThreeMove = false;
                        break;
                    case 3: 
                        pawnOneMove = false;
                        pawnTwoMove = false;
                        pawnThreeMove = true;
                        break;
                    default:
                        break;
                }
            }
        }

        if(PawnThreeOnA3)
        {
            if(otherPawnOneOnB2)
            {
                pawnOneMove = false;
                pawnTwoMove = false;
                pawnThreeMove = true;
            }
            else if(otherPawnTwoOnB2)
            {
                pawnOneMove = false;
                pawnTwoMove = false;
                pawnThreeMove = true;
            }
            else
            {
                whichPawnToMove = Random.Range(1, 4);
                switch(whichPawnToMove)
                {
                    case 1:
                        pawnOneMove = true;
                        pawnTwoMove = false;
                        pawnThreeMove = false;
                        break;
                    case 2:
                        pawnOneMove = false;
                        pawnTwoMove = true;
                        pawnThreeMove = false;
                        break;
                    case 3: 
                        pawnOneMove = false;
                        pawnTwoMove = false;
                        pawnThreeMove = true;
                        break;
                    default:
                        break;
                }
            }
        }
        else if(PawnThreeOnB3)
        {
            if(otherPawnTwoOnC2)
            {
                pawnOneMove = false;
                pawnTwoMove = false;
                pawnThreeMove = true;
            }
            else
            {
                whichPawnToMove = Random.Range(1, 4);
                switch(whichPawnToMove)
                {
                    case 1:
                        pawnOneMove = true;
                        pawnTwoMove = false;
                        pawnThreeMove = false;
                        break;
                    case 2:
                        pawnOneMove = false;
                        pawnTwoMove = true;
                        pawnThreeMove = false;
                        break;
                    case 3: 
                        pawnOneMove = false;
                        pawnTwoMove = false;
                        pawnThreeMove = true;
                        break;
                    default:
                        break;
                }
            }
        }
        else if(PawnThreeOnB2)
        {
            if(otherPawnOneOnC1)
            {
                pawnOneMove = false;
                pawnTwoMove = false;
                pawnThreeMove = true;
            }
            else if(otherPawnThreeOnC3)
            {
                pawnOneMove = false;
                pawnTwoMove = false;
                pawnThreeMove = true;
            }
            else
            {
                whichPawnToMove = Random.Range(1, 4);
                switch(whichPawnToMove)
                {
                    case 1:
                        pawnOneMove = true;
                        pawnTwoMove = false;
                        pawnThreeMove = false;
                        break;
                    case 2:
                        pawnOneMove = false;
                        pawnTwoMove = true;
                        pawnThreeMove = false;
                        break;
                    case 3: 
                        pawnOneMove = false;
                        pawnTwoMove = false;
                        pawnThreeMove = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
