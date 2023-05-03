using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotSpawner : MonoBehaviour
{
    public GameObject spawnPosition;
    public GameObject carrotPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnDelay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCarrot()
    {
        gameObject.transform.rotation = Quaternion.AngleAxis(Random.Range(-90.0f, 90.0f), new Vector3(0, 0, 1));
    }

    private IEnumerator SpawnDelay()
    {
        SpawnCarrot();
        yield return new WaitForSeconds(1);
        StartCoroutine(SpawnDelay());
    }
}
