using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    float heatRiseRate = 0.01f;

    Slider thermometre;
    GameObject noyau;

    bool lerp = false;
    float previousVal = 5;
    float newVal = 5;
    float t = 0;

    void Start()
    {
        thermometre = GameObject.Find("Thermometre").GetComponent<Slider>();
        noyau = GameObject.Find("NoyauMask");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.P) && !lerp)
        {
            TempUp();
        }

        if (Input.GetKeyDown(KeyCode.M) && !lerp)
        {
            TempDown();
        }

        if (lerp)
        {
            LerpThermo();
        }
    }

    void TempUp()
    {
        previousVal = thermometre.value;
        newVal = thermometre.value + 0.1f;
        lerp = true;
        t = 0;
    }

    void TempDown()
    {
        previousVal = thermometre.value;
        newVal = thermometre.value - 0.1f;
        lerp = true;
        t = 0;
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
