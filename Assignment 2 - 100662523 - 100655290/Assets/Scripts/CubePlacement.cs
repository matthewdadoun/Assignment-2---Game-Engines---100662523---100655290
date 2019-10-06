using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlacement : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            gameObject.transform.position += new Vector3(0.0f, 0.0f, -1.0f);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            gameObject.transform.position += new Vector3(0.0f, 0.0f, 1.0f);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            gameObject.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            gameObject.transform.position += new Vector3(1.0f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.Return))
        {
            enabled = false;
        }
    }
}
