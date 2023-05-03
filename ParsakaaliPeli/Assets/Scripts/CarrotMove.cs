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
        
    }

    // Update is called once per frame
    void Update()
    {
        // gameObject.transform.Translate(gameObject.transform.position - player.transform.position * speed * Time.deltaTime);
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, player.transform.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);

        // take damage
    }
}
