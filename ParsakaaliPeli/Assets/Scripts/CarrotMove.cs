using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotMove : MonoBehaviour
{
    public float speed = 8.0f;
    public Rigidbody2D rb2d;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.LookAt(player.transform, Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
