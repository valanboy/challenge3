using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpLimit : MonoBehaviour
{
    private float upLimit = 14;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > upLimit)
        {
            transform.position = new Vector3(0, 14, 0);
        }
    }
}
