using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodeScript : MonoBehaviour
{

    // Reference to the AudioSource component
    private AudioSource audioSource;

    // The audio clip to be played
    public AudioClip audioClip;

    public GameObject explosionEffect;
    // Start is called before the first frame update
    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();

        // Set the audio clip for the AudioSource
        audioSource.clip = audioClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            // Log a message to the console
            audioSource.Play();
            Explode();
            
        }
    }

    void Explode()
    {
        


        GameObject.Instantiate(explosionEffect, transform.position, transform.rotation);
        Invoke("DelayedFunction", 1000);
        //UnityEngine.Object.Destroy(gameObject);
    }
}
