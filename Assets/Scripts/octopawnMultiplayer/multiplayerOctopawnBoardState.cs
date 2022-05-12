using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class multiplayerOctopawnBoardState : MonoBehaviour
{
    public GameObject playerOnePawnOne;
    public GameObject playerOnePawnTwo;
    public GameObject playerOnePawnThree;
    public GameObject playerOnePawnFour;
    public GameObject playerTwoPawnOne;
    public GameObject playerTwoPawnTwo;
    public GameObject playerTwoPawnThree;
    public GameObject playerTwoPawnFour;
    public Collider2D playerOnePawnOneCollider;
    public Collider2D playerOnePawnTwoCollider;
    public Collider2D playerOnePawnThreeCollider;
    public Collider2D playerOnePawnFourCollider;
    public Collider2D playerTwoPawnOneCollider;
    public Collider2D playerTwoPawnTwoCollider;
    public Collider2D playerTwoPawnThreeCollider;
    public Collider2D playerTwoPawnFourCollider;
    public Collider2D a1Collider;
    public Collider2D a2Collider;
    public Collider2D a3Collider;
    public Collider2D a4Collider;
    public Collider2D b1Collider;
    public Collider2D b2Collider;
    public Collider2D b3Collider;
    public Collider2D b4Collider;
    public Collider2D c1Collider;
    public Collider2D c2Collider;
    public Collider2D c3Collider;
    public Collider2D c4Collider;
    public Collider2D d1Collider;
    public Collider2D d2Collider;
    public Collider2D d3Collider;
    public Collider2D d4Collider;
    public bool playerOnePawnOneOnA1;
    public bool playerOnePawnOneOnA2;
    public bool playerOnePawnOneOnA3;
    public bool playerOnePawnOneOnA4;
    public bool playerOnePawnOneOnB1;
    public bool playerOnePawnOneOnB2;
    public bool playerOnePawnOneOnB3;
    public bool playerOnePawnOneOnC1;
    public bool playerOnePawnOneOnC2;
    public bool playerOnePawnOneOnD1;
    public bool playerOnePawnTwoOnA1;
    public bool playerOnePawnTwoOnA2;
    public bool playerOnePawnTwoOnA3;
    public bool playerOnePawnTwoOnA4;
    public bool playerOnePawnTwoOnB1;
    public bool playerOnePawnTwoOnB2;
    public bool playerOnePawnTwoOnB3;
    public bool playerOnePawnTwoOnB4;
    public bool playerOnePawnTwoOnC1;
    public bool playerOnePawnTwoOnC2;
    public bool playerOnePawnTwoOnC3;
    public bool playerOnePawnTwoOnD2;
    public bool playerOnePawnThreeOnA1;
    public bool playerOnePawnThreeOnA2;
    public bool playerOnePawnThreeOnA3;
    public bool playerOnePawnThreeOnA4;
    public bool playerOnePawnThreeOnB1;
    public bool playerOnePawnThreeOnB2;
    public bool playerOnePawnThreeOnB3;
    public bool playerOnePawnThreeOnB4;
    public bool playerOnePawnThreeOnC2;
    public bool playerOnePawnThreeOnC3;
    public bool playerOnePawnThreeOnC4;
    public bool playerOnePawnThreeOnD3;
    public bool playerOnePawnFourOnA1;
    public bool playerOnePawnFourOnA2;
    public bool playerOnePawnFourOnA3;
    public bool playerOnePawnFourOnA4;
    public bool playerOnePawnFourOnB2;
    public bool playerOnePawnFourOnB3;
    public bool playerOnePawnFourOnB4;
    public bool playerOnePawnFourOnC3;
    public bool playerOnePawnFourOnC4;
    public bool playerOnePawnFourOnD4;
    public bool playerTwoPawnOneOnA1;
    public bool playerTwoPawnOneOnB1;
    public bool playerTwoPawnOneOnB2;
    public bool playerTwoPawnOneOnC1;
    public bool playerTwoPawnOneOnC2;
    public bool playerTwoPawnOneOnC3;
    public bool playerTwoPawnOneOnD1;
    public bool playerTwoPawnOneOnD2;
    public bool playerTwoPawnOneOnD3;
    public bool playerTwoPawnOneOnD4;
    public bool playerTwoPawnTwoOnA2;
    public bool playerTwoPawnTwoOnB1;
    public bool playerTwoPawnTwoOnB2;
    public bool playerTwoPawnTwoOnB3;
    public bool playerTwoPawnTwoOnC1;
    public bool playerTwoPawnTwoOnC2;
    public bool playerTwoPawnTwoOnC3;
    public bool playerTwoPawnTwoOnC4;
    public bool playerTwoPawnTwoOnD1;
    public bool playerTwoPawnTwoOnD2;
    public bool playerTwoPawnTwoOnD3;
    public bool playerTwoPawnTwoOnD4;
    public bool playerTwoPawnThreeOnA3;
    public bool playerTwoPawnThreeOnB2;
    public bool playerTwoPawnThreeOnB3;
    public bool playerTwoPawnThreeOnB4;
    public bool playerTwoPawnThreeOnC1;
    public bool playerTwoPawnThreeOnC2;
    public bool playerTwoPawnThreeOnC3;
    public bool playerTwoPawnThreeOnC4;
    public bool playerTwoPawnThreeOnD1;
    public bool playerTwoPawnThreeOnD2;
    public bool playerTwoPawnThreeOnD3;
    public bool playerTwoPawnThreeOnD4;
    public bool playerTwoPawnFourOnA4;
    public bool playerTwoPawnFourOnB3;
    public bool playerTwoPawnFourOnB4;
    public bool playerTwoPawnFourOnC2;
    public bool playerTwoPawnFourOnC3;
    public bool playerTwoPawnFourOnC4;
    public bool playerTwoPawnFourOnD1;
    public bool playerTwoPawnFourOnD2;
    public bool playerTwoPawnFourOnD3;
    public bool playerTwoPawnFourOnD4;
    int numberofplayerOnePawnsLeft;
    int numberofPlayerTwoPawnsLeft;
    bool playerOnePawnOneCantMove;
    bool playerOnePawnTwoCantMove;
    bool playerOnePawnThreeCantMove;
    bool playerOnePawnFourCantMove;
    bool playerTwoPawnOneCantMove;
    bool playerTwoPawnTwoCantMove;
    bool playerTwoPawnThreeCantMove;
    bool playerTwoPawnFourCantMove;

    // Start is called before the first frame update
    void Start()
    {
        playerOnePawnOne = GameObject.FindWithTag("Player-1");
        playerOnePawnTwo = GameObject.FindWithTag("Player-2");
        playerOnePawnThree = GameObject.FindWithTag("Player-3");
        playerOnePawnFour = GameObject.FindWithTag("Player-4");
        playerTwoPawnOne = GameObject.FindWithTag("player-2-pawn-1");
        playerTwoPawnTwo = GameObject.FindWithTag("player-2-pawn-2");
        playerTwoPawnThree = GameObject.FindWithTag("player-2-pawn-3");
        playerTwoPawnFour = GameObject.FindWithTag("player-2-pawn-4");
        playerOnePawnOneOnA1 = false;
        playerOnePawnOneOnA2 = false;
        playerOnePawnOneOnA3 = false;
        playerOnePawnOneOnA4 = false;
        playerOnePawnOneOnB1 = false;
        playerOnePawnOneOnB2 = false;
        playerOnePawnOneOnB3 = false;
        playerOnePawnOneOnC1 = false;
        playerOnePawnOneOnC2 = false;
        playerOnePawnOneOnD1 = false;
        playerOnePawnTwoOnA1 = false;
        playerOnePawnTwoOnA2 = false;
        playerOnePawnTwoOnA3 = false; 
        playerOnePawnTwoOnA4 = false;
        playerOnePawnTwoOnB1 = false;
        playerOnePawnTwoOnB2 = false;
        playerOnePawnTwoOnB3 = false; 
        playerOnePawnTwoOnB4 = false; 
        playerOnePawnTwoOnC1 = false; 
        playerOnePawnTwoOnC2 = false; 
        playerOnePawnTwoOnC3 = false;
        playerOnePawnTwoOnD2 = false;  
        playerOnePawnThreeOnA1 = false;
        playerOnePawnThreeOnA2 = false;
        playerOnePawnThreeOnA3 = false;
        playerOnePawnThreeOnA4 = false;
        playerOnePawnThreeOnB1 = false;
        playerOnePawnThreeOnB2 = false;
        playerOnePawnThreeOnB3 = false;
        playerOnePawnThreeOnB4 = false;
        playerOnePawnThreeOnC2 = false;
        playerOnePawnThreeOnC3 = false;
        playerOnePawnThreeOnC4 = false;
        playerOnePawnThreeOnD3 = false;
        playerOnePawnFourOnA1 = false;
        playerOnePawnFourOnA2 = false;
        playerOnePawnFourOnA3 = false;
        playerOnePawnFourOnA4 = false;
        playerOnePawnFourOnB2 = false;
        playerOnePawnFourOnB3 = false;
        playerOnePawnFourOnB4 = false;
        playerOnePawnFourOnC3 = false;
        playerOnePawnFourOnC4 = false;
        playerOnePawnFourOnD4 = false;
        playerTwoPawnOneOnA1  = false;
        playerTwoPawnOneOnB1 = false;
        playerTwoPawnOneOnB2 = false;
        playerTwoPawnOneOnC1 = false;
        playerTwoPawnOneOnC2 = false;
        playerTwoPawnOneOnC3 = false;
        playerTwoPawnOneOnD1 = false;
        playerTwoPawnOneOnD2 = false;
        playerTwoPawnOneOnD3 = false;
        playerTwoPawnOneOnD4 = false;
        playerTwoPawnTwoOnA2 = false;
        playerTwoPawnTwoOnB1 = false;
        playerTwoPawnTwoOnB2 = false;
        playerTwoPawnTwoOnB3 = false;
        playerTwoPawnTwoOnC1 = false;
        playerTwoPawnTwoOnC2 = false;
        playerTwoPawnTwoOnC3 = false;
        playerTwoPawnTwoOnC4 = false;
        playerTwoPawnTwoOnD1 = false;
        playerTwoPawnTwoOnD2 = false;
        playerTwoPawnTwoOnD3 = false;
        playerTwoPawnTwoOnD4 = false;
        playerTwoPawnThreeOnA3 = false;
        playerTwoPawnThreeOnB2 = false;
        playerTwoPawnThreeOnB3 = false;
        playerTwoPawnThreeOnB4 = false;
        playerTwoPawnThreeOnC1 = false;
        playerTwoPawnThreeOnC2 = false;
        playerTwoPawnThreeOnC3 = false;
        playerTwoPawnThreeOnC4 = false;
        playerTwoPawnFourOnA4  = false;
        playerTwoPawnFourOnB3 = false;
        playerTwoPawnFourOnB4 = false;
        playerTwoPawnFourOnC2 = false;
        playerTwoPawnFourOnC3 = false;
        playerTwoPawnFourOnC4 = false;
        playerTwoPawnFourOnD1 = false;
        playerTwoPawnFourOnD2 = false;
        playerTwoPawnFourOnD3 = false;
        playerTwoPawnFourOnD4 = false;
    }

    // Update is called once per frame
    void Update()
    {   
        numberofplayerOnePawnsLeft = GameObject.FindWithTag("GameController").GetComponent<octopawnPlayerTwoMove>().playerOnePawnNumber;
        numberofPlayerTwoPawnsLeft = GameObject.FindWithTag("GameController").GetComponent<octopawnPlayerOneMove>().playerTwoPawnNumber;
        playerOnePawnOneCantMove = GameObject.FindWithTag("GameController").GetComponent<octopawnPlayerOneMove>().pawnOneCantMove;
        playerOnePawnTwoCantMove = GameObject.FindWithTag("GameController").GetComponent<octopawnPlayerOneMove>().pawnTwoCantMove;
        playerOnePawnThreeCantMove = GameObject.FindWithTag("GameController").GetComponent<octopawnPlayerOneMove>().pawnThreeCantMove;
        playerOnePawnFourCantMove = GameObject.FindWithTag("GameController").GetComponent<octopawnPlayerOneMove>().pawnFourCantMove;
        playerTwoPawnOneCantMove = GameObject.FindWithTag("GameController").GetComponent<octopawnPlayerTwoMove>().pawnOneCantMove;
        playerTwoPawnTwoCantMove = GameObject.FindWithTag("GameController").GetComponent<octopawnPlayerTwoMove>().pawnTwoCantMove;
        playerTwoPawnThreeCantMove = GameObject.FindWithTag("GameController").GetComponent<octopawnPlayerTwoMove>().pawnThreeCantMove;
        playerTwoPawnFourCantMove = GameObject.FindWithTag("GameController").GetComponent<octopawnPlayerTwoMove>().pawnFourCantMove;
        playerOnePawnCheck();
        playerTwoPawnCheck();
        if(numberofplayerOnePawnsLeft == 0)
        {
            StartCoroutine(playerTwoWins());
        }
        if(numberofPlayerTwoPawnsLeft == 0)
        {
            StartCoroutine(playerOneWins());
        }
        if(playerOnePawnOneCantMove && playerOnePawnTwoCantMove && playerOnePawnThreeCantMove && playerOnePawnFourCantMove)
        {
            StartCoroutine(playerTwoWins());
        }
        if(!playerOnePawnOne.active)
        {
            if(playerOnePawnTwoCantMove && playerOnePawnThreeCantMove && playerOnePawnFourCantMove)
            {
                StartCoroutine(playerTwoWins());
            }
        }
        if(!playerOnePawnTwo.active)
        {
            if(playerOnePawnOneCantMove && playerOnePawnThreeCantMove && playerOnePawnFourCantMove)
            {
                StartCoroutine(playerTwoWins());
            }
        }
        if(!playerOnePawnThree.active)
        {
            if(playerOnePawnOneCantMove && playerOnePawnTwoCantMove && playerOnePawnFourCantMove)
            {
                StartCoroutine(playerTwoWins());
            }
        }
        if(!playerOnePawnFour.active)
        {
            if(playerOnePawnOneCantMove && playerOnePawnTwoCantMove && playerOnePawnThreeCantMove)
            {
                StartCoroutine(playerTwoWins());
            }
        }
        if(!playerOnePawnThree.active && !playerOnePawnFour.active)
        {
            if(playerOnePawnOneCantMove && playerOnePawnTwoCantMove)
            {
                StartCoroutine(playerTwoWins());
            }
        }
        if(!playerOnePawnTwo.active && !playerOnePawnFour.active)
        {
            if(playerOnePawnOneCantMove && playerOnePawnThreeCantMove)
            {
                StartCoroutine(playerTwoWins());
            }
        }
        if(!playerOnePawnTwo.active && !playerOnePawnThree.active)
        {
            if(playerOnePawnOneCantMove && playerOnePawnFourCantMove)
            {
                StartCoroutine(playerTwoWins());
            }
        }
        if(!playerOnePawnOne.active && !playerOnePawnFour.active)
        {
            if(playerOnePawnTwoCantMove && playerOnePawnThreeCantMove)
            {
                StartCoroutine(playerTwoWins());
            }
        }
        if(!playerOnePawnOne.active && !playerOnePawnThree.active)
        {
            if(playerOnePawnTwoCantMove && playerOnePawnFourCantMove)
            {
                StartCoroutine(playerTwoWins());
            }
        }
        if(!playerOnePawnOne.active && !playerOnePawnTwo.active)
        {
            if(playerOnePawnThreeCantMove && playerOnePawnFourCantMove)
            {
                StartCoroutine(playerTwoWins());
            }
        }
        if(!playerOnePawnOne.active && !playerOnePawnTwo.active && !playerOnePawnThree.active)
        {
            if(playerOnePawnFourCantMove)
            {   
                StartCoroutine(playerTwoWins());
            }
        }
        if(!playerOnePawnOne.active && !playerOnePawnTwo.active && !playerOnePawnFour.active)
        {
            if(playerOnePawnThreeCantMove)
            {
                StartCoroutine(playerTwoWins());
            }
        }  
        if(!playerOnePawnOne.active && !playerOnePawnThree.active && !playerOnePawnFour.active)
        {
            if(playerOnePawnTwoCantMove)
            {
                StartCoroutine(playerTwoWins());
            }
        }  
        if(!playerOnePawnTwo.active && !playerOnePawnThree.active && !playerOnePawnFour.active)
        {
            if(playerOnePawnOneCantMove)
            {
                StartCoroutine(playerTwoWins());
            }
        }    
        if(playerTwoPawnOneCantMove && playerTwoPawnTwoCantMove && playerTwoPawnThreeCantMove && playerTwoPawnFourCantMove)
        {
            StartCoroutine(playerOneWins());
        }
        if(!playerTwoPawnOne.active)
        {
            if(playerTwoPawnTwoCantMove && playerTwoPawnThreeCantMove && playerTwoPawnFourCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }
        if(!playerTwoPawnTwo.active)
        {
            if(playerTwoPawnOneCantMove && playerTwoPawnThreeCantMove && playerTwoPawnFourCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }
        if(!playerTwoPawnThree.active)
        {
            if(playerTwoPawnOneCantMove && playerTwoPawnTwoCantMove && playerTwoPawnFourCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }
        if(!playerTwoPawnFour.active)
        {
            if(playerTwoPawnOneCantMove && playerTwoPawnTwoCantMove && playerTwoPawnThreeCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }
        if(!playerTwoPawnOne.active && !playerTwoPawnTwo.active)
        {
            if(playerTwoPawnThreeCantMove && playerTwoPawnFourCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }
        if(!playerTwoPawnOne.active && !playerTwoPawnThree.active)
        {
            if(playerTwoPawnTwoCantMove && playerTwoPawnFourCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }
        if(!playerTwoPawnOne.active && !playerTwoPawnFour.active)
        {
            if(playerTwoPawnTwoCantMove && playerTwoPawnThreeCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }
        if(!playerTwoPawnTwo.active && !playerTwoPawnThree.active)
        {
            if(playerTwoPawnOneCantMove && playerTwoPawnTwoCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }
        if(!playerTwoPawnTwo.active && !playerTwoPawnFour.active)
        {
            if(playerTwoPawnOneCantMove && playerTwoPawnThreeCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }
        if(playerTwoPawnThree.active && !playerTwoPawnFour.active)
        {
            if(playerTwoPawnOneCantMove && playerTwoPawnTwoCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }
        if(!playerTwoPawnOne.active && !playerTwoPawnFour.active)
        {
            if(playerTwoPawnTwoCantMove && playerTwoPawnThreeCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }
        if(!playerTwoPawnOne.active && !playerTwoPawnTwo.active && !playerTwoPawnThree.active)
        {
            if(playerTwoPawnFourCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }
        if(!playerTwoPawnOne.active && !playerTwoPawnTwo.active && !playerTwoPawnFour.active)
        {
            if(playerTwoPawnThreeCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }  
        if(!playerOnePawnOne.active && !playerOnePawnThree.active && !playerOnePawnFour.active)
        {
            if(playerTwoPawnTwoCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }  
        if(!playerTwoPawnTwo.active && !playerTwoPawnThree.active && !playerTwoPawnFour.active)
        {
            if(playerTwoPawnOneCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }
    }

    void playerOnePawnCheck()
    {
         //Pawn 1 check
        if (playerOnePawnOneCollider.IsTouching(a1Collider))
        {
            playerOnePawnOneOnA1 = true;
            StartCoroutine(playerOneWins());
        }
        else
        {
            playerOnePawnOneOnA1 = false;
        }
        if (playerOnePawnOneCollider.IsTouching(a2Collider))
        {
            playerOnePawnOneOnA2 = true;
            StartCoroutine(playerOneWins());
        }
        else
        {
            playerOnePawnOneOnA2 = false;
        }
        if (playerOnePawnOneCollider.IsTouching(a3Collider))
        {
            playerOnePawnOneOnA3 = true;
            StartCoroutine(playerOneWins());
        }
        else
        {
            playerOnePawnOneOnA3 = false;
        }
        if (playerOnePawnOneCollider.IsTouching(a4Collider))
        {
            playerOnePawnOneOnA4 = true;
            StartCoroutine(playerOneWins());
        }
        else
        {
            playerOnePawnOneOnA4 = false;
        }
        if (playerOnePawnOneCollider.IsTouching(b1Collider))
        {
            playerOnePawnOneOnB1 = true;
        }
        else
        {
            playerOnePawnOneOnB1 = false;
        }
        if (playerOnePawnOneCollider.IsTouching(b2Collider))
        {
            playerOnePawnOneOnB2 = true;
        }
        else
        {
            playerOnePawnOneOnB2 = false;
        }
        if (playerOnePawnOneCollider.IsTouching(b3Collider))
        {
            playerOnePawnOneOnB3 = true;
        }
        else
        {
            playerOnePawnOneOnB3 = false;
        }
        if (playerOnePawnOneCollider.IsTouching(c1Collider))
        {
            playerOnePawnOneOnC1 = true;
        }
        else
        {
            playerOnePawnOneOnC1 = false;
        }
        if (playerOnePawnOneCollider.IsTouching(c2Collider))
        {
            playerOnePawnOneOnC2 = true;
        }
        else
        {
            playerOnePawnOneOnC2 = false;
        }
        if (playerOnePawnOneCollider.IsTouching(d1Collider))
        {
            playerOnePawnOneOnD1 = true;
        }
        else
        {
            playerOnePawnOneOnD1 = false;
        }

        //pawn 2 check
        if (playerOnePawnTwoCollider.IsTouching(a1Collider))
        {
            playerOnePawnTwoOnA1 = true;
            StartCoroutine(playerOneWins());
        }
        else
        {
            playerOnePawnTwoOnA1 = false;
        }
        if (playerOnePawnTwoCollider.IsTouching(a2Collider))
        {
            playerOnePawnTwoOnA2 = true;
            StartCoroutine(playerOneWins());
        }
        else
        {
            playerOnePawnTwoOnA2 = false;
        }
        if (playerOnePawnTwoCollider.IsTouching(a3Collider))
        {
            playerOnePawnTwoOnA3 = true;
            StartCoroutine(playerOneWins());
        }
        else
        {
            playerOnePawnTwoOnA3 = false;
        }
        if (playerOnePawnTwoCollider.IsTouching(a4Collider))
        {
            playerOnePawnTwoOnA4 = true;
            StartCoroutine(playerOneWins());
        }
        else
        {
            playerOnePawnTwoOnA4 = false;
        }
        if (playerOnePawnTwoCollider.IsTouching(b1Collider))
        {
            playerOnePawnTwoOnB1 = true;
        }
        else
        {
            playerOnePawnTwoOnB1 = false;
        }
        if (playerOnePawnTwoCollider.IsTouching(b2Collider))
        {
            playerOnePawnTwoOnB2 = true;
        }
        else
        {
            playerOnePawnTwoOnB2 = false;
        }
        if (playerOnePawnTwoCollider.IsTouching(b3Collider))
        {
            playerOnePawnTwoOnB3 = true;
        }
        else
        {
            playerOnePawnTwoOnB3 = false;
        }
        if (playerOnePawnTwoCollider.IsTouching(b4Collider))
        {
            playerOnePawnTwoOnB4 = true;
        }
        else
        {
            playerOnePawnTwoOnB4 = false;
        }
        if (playerOnePawnTwoCollider.IsTouching(c1Collider))
        {
            playerOnePawnTwoOnC1 = true;
        }
        else
        {
            playerOnePawnTwoOnC1 = false;
        }
        if (playerOnePawnTwoCollider.IsTouching(c2Collider))
        {
            playerOnePawnTwoOnC2 = true;
        }
        else
        {
            playerOnePawnTwoOnC2 = false;
        }
        if (playerOnePawnTwoCollider.IsTouching(c3Collider))
        {
            playerOnePawnTwoOnC3 = true;
        }
        else
        {
            playerOnePawnTwoOnC3 = false;
        }
        if (playerOnePawnTwoCollider.IsTouching(d2Collider))
        {
            playerOnePawnTwoOnD2 = true;
        }
        else
        {
            playerOnePawnTwoOnD2 = false;
        }

        //Pawn 3 check
        if (playerOnePawnThreeCollider.IsTouching(a1Collider))
        {
            playerOnePawnThreeOnA1 = true;
            StartCoroutine(playerOneWins());
        }
        else
        {
            playerOnePawnThreeOnA1 = false;
        }
        if (playerOnePawnThreeCollider.IsTouching(a2Collider))
        {
            playerOnePawnThreeOnA2 = true;
            StartCoroutine(playerOneWins());
        }
        else
        {
            playerOnePawnThreeOnA2 = false;
        }
        if (playerOnePawnThreeCollider.IsTouching(a3Collider))
        {
            playerOnePawnThreeOnA3 = true;
            StartCoroutine(playerOneWins());
        }
        else
        {
            playerOnePawnThreeOnA3 = false;
        }
        if (playerOnePawnThreeCollider.IsTouching(a4Collider))
        {
            playerOnePawnThreeOnA4 = true;
            StartCoroutine(playerOneWins());
        }
        else
        {
            playerOnePawnThreeOnA4 = false;
        }
        if (playerOnePawnThreeCollider.IsTouching(b2Collider))
        {
            playerOnePawnThreeOnB2 = true;
        }
        else
        {
            playerOnePawnThreeOnB2 = false;
        }
        if (playerOnePawnThreeCollider.IsTouching(b3Collider))
        {
            playerOnePawnThreeOnB3 = true;
        }
        else
        {
            playerOnePawnThreeOnB3 = false;
        }
        if (playerOnePawnThreeCollider.IsTouching(b4Collider))
        {
            playerOnePawnThreeOnB4 = true;
        }
        else
        {
            playerOnePawnThreeOnB4 = false;
        }
        if (playerOnePawnThreeCollider.IsTouching(c2Collider))
        {
            playerOnePawnThreeOnC2 = true;
        }
        else
        {
            playerOnePawnThreeOnC2 = false;
        }
        if (playerOnePawnThreeCollider.IsTouching(c3Collider))
        {
            playerOnePawnThreeOnC3 = true;
        }
        else
        {
            playerOnePawnThreeOnC3 = false;
        }
        if (playerOnePawnThreeCollider.IsTouching(c4Collider))
        {
            playerOnePawnThreeOnC4 = true;
        }
        else
        {
            playerOnePawnThreeOnC4 = false;
        }
        if (playerOnePawnThreeCollider.IsTouching(d3Collider))
        {
            playerOnePawnThreeOnD3 = true;
        }
        else
        {
            playerOnePawnThreeOnD3 = false;
        }

        //Pawn 4 check
        if (playerOnePawnFourCollider.IsTouching(a1Collider))
        {
            playerOnePawnFourOnA1 = true;
            StartCoroutine(playerOneWins());
        }
        else
        {
            playerOnePawnFourOnA1 = false;
        }
        if (playerOnePawnFourCollider.IsTouching(a2Collider))
        {
            playerOnePawnFourOnA2 = true;
            StartCoroutine(playerOneWins());
        }
        else
        {
            playerOnePawnFourOnA2 = false;
        }
        if (playerOnePawnFourCollider.IsTouching(a3Collider))
        {
            playerOnePawnFourOnA3 = true;
            StartCoroutine(playerOneWins());
        }
        else
        {
            playerOnePawnFourOnA3 = false;
        }
        if (playerOnePawnFourCollider.IsTouching(a4Collider))
        {
            playerOnePawnFourOnA4 = true;
            StartCoroutine(playerOneWins());
        }
        else
        {
            playerOnePawnFourOnA4 = false;
        }
        if (playerOnePawnFourCollider.IsTouching(b2Collider))
        {
            playerOnePawnFourOnB2 = true;
        }
        else
        {
            playerOnePawnFourOnB2 = false;
        }
        if (playerOnePawnFourCollider.IsTouching(b3Collider))
        {
            playerOnePawnFourOnB3 = true;
        }
        else
        {
            playerOnePawnFourOnB3 = false;
        }
        if (playerOnePawnFourCollider.IsTouching(b4Collider))
        {
            playerOnePawnFourOnB4 = true;
        }
        else
        {
            playerOnePawnFourOnB4 = false;
        }
        if (playerOnePawnFourCollider.IsTouching(c3Collider))
        {
            playerOnePawnFourOnC3 = true;
        }
        else
        {
            playerOnePawnFourOnC3 = false;
        }
        if (playerOnePawnFourCollider.IsTouching(c4Collider))
        {
            playerOnePawnFourOnC4 = true;
        }
        else
        {
            playerOnePawnFourOnC4 = false;
        }
        if (playerOnePawnFourCollider.IsTouching(d4Collider))
        {
            playerOnePawnFourOnD4 = true;
        }
        else
        {
            playerOnePawnFourOnD4 = false;
        }
    }

    void playerTwoPawnCheck()
    {
         //AI Pawn 1 check
        if (playerTwoPawnOneCollider.IsTouching(a1Collider))
        {
            playerTwoPawnOneOnA1 = true;
        }
        else
        {
            playerTwoPawnOneOnA1 = false;
        }
        
        if (playerTwoPawnOneCollider.IsTouching(b1Collider))
        {
            playerTwoPawnOneOnB1 = true;
        }
        else
        {
            playerTwoPawnOneOnB1 = false;
        }
        if (playerTwoPawnOneCollider.IsTouching(b2Collider))
        {
            playerTwoPawnOneOnB2 = true;
        }
        else
        {
            playerTwoPawnOneOnB2 = false;
        }
        if (playerTwoPawnOneCollider.IsTouching(c1Collider))
        {
            playerTwoPawnOneOnC1 = true;
        }
        else
        {
            playerTwoPawnOneOnC1 = false;
        }
        if (playerTwoPawnOneCollider.IsTouching(c2Collider))
        {
            playerTwoPawnOneOnC2 = true;
        }
        else
        {
            playerTwoPawnOneOnC2 = false;
        }
        if (playerTwoPawnOneCollider.IsTouching(c3Collider))
        {
            playerTwoPawnOneOnC3 = true;
        }
        else
        {
            playerTwoPawnOneOnC3 = false;
        }
        if (playerTwoPawnOneCollider.IsTouching(d1Collider))
        {
            playerTwoPawnOneOnD1 = true;
            StartCoroutine(playerTwoWins());
            
        }
        else
        {
            playerTwoPawnOneOnD1 = false;
        }
        if (playerTwoPawnOneCollider.IsTouching(d2Collider))
        {
            playerTwoPawnOneOnD2 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnOneOnD2 = false;
        }
        if (playerTwoPawnOneCollider.IsTouching(d3Collider))
        {
            playerTwoPawnOneOnD3 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnOneOnD3 = false;
        }
        if (playerTwoPawnOneCollider.IsTouching(d4Collider))
        {
            playerTwoPawnOneOnD4 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnOneOnD4 = false;
        }

        //pawn 2 check
        if (playerTwoPawnTwoCollider.IsTouching(a2Collider))
        {
            playerTwoPawnTwoOnA2 = true;
        }
        else
        {
            playerTwoPawnTwoOnA2 = false;
        }
        if (playerTwoPawnTwoCollider.IsTouching(b1Collider))
        {
            playerTwoPawnTwoOnB1 = true;
        }
        else
        {
            playerTwoPawnTwoOnB1 = false;
        }
        if (playerTwoPawnTwoCollider.IsTouching(b2Collider))
        {
            playerTwoPawnTwoOnB2 = true;
        }
        else
        {
            playerTwoPawnTwoOnB2 = false;
        }
        if (playerTwoPawnTwoCollider.IsTouching(b3Collider))
        {
            playerTwoPawnTwoOnB3 = true;
        }
        else
        {
            playerTwoPawnTwoOnB3 = false;
        }
        if (playerTwoPawnTwoCollider.IsTouching(c1Collider))
        {
            playerTwoPawnTwoOnC1 = true;
        }
        else
        {
            playerTwoPawnTwoOnC1 = false;
        }
        if (playerTwoPawnTwoCollider.IsTouching(c2Collider))
        {
            playerTwoPawnTwoOnC2 = true;
        }
        else
        {
            playerTwoPawnTwoOnC2 = false;
        }
        
        if (playerTwoPawnTwoCollider.IsTouching(c3Collider))
        {
            playerTwoPawnTwoOnC3 = true;
        }
        else
        {
            playerTwoPawnTwoOnC3 = false;
        }

        if (playerTwoPawnTwoCollider.IsTouching(c4Collider))
        {
            playerTwoPawnTwoOnC4 = true;
        }
        else
        {
            playerTwoPawnTwoOnC4 = false;
        }
        if (playerTwoPawnTwoCollider.IsTouching(d1Collider))
        {
            playerTwoPawnTwoOnD1 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnTwoOnD1 = false;
        }
        if (playerTwoPawnTwoCollider.IsTouching(d2Collider))
        {
            playerTwoPawnTwoOnD2 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnTwoOnD2 = false;
        }
        
        if (playerTwoPawnTwoCollider.IsTouching(d3Collider))
        {
            playerTwoPawnTwoOnD3 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnTwoOnD3 = false;
        }

        if (playerTwoPawnTwoCollider.IsTouching(d4Collider))
        {
            playerTwoPawnTwoOnD4 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnTwoOnD4 = false;
        }

        //Pawn 3 check
        if (playerTwoPawnThreeCollider.IsTouching(a3Collider))
        {
            playerTwoPawnThreeOnA3 = true;
        }
        else
        {
            playerTwoPawnThreeOnA3 = false;
        }
        if (playerTwoPawnThreeCollider.IsTouching(b2Collider))
        {
            playerTwoPawnThreeOnB2 = true;
        }
        else
        {
            playerTwoPawnThreeOnB2 = false;
        }
        if (playerTwoPawnThreeCollider.IsTouching(b3Collider))
        {
            playerTwoPawnThreeOnB3 = true;
        }
        else
        {
            playerTwoPawnThreeOnB3 = false;
        }
        if (playerTwoPawnThreeCollider.IsTouching(b4Collider))
        {
            playerTwoPawnThreeOnB4 = true;
        }
        else
        {
            playerTwoPawnThreeOnB4 = false;
        }
        if (playerTwoPawnThreeCollider.IsTouching(c1Collider))
        {
            playerTwoPawnThreeOnC1 = true;
        }
        else
        {
            playerTwoPawnThreeOnC1 = false;
        }
        if (playerTwoPawnThreeCollider.IsTouching(c2Collider))
        {
            playerTwoPawnThreeOnC2 = true;
        }
        else
        {
            playerTwoPawnThreeOnC2 = false;
        }
        if (playerTwoPawnThreeCollider.IsTouching(c3Collider))
        {
            playerTwoPawnThreeOnC3 = true;
        }
        else
        {
            playerTwoPawnThreeOnC3 = false;
        }
        if (playerTwoPawnThreeCollider.IsTouching(c4Collider))
        {
            playerTwoPawnThreeOnC4 = true;
        }
        else
        {
            playerTwoPawnThreeOnC4 = false;
        }
        if (playerTwoPawnThreeCollider.IsTouching(d1Collider))
        {
            playerTwoPawnThreeOnD1 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnThreeOnD1 = false;
        }
        if (playerTwoPawnThreeCollider.IsTouching(d2Collider))
        {
            playerTwoPawnThreeOnD2 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnThreeOnD2 = false;
        }
        if (playerTwoPawnThreeCollider.IsTouching(d3Collider))
        {
            playerTwoPawnThreeOnD3 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnThreeOnD3 = false;
        }
        if (playerTwoPawnThreeCollider.IsTouching(d4Collider))
        {
            playerTwoPawnThreeOnD4 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnThreeOnD4 = false;
        }

        //Pawn 4 check
        if (playerTwoPawnFourCollider.IsTouching(a4Collider))
        {
            playerTwoPawnFourOnA4 = true;
        }
        else
        {
            playerTwoPawnFourOnA4 = false;
        }
        
        if (playerTwoPawnFourCollider.IsTouching(b3Collider))
        {
            playerTwoPawnFourOnB3 = true;
        }
        else
        {
            playerTwoPawnFourOnB3 = false;
        }
        if (playerTwoPawnFourCollider.IsTouching(b4Collider))
        {
            playerTwoPawnFourOnB4 = true;
        }
        else
        {
            playerTwoPawnFourOnB4 = false;
        }
        if (playerTwoPawnFourCollider.IsTouching(c2Collider))
        {
            playerTwoPawnFourOnC2 = true;
        }
        else
        {
            playerTwoPawnFourOnC2 = false;
        }
        if (playerTwoPawnFourCollider.IsTouching(c3Collider))
        {
            playerTwoPawnFourOnC3 = true;
        }
        else
        {
            playerTwoPawnFourOnC3 = false;
        }
        if (playerTwoPawnFourCollider.IsTouching(c4Collider))
        {
            playerTwoPawnFourOnC4 = true;
        }
        else
        {
            playerTwoPawnFourOnC4 = false;
        }
        if (playerTwoPawnFourCollider.IsTouching(d1Collider))
        {
            playerTwoPawnFourOnD1 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnFourOnD1 = false;
        }
        if (playerTwoPawnFourCollider.IsTouching(d2Collider))
        {
            playerTwoPawnFourOnD2 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnFourOnD2 = false;
        }
        if (playerTwoPawnFourCollider.IsTouching(d3Collider))
        {
            playerTwoPawnFourOnD3 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnFourOnD3 = false;
        }
        if (playerTwoPawnFourCollider.IsTouching(d4Collider))
        {
            playerTwoPawnOneOnD4 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnOneOnD4 = false;
        }
    }

    public IEnumerator playerOneWins()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene("playerOneWins");
    }

    public IEnumerator playerTwoWins()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene("playerTwoWins");
    }
}