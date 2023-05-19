using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    public void redPressed()
    {
        BombDropper.instance.addtoAnswer(2);
        Debug.Log("RED PRESSED");
        Debug.Log("_____________");
        foreach (int item in BombDropper.instance.Answer)
        {
            Debug.Log(item);
        }
        Debug.Log("_____________");
    }

    public void bluePressed()
    {
        BombDropper.instance.addtoAnswer(3);
        Debug.Log("BLUE PRESSED");
        Debug.Log("_____________");
        foreach (int item in BombDropper.instance.Answer)
        {
            Debug.Log(item);
        }
        Debug.Log("_____________");
    }

    public void greenPressed()
    {
        BombDropper.instance.addtoAnswer(1);
        Debug.Log("GREEN PRESSED");
        Debug.Log("_____________");
        foreach (int item in BombDropper.instance.Answer)
        {
            Debug.Log(item);
        }
        Debug.Log("_____________");
    }

    public void yellowPressed()
    {
        BombDropper.instance.addtoAnswer(0);
        Debug.Log("YELLOW PRESSED");
        Debug.Log("_____________");
        foreach (int item in BombDropper.instance.Answer)
        {
            Debug.Log(item);
        }
        Debug.Log("_____________");
    }

    public void checkPressed()
    {
        Debug.Log("CHECK PRESSED");
        Debug.Log("_____________");
        List<int> list1 = BombDropper.instance.Answer;
        List<int> list2 = BombDropper.instance.Sequence;
        if (list1.SequenceEqual(list2))
        {
            Debug.Log("CORRECT");
            BombDropper.instance.Answer.Clear();
            StartCoroutine(BombDropper.instance.DeactivateAfterDelay(BombDropper.instance.goodBt));
            Invoke("keepGoing", 1f);
        }
        else
        {
            Debug.Log("MAL");
            StartCoroutine(BombDropper.instance.DeactivateAfterDelay(BombDropper.instance.badBt));
            Invoke("LoadChooseScene", 1f);
        }
    }

    public void LoadDrinkScene()
    {
        SceneManager.LoadScene("Drink");
    }

    public void LoadMemoryScene()
    {
        SceneManager.LoadScene("Memory");
    }

    public void LoadChooseScene()
    {
        SceneManager.LoadScene("Choose");
    }

    void keepGoing()
    {
        BombDropper.instance.PlayBOOm();
    }
}
