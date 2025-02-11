using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour
{
    public GameObject targetPrefab; // 要生成的Prefab
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void move(float i)
    {
        //根据DriveSlider的位置移动cannon的位置
        transform.position = new Vector2(i, -3.65f);
    }

    public void fire()
    {
        //当按下按钮后创建新的prefab
        GameObject newTarget = Instantiate(targetPrefab);
        newTarget.transform.position = transform.position;
    }
}
