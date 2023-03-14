using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControler : MonoBehaviour
{
    public float speed = 10;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime, Space.World);


        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 5, 0);
        }


    }
}
