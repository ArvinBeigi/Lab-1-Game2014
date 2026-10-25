
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;

    void Start()
    {
        Debug.Log("Score: " + score);
    }

    public void AddPoints(int points)
    {
        score += points;
        Debug.Log("Score: " + score);
    }

    public int GetScore()
    {
        return score;
    }
}
