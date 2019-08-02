using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tools : MonoBehaviour
{
    public GameObject[] cubes;

    Vector3 position;
    float multiplicator;


    // Start is called before the first frame update
    void Start()
    {
        multiplicator = (transform.lossyScale.x - cubes[0].transform.lossyScale.x) / 2;
        DistributeCubes();
    }

    void DistributeCubes()
    {
        foreach (GameObject c in cubes)
        {
            float x, y = 0f;
            x = Mathf.Cos(c.transform.eulerAngles.z * Mathf.PI / 180) * multiplicator;
            y = Mathf.Sin(c.transform.eulerAngles.z * Mathf.PI / 180) * multiplicator;

            c.transform.position = new Vector3(x, y, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
