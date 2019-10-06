using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
    
{
    public GameObject Cube;
    public GameObject Sphere;
    public GameObject Plane;
    public Material cubeMaterial;
    public Material sphereMaterial;
    public Material planeMaterial;
    int selectedObject = 1;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (selectedObject == 1)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.GetComponent<Renderer>().material = cubeMaterial;

                cube.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            }
            if (selectedObject == 2)
            {
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.GetComponent<Renderer>().material = sphereMaterial;
                sphere.AddComponent<Rigidbody>();
                sphere.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            }
            if (selectedObject == 3)
            {
               GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
               plane.GetComponent<Renderer>().material = sphereMaterial;
               plane.AddComponent<Rigidbody>();
               plane.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            }  
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedObject = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selectedObject = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            selectedObject = 3;
        }
    }
        }
        
    

