using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    Color defaultColor;

    SpriteRenderer sr;
    [SerializeField]
    bool occupied = false;

    GameObject building;


    // Start is called before the first frame update
    void Start()
    {
        building = Resources.Load<GameObject>("Prefabs/Building_01");
        sr = GetComponent<SpriteRenderer>();
        defaultColor = sr.color;
    }

    void OnMouseDown()
    {
        if (!occupied)
        {
            occupied = true;
            GameObject b = Instantiate(building, transform);
            b.transform.localPosition += new Vector3(0.58f, 0, 0);
            b.transform.localEulerAngles = new Vector3(0, 0, -90);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (occupied)
        {
            sr.color = new Color(1, 0, 0, 1);
        }
    }
}
