using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class octopawnBoardState : MonoBehaviour
{
    public GameObject playerPawnOne;
    public GameObject playerPawnTwo;
    public GameObject playerPawnThree;
    public GameObject playerPawnFour;
    public GameObject AIPawnOne;
    public GameObject AIPawnTwo;
    public GameObject AIPawnThree;
    public GameObject AIPawnFour;
    public Collider2D playerPawnOneCollider;
    public Collider2D playerPawnTwoCollider;
    public Collider2D playerPawnThreeCollider;
    public Collider2D playerPawnFourCollider;
    public Collider2D AIPawnOneCollider;
    public Collider2D AIPawnTwoCollider;
    public Collider2D AIPawnThreeCollider;
    public Collider2D AIPawnFourCollider;
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
    public bool playerPawnOneOnA1;
    public bool playerPawnOneOnA2;
    public bool playerPawnOneOnA3;
    public bool playerPawnOneOnA4;
    public bool playerPawnOneOnB1;
    public bool playerPawnOneOnB2;
    public bool playerPawnOneOnB3;
    public bool playerPawnOneOnC1;
    public bool playerPawnOneOnC2;
    public bool playerPawnOneOnD1;
    public bool playerPawnTwoOnA1;
    public bool playerPawnTwoOnA2;
    public bool playerPawnTwoOnA3;
    public bool playerPawnTwoOnA4;
    public bool playerPawnTwoOnB1;
    public bool playerPawnTwoOnB2;
    public bool playerPawnTwoOnB3;
    public bool playerPawnTwoOnB4;
    public bool playerPawnTwoOnC1;
    public bool playerPawnTwoOnC2;
    public bool playerPawnTwoOnC3;
    public bool playerPawnTwoOnD2;
    public bool playerPawnThreeOnA1;
    public bool playerPawnThreeOnA2;
    public bool playerPawnThreeOnA3;
    public bool playerPawnThreeOnA4;
    public bool playerPawnThreeOnB1;
    public bool playerPawnThreeOnB2;
    public bool playerPawnThreeOnB3;
    public bool playerPawnThreeOnB4;
    public bool playerPawnThreeOnC2;
    public bool playerPawnThreeOnC3;
    public bool playerPawnThreeOnC4;
    public bool playerPawnThreeOnD3;
    public bool playerPawnFourOnA1;
    public bool playerPawnFourOnA2;
    public bool playerPawnFourOnA3;
    public bool playerPawnFourOnA4;
    public bool playerPawnFourOnB2;
    public bool playerPawnFourOnB3;
    public bool playerPawnFourOnB4;
    public bool playerPawnFourOnC3;
    public bool playerPawnFourOnC4;
    public bool playerPawnFourOnD4;
    public bool AIPawnOneOnA1;
    public bool AIPawnOneOnB1;
    public bool AIPawnOneOnB2;
    public bool AIPawnOneOnC1;
    public bool AIPawnOneOnC2;
    public bool AIPawnOneOnC3;
    public bool AIPawnOneOnD1;
    public bool AIPawnOneOnD2;
    public bool AIPawnOneOnD3;
    public bool AIPawnOneOnD4;
    public bool AIPawnTwoOnA2;
    public bool AIPawnTwoOnB1;
    public bool AIPawnTwoOnB2;
    public bool AIPawnTwoOnB3;
    public bool AIPawnTwoOnC1;
    public bool AIPawnTwoOnC2;
    public bool AIPawnTwoOnC3;
    public bool AIPawnTwoOnC4;
    public bool AIPawnTwoOnD1;
    public bool AIPawnTwoOnD2;
    public bool AIPawnTwoOnD3;
    public bool AIPawnTwoOnD4;
    public bool AIPawnThreeOnA3;
    public bool AIPawnThreeOnB2;
    public bool AIPawnThreeOnB3;
    public bool AIPawnThreeOnB4;
    public bool AIPawnThreeOnC1;
    public bool AIPawnThreeOnC2;
    public bool AIPawnThreeOnC3;
    public bool AIPawnThreeOnC4;
    public bool AIPawnThreeOnD1;
    public bool AIPawnThreeOnD2;
    public bool AIPawnThreeOnD3;
    public bool AIPawnThreeOnD4;
    public bool AIPawnFourOnA4;
    public bool AIPawnFourOnB3;
    public bool AIPawnFourOnB4;
    public bool AIPawnFourOnC2;
    public bool AIPawnFourOnC3;
    public bool AIPawnFourOnC4;
    public bool AIPawnFourOnD1;
    public bool AIPawnFourOnD2;
    public bool AIPawnFourOnD3;
    public bool AIPawnFourOnD4;
    int numberofPlayerPawnsLeft;
    int numberofAIPawnsLeft;
    bool playerPawnOneCantMove;
    bool playerPawnTwoCantMove;
    bool playerPawnThreeCantMove;
    bool playerPawnFourCantMove;
    bool AIPawnOneCantMove;
    bool AIPawnTwoCantMove;
    bool AIPawnThreeCantMove;
    bool AIPawnFourCantMove;

    // Start is called before the first frame update
    void Start()
    {
        playerPawnOne = GameObject.FindWithTag("Player-1");
        playerPawnTwo = GameObject.FindWithTag("Player-2");
        playerPawnThree = GameObject.FindWithTag("Player-3");
        playerPawnFour = GameObject.FindWithTag("Player-4");
        AIPawnOne = GameObject.FindWithTag("AI-Pawn-1");
        AIPawnTwo = GameObject.FindWithTag("AI-Pawn-2");
        AIPawnThree = GameObject.FindWithTag("AI-Pawn-3");
        AIPawnFour = GameObject.FindWithTag("AI-Pawn-4");
        playerPawnOneOnA1 = false;
        playerPawnOneOnA2 = false;
        playerPawnOneOnA3 = false;
        playerPawnOneOnA4 = false;
        playerPawnOneOnB1 = false;
        playerPawnOneOnB2 = false;
        playerPawnOneOnB3 = false;
        playerPawnOneOnC1 = false;
        playerPawnOneOnC2 = false;
        playerPawnOneOnD1 = false;
        playerPawnTwoOnA1 = false;
        playerPawnTwoOnA2 = false;
        playerPawnTwoOnA3 = false; 
        playerPawnTwoOnA4 = false;
        playerPawnTwoOnB1 = false;
        playerPawnTwoOnB2 = false;
        playerPawnTwoOnB3 = false; 
        playerPawnTwoOnB4 = false; 
        playerPawnTwoOnC1 = false; 
        playerPawnTwoOnC2 = false; 
        playerPawnTwoOnC3 = false;
        playerPawnTwoOnD2 = false;  
        playerPawnThreeOnA1 = false;
        playerPawnThreeOnA2 = false;
        playerPawnThreeOnA3 = false;
        playerPawnThreeOnA4 = false;
        playerPawnThreeOnB1 = false;
        playerPawnThreeOnB2 = false;
        playerPawnThreeOnB3 = false;
        playerPawnThreeOnB4 = false;
        playerPawnThreeOnC2 = false;
        playerPawnThreeOnC3 = false;
        playerPawnThreeOnC4 = false;
        playerPawnThreeOnD3 = false;
        playerPawnFourOnA1 = false;
        playerPawnFourOnA2 = false;
        playerPawnFourOnA3 = false;
        playerPawnFourOnA4 = false;
        playerPawnFourOnB2 = false;
        playerPawnFourOnB3 = false;
        playerPawnFourOnB4 = false;
        playerPawnFourOnC3 = false;
        playerPawnFourOnC4 = false;
        playerPawnFourOnD4 = false;
        AIPawnOneOnA1  = false;
        AIPawnOneOnB1 = false;
        AIPawnOneOnB2 = false;
        AIPawnOneOnC1 = false;
        AIPawnOneOnC2 = false;
        AIPawnOneOnC3 = false;
        AIPawnOneOnD1 = false;
        AIPawnOneOnD2 = false;
        AIPawnOneOnD3 = false;
        AIPawnOneOnD4 = false;
        AIPawnTwoOnA2 = false;
        AIPawnTwoOnB1 = false;
        AIPawnTwoOnB2 = false;
        AIPawnTwoOnB3 = false;
        AIPawnTwoOnC1 = false;
        AIPawnTwoOnC2 = false;
        AIPawnTwoOnC3 = false;
        AIPawnTwoOnC4 = false;
        AIPawnTwoOnD1 = false;
        AIPawnTwoOnD2 = false;
        AIPawnTwoOnD3 = false;
        AIPawnTwoOnD4 = false;
        AIPawnThreeOnA3 = false;
        AIPawnThreeOnB2 = false;
        AIPawnThreeOnB3 = false;
        AIPawnThreeOnB4 = false;
        AIPawnThreeOnC1 = false;
        AIPawnThreeOnC2 = false;
        AIPawnThreeOnC3 = false;
        AIPawnThreeOnC4 = false;
        AIPawnFourOnA4  = false;
        AIPawnFourOnB3 = false;
        AIPawnFourOnB4 = false;
        AIPawnFourOnC2 = false;
        AIPawnFourOnC3 = false;
        AIPawnFourOnC4 = false;
        AIPawnFourOnD1 = false;
        AIPawnFourOnD2 = false;
        AIPawnFourOnD3 = false;
        AIPawnFourOnD4 = false;
    }

    // Update is called once per frame
    void Update()
    {   
        numberofPlayerPawnsLeft = GameObject.FindWithTag("GameController").GetComponent<octopawnAIMove>().playerPawnNumber;
        numberofAIPawnsLeft = GameObject.FindWithTag("GameController").GetComponent<octopawnPlayerMove>().AIPawnNumber;
        playerPawnOneCantMove = GameObject.FindWithTag("GameController").GetComponent<octopawnPlayerMove>().pawnOneCantMove;
        playerPawnTwoCantMove = GameObject.FindWithTag("GameController").GetComponent<octopawnPlayerMove>().pawnTwoCantMove;
        playerPawnThreeCantMove = GameObject.FindWithTag("GameController").GetComponent<octopawnPlayerMove>().pawnThreeCantMove;
        playerPawnFourCantMove = GameObject.FindWithTag("GameController").GetComponent<octopawnPlayerMove>().pawnFourCantMove;
        AIPawnOneCantMove = GameObject.FindWithTag("GameController").GetComponent<octopawnAIMove>().pawnOneCantMove;
        AIPawnTwoCantMove = GameObject.FindWithTag("GameController").GetComponent<octopawnAIMove>().pawnTwoCantMove;
        AIPawnThreeCantMove = GameObject.FindWithTag("GameController").GetComponent<octopawnAIMove>().pawnThreeCantMove;
        AIPawnFourCantMove = GameObject.FindWithTag("GameController").GetComponent<octopawnAIMove>().pawnFourCantMove;
        playerPawnCheck();
        AIPawnCheck();
        if(numberofPlayerPawnsLeft == 0)
        {
            changeToLoseScreen();
        }
        if(numberofAIPawnsLeft == 0)
        {
            changeToWinScreen();
        }
        if(playerPawnOneCantMove && playerPawnTwoCantMove && playerPawnThreeCantMove && playerPawnFourCantMove)
        {
            changeToLoseScreen();
        }
        if(!playerPawnOne.active)
        {
            if(playerPawnTwoCantMove && playerPawnThreeCantMove && playerPawnFourCantMove)
            {
                changeToLoseScreen();
            }
        }
        if(!playerPawnTwo.active)
        {
            if(playerPawnOneCantMove && playerPawnThreeCantMove && playerPawnFourCantMove)
            {
                changeToLoseScreen();
            }
        }
        if(!playerPawnThree.active)
        {
            if(playerPawnOneCantMove && playerPawnTwoCantMove && playerPawnFourCantMove)
            {
                changeToLoseScreen();
            }
        }
        if(!playerPawnFour.active)
        {
            if(playerPawnOneCantMove && playerPawnTwoCantMove && playerPawnThreeCantMove)
            {
                changeToLoseScreen();
            }
        }
        if(!playerPawnOne.active && !playerPawnTwo.active)
        {
            if(playerPawnThreeCantMove && playerPawnFourCantMove)
            {
                changeToLoseScreen();
            }
        }
        if(!playerPawnOne.active && !playerPawnThree.active)
        {
            if(playerPawnTwoCantMove && playerPawnFourCantMove)
            {
                changeToLoseScreen();
            }
        }
        if(!playerPawnOne.active && !playerPawnFour.active)
        {
            if(playerPawnTwoCantMove && playerPawnThreeCantMove)
            {
                changeToLoseScreen();
            }
        }
        if(!playerPawnOne.active && !playerPawnTwo.active && !playerPawnThree.active)
        {
            if(playerPawnFourCantMove)
            {
                changeToLoseScreen();
            }
        }
        if(!playerPawnOne.active && !playerPawnTwo.active && !playerPawnFour.active)
        {
            if(playerPawnThreeCantMove)
            {
                changeToLoseScreen();
            }
        }  
        if(!playerPawnOne.active && !playerPawnThree.active && !playerPawnFour.active)
        {
            if(playerPawnTwoCantMove)
            {
                changeToLoseScreen();
            }
        }  
        if(!playerPawnTwo.active && !playerPawnThree.active && !playerPawnFour.active)
        {
            if(playerPawnOneCantMove)
            {
                changeToLoseScreen();
            }
        }    
        if(AIPawnOneCantMove && AIPawnTwoCantMove && AIPawnThreeCantMove)
        {
            changeToWinScreen();
        }
        if(!AIPawnOne.active)
        {
            if(AIPawnTwoCantMove && AIPawnThreeCantMove && AIPawnFourCantMove)
            {
                changeToWinScreen();
            }
        }
        if(!AIPawnTwo.active)
        {
            if(AIPawnOneCantMove && AIPawnThreeCantMove && AIPawnFourCantMove)
            {
                changeToWinScreen();
            }
        }
        if(!AIPawnThree.active)
        {
            if(AIPawnOneCantMove && AIPawnTwoCantMove && AIPawnFourCantMove)
            {
                changeToWinScreen();
            }
        }
        if(!AIPawnFour.active)
        {
            if(AIPawnOneCantMove && AIPawnTwoCantMove && AIPawnThreeCantMove)
            {
                changeToWinScreen();
            }
        }
        if(!AIPawnOne.active && !AIPawnTwo.active)
        {
            if(AIPawnThreeCantMove && AIPawnFourCantMove)
            {
                changeToWinScreen();
            }
        }
        if(!AIPawnOne.active && !AIPawnThree.active)
        {
            if(AIPawnTwoCantMove && AIPawnFourCantMove)
            {
                changeToWinScreen();
            }
        }
        if(!AIPawnOne.active && !AIPawnFour.active)
        {
            if(AIPawnTwoCantMove && AIPawnThreeCantMove)
            {
                changeToWinScreen();
            }
        }
        if(!AIPawnOne.active && !AIPawnTwo.active && !AIPawnThree.active)
        {
            if(AIPawnFourCantMove)
            {
                changeToWinScreen();
            }
        }
        if(!AIPawnOne.active && !AIPawnTwo.active && !AIPawnFour.active)
        {
            if(AIPawnThreeCantMove)
            {
                changeToWinScreen();
            }
        }  
        if(!playerPawnOne.active && !playerPawnThree.active && !playerPawnFour.active)
        {
            if(playerPawnTwoCantMove)
            {
                changeToWinScreen();
            }
        }  
        if(!AIPawnTwo.active && !AIPawnThree.active && !AIPawnFour.active)
        {
            if(AIPawnOneCantMove)
            {
                changeToWinScreen();
            }
        }
    }

    void playerPawnCheck()
    {
         //Pawn 1 check
        if (playerPawnOneCollider.IsTouching(a1Collider))
        {
            playerPawnOneOnA1 = true;
            changeToWinScreen();
        }
        else
        {
            playerPawnOneOnA1 = false;
        }
        if (playerPawnOneCollider.IsTouching(a2Collider))
        {
            playerPawnOneOnA2 = true;
            changeToWinScreen();
        }
        else
        {
            playerPawnOneOnA2 = false;
        }
        if (playerPawnOneCollider.IsTouching(a3Collider))
        {
            playerPawnOneOnA3 = true;
            changeToWinScreen();
        }
        else
        {
            playerPawnOneOnA3 = false;
        }
        if (playerPawnOneCollider.IsTouching(a4Collider))
        {
            playerPawnOneOnA4 = true;
            changeToWinScreen();
        }
        else
        {
            playerPawnOneOnA4 = false;
        }
        if (playerPawnOneCollider.IsTouching(b1Collider))
        {
            playerPawnOneOnB1 = true;
        }
        else
        {
            playerPawnOneOnB1 = false;
        }
        if (playerPawnOneCollider.IsTouching(b2Collider))
        {
            playerPawnOneOnB2 = true;
        }
        else
        {
            playerPawnOneOnB2 = false;
        }
        if (playerPawnOneCollider.IsTouching(b3Collider))
        {
            playerPawnOneOnB3 = true;
        }
        else
        {
            playerPawnOneOnB3 = false;
        }
        if (playerPawnOneCollider.IsTouching(c1Collider))
        {
            playerPawnOneOnC1 = true;
        }
        else
        {
            playerPawnOneOnC1 = false;
        }
        if (playerPawnOneCollider.IsTouching(c2Collider))
        {
            playerPawnOneOnC2 = true;
        }
        else
        {
            playerPawnOneOnC2 = false;
        }
        if (playerPawnOneCollider.IsTouching(d1Collider))
        {
            playerPawnOneOnD1 = true;
        }
        else
        {
            playerPawnOneOnD1 = false;
        }

        //pawn 2 check
        if (playerPawnTwoCollider.IsTouching(a1Collider))
        {
            playerPawnTwoOnA1 = true;
            changeToWinScreen();
        }
        else
        {
            playerPawnTwoOnA1 = false;
        }
        if (playerPawnTwoCollider.IsTouching(a2Collider))
        {
            playerPawnTwoOnA2 = true;
            changeToWinScreen();
        }
        else
        {
            playerPawnTwoOnA2 = false;
        }
        if (playerPawnTwoCollider.IsTouching(a3Collider))
        {
            playerPawnTwoOnA3 = true;
            changeToWinScreen();
        }
        else
        {
            playerPawnTwoOnA3 = false;
        }
        if (playerPawnTwoCollider.IsTouching(a4Collider))
        {
            playerPawnTwoOnA4 = true;
            changeToWinScreen();
        }
        else
        {
            playerPawnTwoOnA4 = false;
        }
        if (playerPawnTwoCollider.IsTouching(b1Collider))
        {
            playerPawnTwoOnB1 = true;
        }
        else
        {
            playerPawnTwoOnB1 = false;
        }
        if (playerPawnTwoCollider.IsTouching(b2Collider))
        {
            playerPawnTwoOnB2 = true;
        }
        else
        {
            playerPawnTwoOnB2 = false;
        }
        if (playerPawnTwoCollider.IsTouching(b3Collider))
        {
            playerPawnTwoOnB3 = true;
        }
        else
        {
            playerPawnTwoOnB3 = false;
        }
        if (playerPawnTwoCollider.IsTouching(b4Collider))
        {
            playerPawnTwoOnB4 = true;
        }
        else
        {
            playerPawnTwoOnB4 = false;
        }
        if (playerPawnTwoCollider.IsTouching(c1Collider))
        {
            playerPawnTwoOnC1 = true;
        }
        else
        {
            playerPawnTwoOnC1 = false;
        }
        if (playerPawnTwoCollider.IsTouching(c2Collider))
        {
            playerPawnTwoOnC2 = true;
        }
        else
        {
            playerPawnTwoOnC2 = false;
        }
        if (playerPawnTwoCollider.IsTouching(c3Collider))
        {
            playerPawnTwoOnC3 = true;
        }
        else
        {
            playerPawnTwoOnC3 = false;
        }
        if (playerPawnTwoCollider.IsTouching(d2Collider))
        {
            playerPawnTwoOnD2 = true;
            changeToWinScreen();
        }
        else
        {
            playerPawnTwoOnD2 = false;
        }

        //Pawn 3 check
        if (playerPawnThreeCollider.IsTouching(a1Collider))
        {
            playerPawnThreeOnA1 = true;
            changeToWinScreen();
        }
        else
        {
            playerPawnThreeOnA1 = false;
        }
        if (playerPawnThreeCollider.IsTouching(a2Collider))
        {
            playerPawnThreeOnA2 = true;
            changeToWinScreen();
        }
        else
        {
            playerPawnThreeOnA2 = false;
        }
        if (playerPawnThreeCollider.IsTouching(a3Collider))
        {
            playerPawnThreeOnA3 = true;
            changeToWinScreen();
        }
        else
        {
            playerPawnThreeOnA3 = false;
        }
        if (playerPawnThreeCollider.IsTouching(a4Collider))
        {
            playerPawnThreeOnA4 = true;
            changeToWinScreen();
        }
        else
        {
            playerPawnThreeOnA4 = false;
        }
        if (playerPawnThreeCollider.IsTouching(b2Collider))
        {
            playerPawnThreeOnB2 = true;
        }
        else
        {
            playerPawnThreeOnB2 = false;
        }
        if (playerPawnThreeCollider.IsTouching(b3Collider))
        {
            playerPawnThreeOnB3 = true;
        }
        else
        {
            playerPawnThreeOnB3 = false;
        }
        if (playerPawnThreeCollider.IsTouching(b4Collider))
        {
            playerPawnThreeOnB4 = true;
        }
        else
        {
            playerPawnThreeOnB4 = false;
        }
        if (playerPawnThreeCollider.IsTouching(c2Collider))
        {
            playerPawnThreeOnC2 = true;
        }
        else
        {
            playerPawnThreeOnC2 = false;
        }
        if (playerPawnThreeCollider.IsTouching(c3Collider))
        {
            playerPawnThreeOnC3 = true;
        }
        else
        {
            playerPawnThreeOnC3 = false;
        }
        if (playerPawnThreeCollider.IsTouching(c4Collider))
        {
            playerPawnThreeOnC4 = true;
        }
        else
        {
            playerPawnThreeOnC4 = false;
        }
        if (playerPawnThreeCollider.IsTouching(d3Collider))
        {
            playerPawnThreeOnD3 = true;
            changeToWinScreen();
        }
        else
        {
            playerPawnThreeOnD3 = false;
        }

        //Pawn 4 check
        if (playerPawnFourCollider.IsTouching(a1Collider))
        {
            playerPawnFourOnA1 = true;
            changeToWinScreen();
        }
        else
        {
            playerPawnFourOnA1 = false;
        }
        if (playerPawnFourCollider.IsTouching(a2Collider))
        {
            playerPawnFourOnA2 = true;
            changeToWinScreen();
        }
        else
        {
            playerPawnFourOnA2 = false;
        }
        if (playerPawnFourCollider.IsTouching(a3Collider))
        {
            playerPawnFourOnA3 = true;
            changeToWinScreen();
        }
        else
        {
            playerPawnFourOnA3 = false;
        }
        if (playerPawnFourCollider.IsTouching(a4Collider))
        {
            playerPawnFourOnA4 = true;
            changeToWinScreen();
        }
        else
        {
            playerPawnFourOnA4 = false;
        }
        if (playerPawnFourCollider.IsTouching(b2Collider))
        {
            playerPawnFourOnB2 = true;
        }
        else
        {
            playerPawnFourOnB2 = false;
        }
        if (playerPawnFourCollider.IsTouching(b3Collider))
        {
            playerPawnFourOnB3 = true;
        }
        else
        {
            playerPawnFourOnB3 = false;
        }
        if (playerPawnFourCollider.IsTouching(b4Collider))
        {
            playerPawnFourOnB4 = true;
        }
        else
        {
            playerPawnFourOnB4 = false;
        }
        if (playerPawnFourCollider.IsTouching(c3Collider))
        {
            playerPawnFourOnC3 = true;
        }
        else
        {
            playerPawnFourOnC3 = false;
        }
        if (playerPawnFourCollider.IsTouching(c4Collider))
        {
            playerPawnFourOnC4 = true;
        }
        else
        {
            playerPawnFourOnC4 = false;
        }
        if (playerPawnFourCollider.IsTouching(d4Collider))
        {
            playerPawnFourOnD4 = true;
            changeToWinScreen();
        }
        else
        {
            playerPawnFourOnD4 = false;
        }
    }

    void AIPawnCheck()
    {
         //AI Pawn 1 check
        if (AIPawnOneCollider.IsTouching(a1Collider))
        {
            AIPawnOneOnA1 = true;
        }
        else
        {
            AIPawnOneOnA1 = false;
        }
        
        if (AIPawnOneCollider.IsTouching(b1Collider))
        {
            AIPawnOneOnB1 = true;
        }
        else
        {
            AIPawnOneOnB1 = false;
        }
        if (AIPawnOneCollider.IsTouching(b2Collider))
        {
            AIPawnOneOnB2 = true;
        }
        else
        {
            AIPawnOneOnB2 = false;
        }
        if (AIPawnOneCollider.IsTouching(c1Collider))
        {
            AIPawnOneOnC1 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnOneOnC1 = false;
        }
        if (AIPawnOneCollider.IsTouching(c2Collider))
        {
            AIPawnOneOnC2 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnOneOnC2 = false;
        }
        if (AIPawnOneCollider.IsTouching(c3Collider))
        {
            AIPawnOneOnC3 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnOneOnC3 = false;
        }
        if (AIPawnOneCollider.IsTouching(d1Collider))
        {
            AIPawnOneOnD1 = true;
        }
        else
        {
            AIPawnOneOnD1 = false;
        }
        if (AIPawnOneCollider.IsTouching(d2Collider))
        {
            AIPawnOneOnD2 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnOneOnD2 = false;
        }
        if (AIPawnOneCollider.IsTouching(d3Collider))
        {
            AIPawnOneOnD3 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnOneOnD3 = false;
        }
        if (AIPawnOneCollider.IsTouching(d4Collider))
        {
            AIPawnOneOnD4 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnOneOnD4 = false;
        }

        //pawn 2 check
        if (AIPawnTwoCollider.IsTouching(a2Collider))
        {
            AIPawnTwoOnA2 = true;
        }
        else
        {
            AIPawnTwoOnA2 = false;
        }
        if (AIPawnTwoCollider.IsTouching(b1Collider))
        {
            AIPawnTwoOnB1 = true;
        }
        else
        {
            AIPawnTwoOnB1 = false;
        }
        if (AIPawnTwoCollider.IsTouching(b2Collider))
        {
            AIPawnTwoOnB2 = true;
        }
        else
        {
            AIPawnTwoOnB2 = false;
        }
        if (AIPawnTwoCollider.IsTouching(b3Collider))
        {
            AIPawnTwoOnB3 = true;
        }
        else
        {
            AIPawnTwoOnB3 = false;
        }
        if (AIPawnTwoCollider.IsTouching(c1Collider))
        {
            AIPawnTwoOnC1 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnTwoOnC1 = false;
        }
        if (AIPawnTwoCollider.IsTouching(c2Collider))
        {
            AIPawnTwoOnC2 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnTwoOnC2 = false;
        }
        
        if (AIPawnTwoCollider.IsTouching(c3Collider))
        {
            AIPawnTwoOnC3 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnTwoOnC3 = false;
        }

        if (AIPawnTwoCollider.IsTouching(c4Collider))
        {
            AIPawnTwoOnC4 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnTwoOnC4 = false;
        }
        if (AIPawnTwoCollider.IsTouching(d1Collider))
        {
            AIPawnTwoOnD1 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnTwoOnD1 = false;
        }
        if (AIPawnTwoCollider.IsTouching(d2Collider))
        {
            AIPawnTwoOnD2 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnTwoOnD2 = false;
        }
        
        if (AIPawnTwoCollider.IsTouching(d3Collider))
        {
            AIPawnTwoOnD3 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnTwoOnD3 = false;
        }

        if (AIPawnTwoCollider.IsTouching(d4Collider))
        {
            AIPawnTwoOnD4 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnTwoOnD4 = false;
        }

        //Pawn 3 check
        if (AIPawnThreeCollider.IsTouching(a3Collider))
        {
            AIPawnThreeOnA3 = true;
        }
        else
        {
            AIPawnThreeOnA3 = false;
        }
        if (AIPawnThreeCollider.IsTouching(b2Collider))
        {
            AIPawnThreeOnB2 = true;
        }
        else
        {
            AIPawnThreeOnB2 = false;
        }
        if (AIPawnThreeCollider.IsTouching(b3Collider))
        {
            AIPawnThreeOnB3 = true;
        }
        else
        {
            AIPawnThreeOnB3 = false;
        }
        if (AIPawnThreeCollider.IsTouching(b4Collider))
        {
            AIPawnThreeOnB4 = true;
        }
        else
        {
            AIPawnThreeOnB4 = false;
        }
        if (AIPawnThreeCollider.IsTouching(c1Collider))
        {
            AIPawnThreeOnC1 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnThreeOnC1 = false;
        }
        if (AIPawnThreeCollider.IsTouching(c2Collider))
        {
            AIPawnThreeOnC2 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnThreeOnC2 = false;
        }
        if (AIPawnThreeCollider.IsTouching(c3Collider))
        {
            AIPawnThreeOnC3 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnThreeOnC3 = false;
        }
        if (AIPawnThreeCollider.IsTouching(c4Collider))
        {
            AIPawnThreeOnC4 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnThreeOnC4 = false;
        }
        if (AIPawnThreeCollider.IsTouching(d1Collider))
        {
            AIPawnThreeOnD1 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnThreeOnD1 = false;
        }
        if (AIPawnThreeCollider.IsTouching(d2Collider))
        {
            AIPawnThreeOnD2 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnThreeOnD2 = false;
        }
        if (AIPawnThreeCollider.IsTouching(d3Collider))
        {
            AIPawnThreeOnD3 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnThreeOnD3 = false;
        }
        if (AIPawnThreeCollider.IsTouching(d4Collider))
        {
            AIPawnThreeOnD4 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnThreeOnD4 = false;
        }

        //Pawn 4 check
        if (AIPawnFourCollider.IsTouching(a4Collider))
        {
            AIPawnFourOnA4 = true;
        }
        else
        {
            AIPawnFourOnA4 = false;
        }
        
        if (AIPawnFourCollider.IsTouching(b3Collider))
        {
            AIPawnFourOnB3 = true;
        }
        else
        {
            AIPawnFourOnB3 = false;
        }
        if (AIPawnFourCollider.IsTouching(b4Collider))
        {
            AIPawnFourOnB4 = true;
        }
        else
        {
            AIPawnFourOnB4 = false;
        }
        if (AIPawnFourCollider.IsTouching(c2Collider))
        {
            AIPawnFourOnC2 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnFourOnC2 = false;
        }
        if (AIPawnFourCollider.IsTouching(c3Collider))
        {
            AIPawnFourOnC3 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnFourOnC3 = false;
        }
        if (AIPawnFourCollider.IsTouching(c4Collider))
        {
            AIPawnFourOnC4 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnFourOnC4 = false;
        }
        if (AIPawnFourCollider.IsTouching(d1Collider))
        {
            AIPawnFourOnD1 = true;
        }
        else
        {
            AIPawnFourOnD1 = false;
        }
        if (AIPawnFourCollider.IsTouching(d2Collider))
        {
            AIPawnFourOnD2 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnFourOnD2 = false;
        }
        if (AIPawnFourCollider.IsTouching(d3Collider))
        {
            AIPawnFourOnD3 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnFourOnD3 = false;
        }
        if (AIPawnFourCollider.IsTouching(d4Collider))
        {
            AIPawnOneOnD4 = true;
            changeToLoseScreen();
        }
        else
        {
            AIPawnOneOnD4 = false;
        }
    }

    void changeToWinScreen()
    {
        SceneManager.LoadScene("gameWinScreen");
    }

    void changeToLoseScreen()
    {
        SceneManager.LoadScene("gameLoseScreen");
    }
}
