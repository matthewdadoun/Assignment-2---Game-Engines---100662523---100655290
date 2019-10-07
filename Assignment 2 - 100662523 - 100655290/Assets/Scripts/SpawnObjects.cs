using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

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
    int noOfObjects=0;
    const string DLL_NAME = "SaveLevel";
    [DllImport(DLL_NAME)]
    private static extern void saveCoordinates(char obj, float x, float y, float z);
    [DllImport(DLL_NAME)]
    private static extern void overwriteCoordinates();
    [DllImport(DLL_NAME)]
    private static extern float LoadCoordinateX();
    [DllImport(DLL_NAME)]
    private static extern float LoadCoordinateY();
    [DllImport(DLL_NAME)]
    private static extern float LoadCoordinateZ();

    List<GameObject> objects = new List<GameObject>();
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
                objects.Add(cube.gameObject);
                saveCoordinates('c', objects[noOfObjects].transform.position.x, objects[noOfObjects].transform.position.y, objects[noOfObjects].transform.position.z);
                noOfObjects++;
            }
            if (selectedObject == 2)
            {
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.GetComponent<Renderer>().material = sphereMaterial;
                sphere.AddComponent<Rigidbody>();
                sphere.GetComponent<Rigidbody>().useGravity = false;
                objects.Add(sphere.gameObject);
                sphere.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
                saveCoordinates('s', objects[noOfObjects].transform.position.x, objects[noOfObjects].transform.position.y, objects[noOfObjects].transform.position.z);
                noOfObjects++;
                
            }
            if (selectedObject == 3)
            {
                GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Cube);
                plane.GetComponent<Renderer>().material = planeMaterial;
                plane.transform.localScale = new Vector3(1.0f, 0.01f, 1.0f);
                objects.Add(plane.gameObject);
                plane.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
                saveCoordinates('c', objects[noOfObjects].transform.position.x, objects[noOfObjects].transform.position.y, objects[noOfObjects].transform.position.z);
                noOfObjects++;
            }
        }
        //Undo function
        if(Input.GetKeyDown(KeyCode.Z))
        {
            (objects[noOfObjects-1]).SetActive(false);
            noOfObjects--;
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            (objects[noOfObjects]).SetActive(true);
            noOfObjects++;
        }

        if(Input.GetKeyDown(KeyCode.T))
        {
            overwriteCoordinates();
            Debug.Log("Level saved");
            for(int i=0; i<=objects.Count-1; i++)
            {
                if (objects[i] = Cube.gameObject)
                {
                    char objectType = 'c';
                    saveCoordinates(objectType, objects[i].transform.position.x, objects[i].transform.position.y, objects[i].transform.position.z);
                }
                if (objects[i] = Sphere.gameObject)
                {
                    char objectType = 's';
                    saveCoordinates(objectType, objects[i].transform.position.x, objects[i].transform.position.y, objects[i].transform.position.z);
                }
                if (objects[i] = Plane.gameObject)
                {
                    char objectType = 'p';
                    saveCoordinates(objectType, objects[i].transform.position.x, objects[i].transform.position.y, objects[i].transform.position.z);
                }
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
        
    

