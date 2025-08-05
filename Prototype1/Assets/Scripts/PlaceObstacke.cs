using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Android;
using UnityEngine.UIElements;
using static UnityEngine.UI.Image;


public class PlaceBox : MonoBehaviour
{
    //public float zpos;
    public string slideDirection = "x";
    public float slideSpeed = 1.0f;
    public GameObject SomeObstacle;
    public bool debugOn = false;


    private int slideValue = 0;
    private const int width = 4;
    private Vector3 path = Vector3.zero;
    private Vector3 origin;
    private int counter = 0;
    private bool doSlide = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   //set the path vector of the obstacle based on x y or z movement
        path = Vector3.zero;

        //save initial position in origin
        origin = transform.position;

        
        if (slideDirection=="x"){
            
            path += Vector3.right;
        }
        if (slideDirection=="y")
        {
            path += Vector3.up;
        }
        if (slideDirection == "z")
        {
            path += Vector3.forward;
        }
        
        //transforms in x or z direction only

        // randomly select + or - normalised to +1 or -1
        while (slideValue == 0)
        {
            slideValue = Random.Range(-10, 10);
        }
        
        if (slideValue < 0)
        {
            slideValue = -1;
        }
        else
        {
            slideValue = +1;
        }

        //slideValue = 1;

        Debug.Log($"slideValue : {slideValue}");
        Debug.Log($"path       : {path}");
    }

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.name== "Vehicle")
        {
            doSlide = false;
        }
    } 
    // Update is called once per frame
    void Update()
    {   //teansforms in x or z only
        if (slideDirection == "y"|| !doSlide){ return; }

        // if in freefall destroy it
        if (transform.position.y < -100)
        {
            Destroy(this.gameObject);
        }

        // path is a Vector3 unary directional vector for (x,y,z)
        
        Vector3 vector = Time.deltaTime * path * slideValue * width * slideSpeed;
        
        transform.Translate(vector);

        if (debugOn && counter < 1000)
        {
            counter++;

            Debug.Log($"Count : {counter}");
            Debug.Log($"path : {path}");
            
            Debug.Log($"vector : {vector}");
            Debug.Log($"{this.name}.position ={transform.position} -->  ");
           
            Debug.Log($"---> {this.name}.position ={transform.position}  ");
            Debug.Log($"{this.name} distance = {Vector3.Distance(transform.position, origin)} to {origin}");

           
        }
       

               
        if (Vector3.Distance(transform.position, origin) > width)
        {
           
            //transform.position = origin;
            slideValue = -1 * slideValue;

            if (debugOn && counter < 1000)
            {
                Debug.Log($"counter : {counter} switched direction");
                Debug.Log($"slideValue:{slideValue}");

            }
        }

        
        {
            
        }
    }
}
