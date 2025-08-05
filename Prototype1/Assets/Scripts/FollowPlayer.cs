using UnityEngine;

public class FollowPlayer : MonoBehaviour  
{
    public GameObject Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {   // orignal camera is world relative
        //transform.position = Player.transform.position + new Vector3(0, 7, -5);
    }
}
