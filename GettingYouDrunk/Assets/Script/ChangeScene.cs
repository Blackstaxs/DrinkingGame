using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMemoryScene()
    {
        SceneManager.LoadScene("Memory");
    }

    public void LoadDrinkScene()
    {
        SceneManager.LoadScene("Drink");
    }

    public void LoadChallengeScene()
    {
        SceneManager.LoadScene("Challenge");
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("Main");
    }
}
