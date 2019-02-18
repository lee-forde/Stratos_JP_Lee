using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderController : MonoBehaviour {

    public float speed = 6;



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && Input.GetKey(KeyCode.W))
        {

            other.GetComponent<RigidBody2D>().velocity = new Vector2(0, speed);
        }
        else if (other.tag == "Player" && Input.GetKey(KeyCode.S))
        {
            other.GetComponent<RigidBody2D>().velocity = new Vector2(0, -speed);
        }

        }
    }


