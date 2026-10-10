using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonBehaviour : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void OnStartButtonPressed()
    {
        Debug.Log("Start Button Pressed");
        SceneManager.LoadScene("Play");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
