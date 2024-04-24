using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlles : MonoBehaviour
{
    public int speed = 30;
    public int rotationSpeed = 90;
    public float horizontal;
    public float vertical;



    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontal);
        
    }
}
   
       
