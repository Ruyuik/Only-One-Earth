using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthMovement : MonoBehaviour
{

    public bool stopRotation = false;
    float rotationSpeed = 0.02f;

    public GameObject mountain;
    [SerializeField]
    float mountainAmount;
    public GameObject tree;
    [SerializeField]
    float treeAmount;

    // Start is called before the first frame update
    void Start()
    {
        GenerateDecors();
    }

    // Update is called once per frame
    void Update()
    {
        if (!stopRotation)
            transform.eulerAngles += new Vector3(0, 0, rotationSpeed);
    }

    void GenerateDecors()
    {
        Transform decorsParent = transform.Find("Decors");
        for (int i = 0; i < treeAmount; i++)
        {
            GameObject t = Instantiate(tree, decorsParent);
            t.transform.eulerAngles = new Vector3(0, 0, Random.Range(0, 360));
            float x, y = 0f;
            y = Mathf.Sin(t.transform.eulerAngles.z * Mathf.PI / 180) * 2.58f;
            x = Mathf.Cos(t.transform.eulerAngles.z * Mathf.PI / 180) * 2.58f;
            t.transform.position = new Vector3(x, y, 0);
            t.transform.eulerAngles += new Vector3(0, 0, -90);
        }

        for (int i = 0; i < mountainAmount; i++)
        {
            GameObject m = Instantiate(mountain, decorsParent);
            m.transform.eulerAngles = new Vector3(0, 0, Random.Range(0, 360));
            float x, y = 0f;
            y = Mathf.Sin(m.transform.eulerAngles.z * Mathf.PI / 180) * 2.58f;
            x = Mathf.Cos(m.transform.eulerAngles.z * Mathf.PI / 180) * 2.58f;
            m.transform.position = new Vector3(x, y, 0);
            m.transform.eulerAngles += new Vector3(0, 0, -90);
        }
    }
}
