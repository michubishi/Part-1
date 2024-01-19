using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject missilePrefab;
    public GameObject spawnPoint;

    Transform spawnPointTransform;
    // Start is called before the first frame update
    void Start()
    {
        spawnPointTransform = spawnPoint.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(missilePrefab, spawnPointTransform.position, spawnPointTransform.rotation);
    }
}
