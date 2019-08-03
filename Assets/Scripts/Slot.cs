using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    Color defaultColor;

    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        defaultColor = sr.color;
    }

    void OnMouseEnter()
    {
        Debug.Log(gameObject.name + " Enter");
        sr.color = new Color(1, 0, 0, 1);
    }

    void OnMouseExit()
    {
        Debug.Log(gameObject.name + " Exit");
        sr.color = defaultColor;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
