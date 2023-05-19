using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panels : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private bool isYellow;

    [SerializeField]
    private bool isRed;

    [SerializeField]
    private bool isBlue;

    [SerializeField]
    private bool isGreen;

    public Color flashColor;
    public float flashDuration = 0.2f;
    private Color originalColor;


    void Start()
    {
        originalColor = GetComponent<Renderer>().material.color;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bomb"))
        {
            if(isRed)
            {
                Debug.Log("red");
                StartCoroutine(Flash());
            }
            else if (isBlue)
            {
                Debug.Log("blue");
                StartCoroutine(Flash());
            }
            else if (isGreen)
            {
                Debug.Log("green");
                StartCoroutine(Flash());
            }
            else if (isYellow)
            {
                Debug.Log("yellow");
                StartCoroutine(Flash());
            }

            Explode();
        }
    }

    private void Explode()
    {
        // Code for explosion effect and any other actions to be taken
    }

    IEnumerator Flash()
    {
        // Change the cube's color to the flash color
        GetComponent<Renderer>().material.color = flashColor;

        // Wait for the duration of the flash
        yield return new WaitForSeconds(flashDuration);

        // Change the cube's color back to the original color
        GetComponent<Renderer>().material.color = originalColor;
    }

}
