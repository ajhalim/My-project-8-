using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Threading;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Camera mainCamera;

    public Transform playerBody;

    public float mouseSensitivity = 100f;

    public GameObject explosionEffect;
    public GameObject menu;
    public bool menuActive = false;

    public Light targetLight;
    public bool lightActive = true;

    public GameObject cookie;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //xRotation -= mouseY;
        //xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        playerBody.Rotate(Vector3.up * mouseX);

        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (menuActive == false)
            {
                menu.SetActive(true);
                menuActive = true;
            }
            else
            {
                menu.SetActive(false);
                menuActive = false;
            }


        }//dsadsad

        // Check if the Space key is pressed
        if (Input.GetKeyDown(KeyCode.T))
        {
            // Toggle the light's state
            if (targetLight != null)
            {
                if (lightActive == true)
                {
                    targetLight.enabled = false;
                    cookie.SetActive(false);
                    lightActive = false;
                }
                else
                {
                    targetLight.enabled = true;
                    cookie.SetActive(true);
                    lightActive = true;
                }
            }
        }
    }

    



}
