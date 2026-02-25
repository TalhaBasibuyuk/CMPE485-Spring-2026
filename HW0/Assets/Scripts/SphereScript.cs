using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{

    [SerializeField]
    private Vector3 direction = new Vector3(-5, 0, 0);
    

    [SerializeField]
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        rb.AddForce(direction);
    }
}
