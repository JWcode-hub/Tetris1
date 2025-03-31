using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;
    public TextMeshProUGUI scoreText;
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        playerNameText.text = "Player: " + PlayerPrefs.GetString("PlayerName", "Guest");
    }

    void Update()
    {
        scoreText.text = "Score: " + gameManager.GetScore();
    }
}