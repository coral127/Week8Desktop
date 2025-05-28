using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Arrow : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 Mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position; 
        float z = (Mathf.Atan2(Mouse.y, Mouse.x)*Mathf.Rad2Deg)-90;
        transform.rotation = Quaternion.Euler(0, 0, z);
    }
}
