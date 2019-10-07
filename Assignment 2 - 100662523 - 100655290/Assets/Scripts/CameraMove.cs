using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private string horizontalInputName = "Horizontal";
    private string verticalInputName = "Vertical";
    private float movementSpeed = 3.0f;

    private void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float horizInput = Input.GetAxis(horizontalInputName) * movementSpeed;
        float vertInput = Input.GetAxis(verticalInputName) * movementSpeed;

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;

        transform.position += (forwardMovement + rightMovement) * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.position += new Vector3(0.0f, 2.0f*Time.deltaTime, 0.0f);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            gameObject.transform.position += new Vector3(0.0f, -2.0f * Time.deltaTime, 0.0f);
        }
    }
}
