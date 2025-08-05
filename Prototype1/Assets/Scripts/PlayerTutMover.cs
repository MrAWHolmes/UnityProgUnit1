using UnityEngine;

public class PlayerTutMover : MonoBehaviour
{

    public float moveSpeed = 10.0f;
    public float rotateSpeed = 100.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the hozizonatal and vertical axis using the arrow keys.
        // The value is continuous -1..+1
        // Make movement 10m/s and not per frame.
        float translation = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;

        // move translation along objects z-axis
        transform.Translate(0,0,translation);

        //rotate around the y-axis
        transform.Rotate(0, rotation, 0);

    }
}
