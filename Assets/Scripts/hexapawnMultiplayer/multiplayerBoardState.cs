using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class multiplayerBoardState : MonoBehaviour
{
    public GameObject playerOnePawnOne;
    public GameObject playerOnePawnTwo;
    public GameObject playerOnePawnThree;
    public GameObject playerTwoPawnOne;
    public GameObject playerTwoPawnTwo;
    public GameObject playerTwoPawnThree;
    public Collider2D playerOnePawnOneCollider;
    public Collider2D playerOnePawnTwoCollider;
    public Collider2D playerOnePawnThreeCollider;
    public Collider2D playerTwoPawnOneCollider;
    public Collider2D playerTwoPawnTwoCollider;
    public Collider2D playerTwoPawnThreeCollider;
    public Collider2D a1Collider;
    public Collider2D a2Collider;
    public Collider2D a3Collider;
    public Collider2D b1Collider;
    public Collider2D b2Collider;
    public Collider2D b3Collider;
    public Collider2D c1Collider;
    public Collider2D c2Collider;
    public Collider2D c3Collider;
    public bool playerOnePawnOneOnA1;
    public bool playerOnePawnOneOnA2;
    public bool playerOnePawnOneOnA3;
    public bool playerOnePawnOneOnB1;
    public bool playerOnePawnOneOnB2;
    public bool playerOnePawnOneOnC1;
    public bool playerOnePawnTwoOnA1;
    public bool playerOnePawnTwoOnA2;
    public bool playerOnePawnTwoOnA3;
    public bool playerOnePawnTwoOnB1;
    public bool playerOnePawnTwoOnB2;
    public bool playerOnePawnTwoOnB3;
    public bool playerOnePawnTwoOnC2;
    public bool playerOnePawnThreeOnA1;
    public bool playerOnePawnThreeOnA2;
    public bool playerOnePawnThreeOnA3;
    public bool playerOnePawnThreeOnB2;
    public bool playerOnePawnThreeOnB3;
    public bool playerOnePawnThreeOnC3;
    public bool playerTwoPawnOneOnA1;
    public bool playerTwoPawnOneOnB1;
    public bool playerTwoPawnOneOnB2;
    public bool playerTwoPawnOneOnC1;
    public bool playerTwoPawnOneOnC2;
    public bool playerTwoPawnOneOnC3;
    public bool playerTwoPawnTwoOnA2;
    public bool playerTwoPawnTwoOnB1;
    public bool playerTwoPawnTwoOnB2;
    public bool playerTwoPawnTwoOnB3;
    public bool playerTwoPawnTwoOnC1;
    public bool playerTwoPawnTwoOnC2;
    public bool playerTwoPawnTwoOnC3;
    public bool playerTwoPawnThreeOnA3;
    public bool playerTwoPawnThreeOnB2;
    public bool playerTwoPawnThreeOnB3;
    public bool playerTwoPawnThreeOnC1;
    public bool playerTwoPawnThreeOnC2;
    public bool playerTwoPawnThreeOnC3;
    int playerOnePawnsLeft;
    int playerTwoPawnsLeft;
    bool playerOnePawnOneCantMove;
    bool playerOnePawnTwoCantMove;
    bool playerOnePawnThreeCantMove;
    bool playerTwoPawnOneCantMove;
    bool playerTwoPawnTwoCantMove;
    bool playerTwoPawnThreeCantMove;
    bool playerOneLoseOnTime;
    bool playerTwoLoseOnTime;

    // Start is called before the first frame update
    void Start()
    {
        playerOnePawnOne = GameObject.FindWithTag("Player-1");
        playerOnePawnTwo = GameObject.FindWithTag("Player-2");
        playerOnePawnThree = GameObject.FindWithTag("Player-3");
        playerTwoPawnOne = GameObject.FindWithTag("player-2-pawn-1");
        playerTwoPawnTwo = GameObject.FindWithTag("player-2-pawn-2");
        playerTwoPawnThree = GameObject.FindWithTag("player-2-pawn-3");
        playerOnePawnOneOnA1 = false;
        playerOnePawnOneOnA2 = false;
        playerOnePawnOneOnA3 = false;
        playerOnePawnOneOnB1 = false;
        playerOnePawnOneOnB2 = false;
        playerOnePawnOneOnC1 = false;
        playerOnePawnTwoOnA1 = false;
        playerOnePawnTwoOnA2 = false;
        playerOnePawnTwoOnA3 = false; 
        playerOnePawnTwoOnB1 = false;
        playerOnePawnTwoOnB2 = false;
        playerOnePawnTwoOnB3 = false;  
        playerOnePawnTwoOnC2 = false; 
        playerOnePawnThreeOnA1 = false;
        playerOnePawnThreeOnA2 = false;
        playerOnePawnThreeOnA3 = false;
        playerOnePawnThreeOnB2 = false;
        playerOnePawnThreeOnB3 = false;
        playerOnePawnThreeOnC3 = false;

        playerTwoPawnOneOnA1  = false;
        playerTwoPawnOneOnB1 = false;
        playerTwoPawnOneOnB2 = false;
        playerTwoPawnOneOnC1 = false;
        playerTwoPawnOneOnC2 = false;
        playerTwoPawnOneOnC3 = false;
        playerTwoPawnTwoOnA2 = false;
        playerTwoPawnTwoOnB1 = false;
        playerTwoPawnTwoOnB2 = false;
        playerTwoPawnTwoOnB3 = false;
        playerTwoPawnTwoOnC1 = false;
        playerTwoPawnTwoOnC2 = false;
        playerTwoPawnTwoOnC3 = false;
        playerTwoPawnThreeOnA3 = false;
        playerTwoPawnThreeOnB2 = false;
        playerTwoPawnThreeOnB3 = false;
        playerTwoPawnThreeOnC1 = false;
        playerTwoPawnThreeOnC2 = false;
        playerTwoPawnThreeOnC3 = false;

    }

    // Update is called once per frame
    void Update()
    {   
        playerOnePawnsLeft = GameObject.FindWithTag("GameController").GetComponent<playerTwoMove>().playerOnePawnNumber;
        playerTwoPawnsLeft = GameObject.FindWithTag("GameController").GetComponent<playerOneMove>().playerTwoPawnNumber;
        playerOnePawnOneCantMove = GameObject.FindWithTag("GameController").GetComponent<playerOneMove>().pawnOneCantMove;
        playerOnePawnTwoCantMove = GameObject.FindWithTag("GameController").GetComponent<playerOneMove>().pawnTwoCantMove;
        playerOnePawnThreeCantMove = GameObject.FindWithTag("GameController").GetComponent<playerOneMove>().pawnThreeCantMove;
        playerTwoPawnOneCantMove = GameObject.FindWithTag("GameController").GetComponent<playerTwoMove>().pawnOneCantMove;
        playerTwoPawnTwoCantMove = GameObject.FindWithTag("GameController").GetComponent<playerTwoMove>().pawnTwoCantMove;
        playerTwoPawnThreeCantMove = GameObject.FindWithTag("GameController").GetComponent<playerTwoMove>().pawnThreeCantMove;
        playerOneLoseOnTime = GameObject.FindWithTag("GameController").GetComponent<playerOneMove>().timeLoss;
        playerTwoLoseOnTime = GameObject.FindWithTag("GameController").GetComponent<playerTwoMove>().timeLoss;
        playerOnePawnCheck();
        playerTwoPawnCheck();
        if(playerOneLoseOnTime)
        {
            StartCoroutine(playerTwoWins());
        }
        if(playerTwoLoseOnTime)
        {
            StartCoroutine(playerOneWins());
        }
        if(playerOnePawnsLeft == 0)
        {
            StartCoroutine(playerTwoWins());
        }
        if(playerTwoPawnsLeft == 0)
        {
            StartCoroutine(playerOneWins());
        }
        if(playerOnePawnOneCantMove && playerOnePawnTwoCantMove && playerOnePawnThreeCantMove)
        {
            StartCoroutine(playerTwoWins());
        }
        if(!playerOnePawnOne.active)
        {
            if(playerOnePawnTwoCantMove && playerOnePawnThreeCantMove)
            {
                StartCoroutine(playerTwoWins());
            }
        }
        if(!playerOnePawnTwo.active)
        {
            if(playerOnePawnOneCantMove && playerOnePawnThreeCantMove)
            {
                StartCoroutine(playerTwoWins());
            }
        }
        if(!playerOnePawnThree.active)
        {
            if(playerOnePawnOneCantMove && playerOnePawnTwoCantMove)
            {
                StartCoroutine(playerTwoWins());
            }
        }
        if(!playerOnePawnOne.active && !playerOnePawnTwo.active)
        {
            if(playerOnePawnThreeCantMove)
            {
                StartCoroutine(playerTwoWins());
            }
        }
        if(!playerOnePawnOne.active && !playerOnePawnThree.active)
        {
            if(playerOnePawnTwoCantMove)
            {
                StartCoroutine(playerTwoWins());
            }
        }
        else if(!playerOnePawnTwo.active && !playerOnePawnThree.active)
        {
            if(playerOnePawnOneCantMove)
            {
                StartCoroutine(playerTwoWins());
            } 
        }
        if(playerTwoPawnOneCantMove && playerTwoPawnTwoCantMove && playerTwoPawnThreeCantMove)
        {
            StartCoroutine(playerOneWins());
        }
        if(!playerTwoPawnOne.active)
        {
            if(playerTwoPawnTwoCantMove && playerTwoPawnThreeCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }
        if(!playerTwoPawnTwo.active)
        {
            if(playerTwoPawnOneCantMove && playerTwoPawnThreeCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }
        if(!playerTwoPawnThree.active)
        {
            if(playerTwoPawnTwoCantMove && playerTwoPawnThreeCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }
        if(!playerTwoPawnOne.active && !playerTwoPawnTwo.active)
        {
            if(playerTwoPawnThreeCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }
        if(!playerTwoPawnOne.active && !playerTwoPawnThree.active)
        {
            if(playerTwoPawnTwoCantMove)
            {
                StartCoroutine(playerOneWins());
            }
        }
        if(!playerTwoPawnTwo.active && !playerTwoPawnThree.active)
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
        if (playerOnePawnOneCollider.IsTouching(c1Collider))
        {
            playerOnePawnOneOnC1 = true;
        }
        else
        {
            playerOnePawnOneOnC1 = false;
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
        if (playerOnePawnTwoCollider.IsTouching(c2Collider))
        {
            playerOnePawnTwoOnC2 = true;
        }
        else
        {
            playerOnePawnTwoOnC2 = false;
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
        if (playerOnePawnThreeCollider.IsTouching(c3Collider))
        {
            playerOnePawnThreeOnC3 = true;
        }
        else
        {
            playerOnePawnThreeOnC3 = false;
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
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnOneOnC1 = false;
        }
        if (playerTwoPawnOneCollider.IsTouching(c2Collider))
        {
            playerTwoPawnOneOnC2 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnOneOnC2 = false;
        }
        if (playerTwoPawnOneCollider.IsTouching(c3Collider))
        {
            playerTwoPawnOneOnC3 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnOneOnC3 = false;
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
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnTwoOnC1 = false;
        }
        if (playerTwoPawnTwoCollider.IsTouching(c2Collider))
        {
            playerTwoPawnTwoOnC2 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnTwoOnC2 = false;
        }
        
        if (playerTwoPawnTwoCollider.IsTouching(c3Collider))
        {
            playerTwoPawnTwoOnC3 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnTwoOnC3 = false;
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
        if (playerTwoPawnThreeCollider.IsTouching(c1Collider))
        {
            playerTwoPawnThreeOnC1 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnThreeOnC1 = false;
        }
        if (playerTwoPawnThreeCollider.IsTouching(c2Collider))
        {
            playerTwoPawnThreeOnC2 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnThreeOnC2 = false;
        }
        if (playerTwoPawnThreeCollider.IsTouching(c3Collider))
        {
            playerTwoPawnThreeOnC3 = true;
            StartCoroutine(playerTwoWins());
        }
        else
        {
            playerTwoPawnThreeOnC3 = false;
        }
    }

    public IEnumerator playerOneWins()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        SceneManager.LoadScene("playerOneWins");
    }

    public IEnumerator playerTwoWins()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        SceneManager.LoadScene("playerTwoWins");
    }
}
