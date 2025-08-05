using UnityEngine;
/* Easiest solution is to make the camera a child of the vehicle - no scripting required! */
public class FollowPlayer : MonoBehaviour  
{
    public Transform target;
    public Vector3 offset;
    public Vector3 origin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - target.transform.position;
        origin = offset; //!!! try vector maths to work new heading angles myself !!!!
    }

    // Update is called once per frame
    void LateUpdate()
    {   // orignal camera is world relative
        //transform.position = Player.transform.position + new Vector3(0, 7, -5);

        
       

        // this transforms the vector to look along the Vehicles vector - no!
                transform.LookAt(target);
        // try rotate keeping y transform fixed, but x and z change?
        // transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));

        // REF: unity docs.unity3d.com/6000./Documentation/ScriptReference/Quaternion.LookRotation.html
        Vector3 relativePos = target.position - transform.position;

        //1st go at it - ref EU tuts 10:42 - camera follows but does not rotate!
        Vector3 newPos = target.transform.position + offset;
        transform.position = newPos;

        Quaternion rotation = Quaternion.LookRotation(newPos);
        transform.rotation = rotation;

        //Debug.Log($"camera position : {transform.position}");
        //Debug.Log($"camera rotation : {transform.rotation}");


    }
}
