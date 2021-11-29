using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;
    private float turnSpeed = 20f;
    private float horizontalInput;
    private float verticalInput;
    private float zMax = 450f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   void Update()
    {
        verticalInput = Input.GetAxis("Vertical");

        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime * verticalInput);

        if (transform.position.z > zMax)
        {
            Time.timeScale = 0;
            Debug.Log("THE END");

        }
    }
}
