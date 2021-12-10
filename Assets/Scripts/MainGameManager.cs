using UnityEngine;
using UnityEngine.UI;

public class MainGameManager : MonoBehaviour
{
    public static MainGameManager Instance;
    [SerializeField] private Text nameText;

    private Text bestScorePlayerName;

    private string playerName;
    private int currentScore;
    private int bestScore;

    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);


    }

    public void GetName()
    {
        playerName = nameText.text;
    }

    public string SetName()
    {
        return playerName;
    }

    public int SetScore(int points)
    {
        currentScore = points;
        return currentScore;
    }

    public void DisplayScore()
    {
        bestScorePlayerName = GameObject.Find("PlayerName").GetComponent<Text>();

        if (currentScore > bestScore)
            bestScore = currentScore;

        bestScorePlayerName.text = $"Best Score: {SetName()}: {bestScore}";
    }
}