using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cointail : MonoBehaviour
{
    public GameObject wayPoint;
    private static Vector3 wayPointPos;

    public float pos;
    private float speed = 8.0f;
    
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {   
        
        wayPointPos = new Vector3(wayPoint.transform.position.x, transform.position.y,pos);
        //Here, the zombie's will follow the waypoint.
        transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
       
    }
    
}
