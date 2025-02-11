using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{

    public float moveSpeed = 5f; // 物体上移的速度

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * moveSpeed * Time.deltaTime;

        // 将世界坐标转换为屏幕坐标
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        // 检测是否超出屏幕顶端
        if (screenPos.y >= Screen.height)
        {
            Destroy(gameObject);
        }
    }

    //用ScaleSlider控制对象的大小
    public void setScale(float i)
    {
        transform.localScale = new Vector2(i,i);
    }

}
