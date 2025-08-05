using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float turnSpeed;
    public float speed;
    public float dy=1.0f; // rotation - on Horizantal Axis?
    public float dz=1.0f; // fwd-back - on Vertical Axis?

    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dz = Input.GetAxis("Vertical");
        dy = Input.GetAxis("Horizontal");

        //get translation vector and normalise it
        Vector3 fwd = new Vector3(0,0, dz);
        fwd.Normalize(); // velocity now has lenghth 1

        // We will move the vehicle forward each frame
        transform.Translate(fwd * speed * Time.deltaTime);

        // rotate to face forward
        // nasty version!
        Vector3 turn = new Vector3(0,dy, 0);
        turn.Normalize();

        transform.Rotate(turn * turnSpeed * Time.deltaTime);


        
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizonatalInput);
    }
}
