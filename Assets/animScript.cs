using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animScript : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Get the Animator component attached to this GameObject
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check if the Space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Trigger the animation
            //animator.SetTrigger("New Animation"); // Replace "YourAnimationTrigger" with the actual trigger parameter name in your Animator window
        }
    }
}
