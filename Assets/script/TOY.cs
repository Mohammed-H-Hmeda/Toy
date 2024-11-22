using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TOY : MonoBehaviour

{
    float BigrotationStart = 0f;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            BigrotationStart += 0.1f;
            transform.rotation = Quaternion.Euler(new Vector3(BigrotationStart, 38, 0));
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            BigrotationStart -= 0.1f;
            transform.rotation = Quaternion.Euler(new Vector3(BigrotationStart, 38, 0));
            

        }

    }
}
