using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boardState : MonoBehaviour
{
    public GameObject playerPawnOne;
    public GameObject playerPawnTwo;
    public GameObject playerPawnThree;
    public GameObject AIPawnOne;
    public GameObject AIPawnTwo;
    public GameObject AIPawnThree;
    public Collider2D playerPawnOneCollider;
    public Collider2D playerPawnTwoCollider;
    public Collider2D playerPawnThreeCollider;
    public Collider2D AIPawnOneCollider;
    public Collider2D AIPawnTwoCollider;
    public Collider2D AIPawnThreeCollider;
    public Collider2D a1Collider;
    public Collider2D a2Collider;
    public Collider2D a3Collider;
    public Collider2D b1Collider;
    public Collider2D b2Collider;
    public Collider2D b3Collider;
    public Collider2D c1Collider;
    public Collider2D c2Collider;
    public Collider2D c3Collider;
    public bool playerPawnOneOnA1;
    public bool playerPawnOneOnA2;
    public bool playerPawnOneOnA3;
    public bool playerPawnOneOnB1;
    public bool playerPawnOneOnB2;
    public bool playerPawnOneOnC1;
    public bool playerPawnTwoOnA1;
    public bool playerPawnTwoOnA2;
    public bool playerPawnTwoOnA3;
    public bool playerPawnTwoOnB1;
    public bool playerPawnTwoOnB2;
    public bool playerPawnTwoOnB3;
    public bool playerPawnTwoOnC2;
    public bool playerPawnThreeOnA1;
    public bool playerPawnThreeOnA2;
    public bool playerPawnThreeOnA3;
    public bool playerPawnThreeOnB2;
    public bool playerPawnThreeOnB3;
    public bool playerPawnThreeOnC3;
    public bool AIPawnOneOnA1;
    public bool AIPawnOneOnB1;
    public bool AIPawnOneOnB2;
    public bool AIPawnOneOnC1;
    public bool AIPawnOneOnC2;
    public bool AIPawnOneOnC3;
    public bool AIPawnTwoOnA2;
    public bool AIPawnTwoOnB1;
    public bool AIPawnTwoOnB2;
    public bool AIPawnTwoOnB3;
    public bool AIPawnTwoOnC1;
    public bool AIPawnTwoOnC2;
    public bool AIPawnTwoOnC3;
    public bool AIPawnThreeOnA3;
    public bool AIPawnThreeOnB2;
    public bool AIPawnThreeOnB3;
    public bool AIPawnThreeOnC1;
    public bool AIPawnThreeOnC2;
    public bool AIPawnThreeOnC3;
    int numberofPlayerPawnsLeft;
    int numberofAIPawnsLeft;
    bool playerPawnOneCantMove;
    bool playerPawnTwoCantMove;
    bool playerPawnThreeCantMove;
    bool AIPawnOneCantMove;
    bool AIPawnTwoCantMove;
    bool AIPawnThreeCantMove;

    // Start is called before the first frame update
    void Start()
    {
        playerPawnOne = GameObject.FindWithTag("Player-1");
        playerPawnTwo = GameObject.FindWithTag("Player-2");
        playerPawnThree = GameObject.FindWithTag("Player-3");
        AIPawnOne = GameObject.FindWithTag("AI-Pawn-1");
        AIPawnTwo = GameObject.FindWithTag("AI-Pawn-2");
        AIPawnThree = GameObject.FindWithTag("AI-Pawn-3");
        playerPawnOneOnA1 = false;
        playerPawnOneOnA2 = false;
        playerPawnOneOnA3 = false;
        playerPawnOneOnB1 = false;
        playerPawnOneOnB2 = false;
        playerPawnOneOnC1 = false;
        playerPawnTwoOnA1 = false;
        playerPawnTwoOnA2 = false;
        playerPawnTwoOnA3 = false; 
        playerPawnTwoOnB1 = false;
        playerPawnTwoOnB2 = false;
        playerPawnTwoOnB3 = false;  
        playerPawnTwoOnC2 = false; 
        playerPawnThreeOnA1 = false;
        playerPawnThreeOnA2 = false;
        playerPawnThreeOnA3 = false;
        playerPawnThreeOnB2 = false;
        playerPawnThreeOnB3 = false;
        playerPawnThreeOnC3 = false;

        AIPawnOneOnA1  = false;
        AIPawnOneOnB1 = false;
        AIPawnOneOnB2 = false;
        AIPawnOneOnC1 = false;
        AIPawnOneOnC2 = false;
        AIPawnOneOnC3 = false;
        AIPawnTwoOnA2 = false;
        AIPawnTwoOnB1 = false;
        AIPawnTwoOnB2 = false;
        AIPawnTwoOnB3 = false;
        AIPawnTwoOnC1 = false;
        AIPawnTwoOnC2 = false;
        AIPawnTwoOnC3 = false;
        AIPawnThreeOnA3 = false;
        AIPawnThreeOnB2 = false;
        AIPawnThreeOnB3 = false;
        AIPawnThreeOnC1 = false;
        AIPawnThreeOnC2 = false;
        AIPawnThreeOnC3 = false;
    }

    // Update is called once per frame
    void Update()
    {   
        numberofPlayerPawnsLeft = GameObject.FindWithTag("GameController").GetComponent<AIMove>().playerPawnNumber;
        numberofAIPawnsLeft = GameObject.FindWithTag("GameController").GetComponent<playerMove>().AIPawnNumber;
        playerPawnOneCantMove = GameObject.FindWithTag("GameController").GetComponent<playerMove>().pawnOneCantMove;
        playerPawnTwoCantMove = GameObject.FindWithTag("GameController").GetComponent<playerMove>().pawnTwoCantMove;
        playerPawnThreeCantMove = GameObject.FindWithTag("GameController").GetComponent<playerMove>().pawnThreeCantMove;
        AIPawnOneCantMove = GameObject.FindWithTag("GameController").GetComponent<AIMove>().pawnOneCantMove;
        AIPawnTwoCantMove = GameObject.FindWithTag("GameController").GetComponent<AIMove>().pawnTwoCantMove;
        AIPawnThreeCantMove = GameObject.FindWithTag("GameController").GetComponent<AIMove>().pawnThreeCantMove;
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
        if(playerPawnOneCantMove && playerPawnTwoCantMove && playerPawnThreeCantMove)
        {
            changeToLoseScreen();
        }
        if(!playerPawnOne.active)
        {
            if(playerPawnTwoCantMove && playerPawnThreeCantMove)
            {
                changeToLoseScreen();
            }
        }
        if(!playerPawnTwo.active)
        {
            if(playerPawnOneCantMove && playerPawnThreeCantMove)
            {
                changeToLoseScreen();
            }
        }
        if(!playerPawnThree.active)
        {
            if(playerPawnOneCantMove && playerPawnTwoCantMove)
            {
                changeToLoseScreen();
            }
        }
        if(!playerPawnOne.active && !playerPawnTwo.active)
        {
            if(playerPawnThreeCantMove)
            {
                changeToLoseScreen();
            }
        }
        if(!playerPawnOne.active && !playerPawnThree.active)
        {
            if(playerPawnTwoCantMove)
            {
                changeToLoseScreen();
            }
        }
        else if(!playerPawnTwo.active && !playerPawnThree.active)
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
            if(AIPawnTwoCantMove && AIPawnThreeCantMove)
            {
                changeToWinScreen();
            }
        }
        if(!AIPawnTwo.active)
        {
            if(AIPawnOneCantMove && AIPawnThreeCantMove)
            {
                changeToWinScreen();
            }
        }
        if(!AIPawnThree.active)
        {
            if(AIPawnTwoCantMove && AIPawnThreeCantMove)
            {
                changeToWinScreen();
            }
        }
        if(!AIPawnOne.active && !AIPawnTwo.active)
        {
            if(AIPawnThreeCantMove)
            {
                changeToWinScreen();
            }
        }
        if(!AIPawnOne.active && !AIPawnThree.active)
        {
            if(AIPawnTwoCantMove)
            {
                changeToWinScreen();
            }
        }
        if(!AIPawnTwo.active && !AIPawnThree.active)
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
        if (playerPawnOneCollider.IsTouching(c1Collider))
        {
            playerPawnOneOnC1 = true;
        }
        else
        {
            playerPawnOneOnC1 = false;
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
        if (playerPawnTwoCollider.IsTouching(c2Collider))
        {
            playerPawnTwoOnC2 = true;
        }
        else
        {
            playerPawnTwoOnC2 = false;
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
        if (playerPawnThreeCollider.IsTouching(c3Collider))
        {
            playerPawnThreeOnC3 = true;
        }
        else
        {
            playerPawnThreeOnC3 = false;
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
