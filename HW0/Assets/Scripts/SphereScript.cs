using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{

    [SerializeField]
    private Vector3 direction = new Vector3(-5, 0, 0);
    private Vector3 startPos;

    [SerializeField]
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    
    void FixedUpdate()
    {
        rb.AddForce(direction);
    }
}
