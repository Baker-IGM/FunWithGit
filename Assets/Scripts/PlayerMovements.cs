using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.a))
        {
            transform.position.x -= 1;
        }
        if (Input.GetKeyDown(KeyCode.a))
        {
            transform.position.x += 1;
        }
    }
}
