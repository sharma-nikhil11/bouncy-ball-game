using UnityEngine;
using TMPro; // <-- Import TextMesh Pro

public class GameManager : MonoBehaviour
{
    [Header("Game Elements")]
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    [Header("UI Elements")]
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI computerScoreText;

    private int _playerScore;
    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;
        UpdateScoreUI();
        ResetRound();
    }

    public void ComputerScores()
    {
        _computerScore++;
        UpdateScoreUI();
        ResetRound();
    }

    private void UpdateScoreUI()
    {
        playerScoreText.text = _playerScore.ToString();
        computerScoreText.text = _computerScore.ToString();
    }

    private void ResetRound()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }
}