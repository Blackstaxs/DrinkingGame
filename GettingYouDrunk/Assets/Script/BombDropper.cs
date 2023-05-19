using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDropper : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Thebomb;
    private int numBombs = 2;
    private int startHeight = 2;
    private int intervalo = 5;
    public List<int> Sequence = new List<int>();
    public GameObject backOnUI;
    public GameObject goodBt;
    public GameObject badBt;
    private float waitForUI = 1f;

    public static BombDropper instance;
    public List<int> Answer = new List<int>();

    void Start()
    {
        PlayBOOm();
        //AddRandomValuesToList(numBombs);
        //Invoke("spawnBombs", 5f);
        //Invoke("activateUI", waitForUI + 5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {
        goodBt.SetActive(false);
        badBt.SetActive(false);
        backOnUI.SetActive(false);
        // Make sure there's only one instance of this script
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void spawnBombs()
    {
        backOnUI.SetActive(false);
        foreach (int value in Sequence)
        {
            switch (value)
            {
                case 0:
                    Debug.Log("AMARILLO");
                    Vector3 leftPos = new Vector3(0, startHeight, -1);
                    Instantiate(Thebomb, leftPos, Quaternion.identity);
                    startHeight += intervalo;
                    break;
                case 1:
                    Debug.Log("VERDE");
                    Vector3 rightPos = new Vector3(0, startHeight, 1);
                    Instantiate(Thebomb, rightPos, Quaternion.identity);
                    startHeight += intervalo;
                    break;
                case 2:
                    Debug.Log("ROJO");
                    Vector3 upPos = new Vector3(-1, startHeight, 0);
                    Instantiate(Thebomb, upPos, Quaternion.identity);
                    startHeight += intervalo;
                    break;
                case 3:
                    Debug.Log("AZUL");
                    Vector3 downPos = new Vector3(1, startHeight, 0);
                    Instantiate(Thebomb, downPos, Quaternion.identity);
                    startHeight += intervalo;
                    break;
                default:
                    Debug.LogError("Invalid value in Sequence list");
                    break;
            }
        }

        startHeight = 2;
        waitForUI += 2;
    }

    public void AddRandomValuesToList(int numValues)
    {
        for (int i = 0; i < numValues; i++)
        {
            int value = Random.Range(0, 4);
            Sequence.Add(value);
        }
    }

    public void activateUI()
    {
        backOnUI.SetActive(true);
    }

    public void addtoAnswer(int numberA) 
    { 
        Answer.Add(numberA);
    }

    public IEnumerator DeactivateAfterDelay(GameObject signImage)
    {
        signImage.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        signImage.SetActive(false);
    }

    public void PlayBOOm()
    {
        AddRandomValuesToList(numBombs);
        spawnBombs();
        Invoke("activateUI", waitForUI);
    }
}
