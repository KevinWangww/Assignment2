using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    private float t; // time
    Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>(); // get slider to show the time
    }

    private void Update()
    {
        // time changing
        t += Time.deltaTime;
        slider.value = t % slider.maxValue;
    }

}
