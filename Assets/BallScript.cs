using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private bool dead = false;
    public Color RedColor = Color.red;
    public float speed = 2f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!dead)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

            transform.Translate(movement * speed * Time.deltaTime);
        }
        else
        {
            if (Input.anyKeyDown)
            {
                Debug.Log("You dead!");
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Console.WriteLine("1");
        Renderer sphereRenderer = GetComponent<Renderer>();
        if (other.GetComponent<Lava_script>())
        {
            sphereRenderer.material.color = RedColor;
            Console.WriteLine("2");
            Debug.Log("You dead!");
            dead = true;
        }
    }
}