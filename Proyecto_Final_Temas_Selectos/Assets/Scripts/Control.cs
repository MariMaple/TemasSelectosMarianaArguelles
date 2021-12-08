

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
        {
            Vector3 movInput = Vector3.zero;
            movInput.x = -1;
            transform.position += movInput.normalized * speed * Time.deltaTime;
}
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
        {
            Vector3 movInput = Vector3.zero;
            movInput.x = 1;
            transform.position += movInput.normalized * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
        {
            Vector3 movInput = Vector3.zero;
            movInput.z = 1;
            transform.position += movInput.normalized * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            Vector3 movInput = Vector3.zero;
            movInput.z = -1;
            transform.position += movInput.normalized * speed * Time.deltaTime;
        }
        //if (Input.GetKey("q"))
        //{
        //    transform.Rotate(new Vector3(0f, -90f, 0f) * Time.deltaTime);
        //}
        //if (Input.GetKey("e"))
        //{
        //    transform.Rotate(new Vector3(0f, 90f, 0f) * Time.deltaTime);
        //}
    }
  
}
