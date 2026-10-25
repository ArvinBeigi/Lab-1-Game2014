
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    public int startingLives = 3;

    private int currentLives;

    void Start()
    {
        currentLives = startingLives;
        Debug.Log("Lives: " + currentLives);
    }

    public void LoseLife()
    {
        if (currentLives <= 0)
            return;

        currentLives--;

        Debug.Log("Lives remaining: " + currentLives);

        if (currentLives <= 0)
        {
            Debug.Log("Game Over!");
        }
    }

    public int GetCurrentLives()
    {
        return currentLives;
    }
}
