using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombAI : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        animator.Play("BOOM", 0, 0.5f);
        StartCoroutine(DestroyAfterAnimation());
        // Destroy this object
        //Destroy(gameObject);
    }

    private IEnumerator DestroyAfterAnimation()
    {
        // Wait for the animation to finish (adjust the time according to your animation length)
        yield return new WaitForSeconds(0.5f);

        // Destroy the object
        Destroy(gameObject);
    }
}
