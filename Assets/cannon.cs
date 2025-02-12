using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour
{
    public GameObject targetPrefab; // Prefab to be generated
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
        //Move the cannon according to the position of the DriveSlider
        transform.position = new Vector2(i, -3.65f);
    }

    public void fire()
    {
        //Creates a new prefab when the button is pressed
        GameObject newTarget = Instantiate(targetPrefab);
        newTarget.transform.position = transform.position;
    }
}
