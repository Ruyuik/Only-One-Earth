using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthMovement : MonoBehaviour
{

    public bool stopRotation = false;
    float rotationSpeed = 0.02f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!stopRotation)
            transform.eulerAngles += new Vector3(0, 0, rotationSpeed);
    }
}
