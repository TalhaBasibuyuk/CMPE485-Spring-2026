using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScholarOfYore : MonoBehaviour
{   

    public GameObject prefabToSummon; // History

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            // Summon Historical Void Projection
            Instantiate(prefabToSummon, new Vector3(0, 10, 0), Quaternion.identity);
        }
    }
}
