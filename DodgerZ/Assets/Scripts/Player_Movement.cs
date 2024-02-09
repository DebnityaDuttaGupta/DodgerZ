using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sideforce = 100f;
    
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        if (rb.position.y > 0f)
        {
            
            if (Input.GetKey("d"))
            {
                rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey("a"))
            {
                rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }
        

    }
}
