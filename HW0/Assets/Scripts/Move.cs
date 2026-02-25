using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{   
    public float speed = 1;
    
    [SerializeField]
    private Rigidbody rb;

    
    

    private Vector3 backward => new Vector3(-1 * speed, 0, 0);
    private Vector3 forward => new Vector3(speed, 0, 0);
    private Vector3 left => new Vector3(0, 0, speed);
    private Vector3 right => new Vector3(0, 0, -1 * speed);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W)){
            rb.AddForce(forward);
        }
        if(Input.GetKey(KeyCode.A)){
            rb.AddForce(left);
        }
        if(Input.GetKey(KeyCode.S)){
            rb.AddForce(backward);
        }
        if(Input.GetKey(KeyCode.D)){
            rb.AddForce(right);
        }
        
    }
}
