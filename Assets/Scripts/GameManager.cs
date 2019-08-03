using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Slider thermometre;
    GameObject noyau;

    bool lerp = false;
    float previousVal = 5;
    float newVal = 5;
    float t = 0;

    public delegate void NextTurn();
    public NextTurn newTurn;

    void Start()
    {
        thermometre = GameObject.Find("Thermometre").GetComponent<Slider>();
        noyau = GameObject.Find("NoyauMask");

        newTurn += ChangeTemp;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.T) && !lerp)
        {
            newTurn();
        }

        if (lerp)
        {
            LerpThermo();
        }
    }

    void ChangeTemp()
    {
        int energyAdd = CalculateTemp();

        previousVal = thermometre.value;
        newVal = thermometre.value + (energyAdd * 0.1f);
        lerp = true;
        t = 0;
    }

    int CalculateTemp()
    {
        int i = 0;
        Building[] buildings = FindObjectsOfType<Building>();
        foreach (Building b in buildings)
        {
            i += b.energyValue;
        }

        return i;
    }

    void LerpThermo()
    {
        t += Time.deltaTime;
        thermometre.value = Mathf.Lerp(previousVal, newVal, t);
        noyau.transform.localScale = Vector3.one * thermometre.value * 4;
        if (t >= 1)
        {
            lerp = false;
        }
    }
}
