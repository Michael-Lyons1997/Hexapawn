using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class octopawnMediumAI : MonoBehaviour
{
    int whichPawnToMove = 0;
    public bool pawnOneMove;
    public bool pawnTwoMove;
    public bool pawnThreeMove;
    public bool pawnFourMove;
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
        whichPawnToMove = Random.Range(1, 5);
        switch(whichPawnToMove)
        {
            case 1:
                pawnOneMove = true;
                pawnTwoMove = false;
                pawnThreeMove = false;
                pawnFourMove = false;
                break;
            case 2:
                pawnOneMove = false;
                pawnTwoMove = true;
                pawnThreeMove = false;
                pawnFourMove = false;
                break;
            case 3: 
                pawnOneMove = false;
                pawnTwoMove = false;
                pawnThreeMove = true;
                pawnFourMove = false;
                break;
            case 4: 
                pawnOneMove = false;
                pawnTwoMove = false;
                pawnThreeMove = false;
                pawnFourMove = true;
                break;
            default:
                break;
        }
    }
}