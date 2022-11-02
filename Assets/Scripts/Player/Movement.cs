using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    CharacterController controller;

    public float moveSpeed = 10.0f;
    bool flip = false;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // If ke is pressed, controls are inverted
        if(Input.GetKeyDown(KeyCode.I))
        {
            flip = !flip;
        }

        if (flip == false)
        {
            float forward = Input.GetAxis("Vertical");
            float right = Input.GetAxis("Horizontal");

            Vector3 move = transform.forward * forward + transform.right * right;
            controller.Move(move * moveSpeed * Time.deltaTime);
        }

        if(flip == true)
        {
            float forward = Input.GetAxis("Vertical");
            float right = Input.GetAxis("Horizontal");

            Vector3 move = (transform.forward * forward + transform.right * right) * -1;
            controller.Move(move * moveSpeed * Time.deltaTime);
        }
    }
}
