using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mediumAI : MonoBehaviour
{
    int whichPawnToMove = 0;
    public bool pawnOneMove;
    public bool pawnTwoMove;
    public bool pawnThreeMove;
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
