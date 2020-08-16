using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Player1Text.GetComponent<TextMeshPro>().text= Player1Score.ToString();
    }
    public void Player2Scored(){
        Player2Score++;
        Player2Text.GetComponent<TextMeshPro>().text= Player2Score.ToString();
    }
    // Start is called before the first frame update
    
}
