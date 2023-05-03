using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotMove : MonoBehaviour
{
    public float speed = 8.0f;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        gameObject.transform.LookAt(player.transform, Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        // gameObject.transform.Translate(gameObject.transform.position - player.transform.position * speed * Time.deltaTime);
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, player.transform.position, speed);
    }
}
