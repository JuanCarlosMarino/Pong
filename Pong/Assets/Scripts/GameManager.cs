using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject Ball;

    [Header("Player 1")]
    public GameObject GamePad1;
    public GameObject Goal1;

    [Header("Player 2")]
    public GameObject GamePad2;
    public GameObject Goal2;

    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    private int Player1Score;
    private int Player2Score;

    public void Player1Scored(){
        Player1Score++;
        Player1Text.GetComponent<TMP_Text>().text= Player1Score.ToString();
        ResetPosition();
    }
    public void Player2Scored(){
        Player2Score++;
        Player2Text.GetComponent<TMP_Text>().text= Player2Score.ToString();
        ResetPosition();
    }
    
    private void ResetPosition()
    {
        Ball.GetComponent<BallMovement>().Reset();
        GamePad1.GetComponent<PadMovement>().Reset();
        GamePad2.GetComponent<PadMovement>().Reset();
    }
    
}
