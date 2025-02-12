using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public GameObject prefabToSpawn; // 要生成的Prefab
    private float t; // 计时器
    Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
    }

    private void Update()
    {
        t += Time.deltaTime;
        slider.value = t % slider.maxValue;
    }

}
