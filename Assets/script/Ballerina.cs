using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Ballerina : MonoBehaviour
{float ballerinaRotationStart=0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {ballerinaRotationStart-=0.01f;
        transform.rotation=quaternion.Euler(new Vector3(0,ballerinaRotationStart,0));

        
    }
}
