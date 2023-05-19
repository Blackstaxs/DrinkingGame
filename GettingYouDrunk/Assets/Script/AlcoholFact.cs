using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlcoholFact : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public string[] WallText;

    private void Start()
    {
        UpdateWallText();
    }

    /*
    public void UpdateWallText()
    {
        textMeshPro.text = WallText[WallIndex];
        WallIndex = (WallIndex + 1) % WallText.Length;
    }
    */

    public void UpdateWallText()
    {
        int randomIndex = Random.Range(0, WallText.Length);
        textMeshPro.text = WallText[randomIndex];
    }

    public void LoadMemoryScene()
    {
        SceneManager.LoadScene("Memory");
    }
}
