using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GameManager : MonoBehaviour
{
    [Header("Pong")] public GameObject pong;

    [Header("Player 1")] public GameObject player1Controller;
    public GameObject plater1Goal;
    
    [Header("Player 2")]
    public GameObject player2Controller;
    public GameObject plater2Goal;

    [Header("Score Ui")] public GameObject Player1Text;
    public GameObject Player2Text;

    private int Player1Score;
    private int Player2Score;

    public void Player1Scored()
    {
        Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
    }
    public void Player2Scored()
    {
        Player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        pong.GetComponent<Pong>().Reset();
        player1Controller.GetComponent<PlayerControls>().Reset();
        player2Controller.GetComponent<PlayerControls>().Reset();
    }
}
