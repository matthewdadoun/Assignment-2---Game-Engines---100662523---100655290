using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
    
{
    public Transform deletePos;
    public GameObject Cube;
    public GameObject Sphere;
    public GameObject Plane;
    public PhysicMaterial bounce;
    public Material cubeMaterial;
    public Material sphereMaterial;
    public Material planeMaterial;
    int selectedObject = 0;
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
                if (Input.GetMouseButtonDown(1))
                {
                    Destroy(cube);
                }
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
                GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Cube);
                plane.GetComponent<Renderer>().material = sphereMaterial;
                plane.transform.localScale = new Vector3(1.0f, 0.01f, 1.0f);
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
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            selectedObject = 0;
        }
    }
        }
        
    

