using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    public void MouseEnter()
    {
        transform.localScale = Vector3.one * 1.25f;
    }

    public void MouseExit()
    {
        transform.localScale = Vector3.one;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
