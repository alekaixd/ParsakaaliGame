using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulle : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
        StartCoroutine(DestroyBullet());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
