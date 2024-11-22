using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class small : MonoBehaviour
{
    float smallRotationStart = 150f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            smallRotationStart += 0.01f;
            transform.rotation = quaternion.Euler(new Vector3(0, smallRotationStart, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            smallRotationStart -= 0.01F;
            transform.rotation = quaternion.Euler(new Vector3(0, smallRotationStart, 0));
        }
    }


}
