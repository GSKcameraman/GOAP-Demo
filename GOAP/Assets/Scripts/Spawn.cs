using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject patientPrefab;
    public int numPatients;
    private int i = 0;
    public float invterval = 3.0f;
    float currentTime = 0;

    bool invoked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void SpawnPatient()
    {
        Instantiate(patientPrefab, this.transform.position, Quaternion.identity);
        invoked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ( i < numPatients)
        {
            currentTime += Time.deltaTime;
            if ( currentTime >= invterval)
            {
                Instantiate(patientPrefab, this.transform.position, Quaternion.identity);
                currentTime = 0;
            }
        }
        else
        {
            if (!invoked)
            {
                Invoke("SpawnPatient", Random.Range(20, 30));
                invoked = true;
            }
        }
    }
}
