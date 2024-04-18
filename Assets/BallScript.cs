using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private bool dead = false;
    private bool is_dead = false;
    public Color RedColor = Color.red;
    public float speed = 2f;
    public AudioSource BackMusic, JumpSound, DeadSound, DeadMusic;
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

            Vector3 movement = new Vector3(-horizontalInput, 0f, -verticalInput);

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
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Map"))
        {
            if (JumpSound != null)
            {
                if (!dead)
                {
                    JumpSound.Play();
                }
            }
        }
        if (collision.gameObject.CompareTag("Lava"))
        {
            if (!is_dead)
            {
                BackMusic.Stop();
                DeadSound.Play();
                DeadMusic.Play();
                is_dead = true;
            }
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            BackMusic.Stop();
            DeadSound.Play();
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