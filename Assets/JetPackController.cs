using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetPackController : MonoBehaviour {

    private Rigidbody2D rb2d;
    public float jetpackForce = 75.0f;


    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        bool jetpackActive = Input.GetButton("Fire1");
        if (jetpackActive)
        {
            rb2d.AddForce(new Vector2(0, jetpackForce));
        }
    }
}
