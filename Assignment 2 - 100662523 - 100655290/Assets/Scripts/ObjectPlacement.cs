using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacement : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Sphere;
    public Transform theDest;
    void Update()
    { 
        Vector3 offset = Camera.main.transform.forward * 3;
        transform.position = new Vector3(Mathf.Round(theDest.position.x + offset.x), Mathf.Round(theDest.position.y + offset.y), Mathf.Round(theDest.position.z +offset.z));
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Cube.SetActive(true);
            Cube.transform.position = gameObject.transform.position;
            Cube.transform.rotation = gameObject.transform.rotation;
            Sphere.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Cube.SetActive(false);
            Sphere.SetActive(true);
            Sphere.transform.position = gameObject.transform.position;
            Sphere.transform.rotation = gameObject.transform.rotation;
        }
    }
    

}