using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{

    public float moveSpeed = 5f; // move speed

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * moveSpeed * Time.deltaTime;

        // Convert world coordinates to screen coordinates
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        // Detects if the top of the screen is exceeded ,if is destroy it. 
        if (screenPos.y >= Screen.height)
        {
            Destroy(gameObject);
        }
    }

    //Controlling the size of an object with the ScaleSlider
    public void setScale(float i)
    {
        transform.localScale = new Vector2(i,i);
    }

}
