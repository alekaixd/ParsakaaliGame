using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform shootpoint;
    public float rotationSpeed;
    public GameObject bulletPreFab;
    private bool canShoot = true;
    
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(ShootBullet(0.2f));
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

        float currentAngle = transform.localEulerAngles.z;
        if (currentAngle > 180)
        {
            currentAngle = currentAngle - 360;
        }
        if (currentAngle > 90)
        {
            currentAngle = 90;
        }
        else if (currentAngle < -90)
        {
            currentAngle = -90;
        }
        transform.localEulerAngles = new Vector3(0, 0, currentAngle);
    }

    


    private IEnumerator ShootBullet(float fireSpeed)
    {
        if(canShoot == true)
        {
            Instantiate(bulletPreFab, shootpoint.position, transform.rotation);
            canShoot = false;
            yield return new WaitForSeconds(fireSpeed);
            canShoot = true;
        }
    }
}
