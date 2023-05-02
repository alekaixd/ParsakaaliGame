using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform shootpoint;
    public GameObject bulletPreFab;
    
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(bulletPreFab, shootpoint.position, transform.rotation);
        }
    }

    void Update()
    {
        
    }
}
