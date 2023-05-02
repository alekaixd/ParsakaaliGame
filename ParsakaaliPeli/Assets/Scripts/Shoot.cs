using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform shootpoint;
    public float rotationSpeed;
    public GameObject bulletPreFab;
    
    void Start()
    {
        Debug.Log("Starttaa");

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Ampuu");
            Instantiate(bulletPreFab, shootpoint.position, transform.rotation);
        }
        if (Input.GetKey(KeyCode.D))
        {
            // Rotate to the right
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            // Rotate to the left
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }

    }
}
