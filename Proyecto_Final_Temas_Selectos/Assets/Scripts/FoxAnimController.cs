﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxAnimController : MonoBehaviour
{
    public float speed = 1f;
    public int randomize = 0;
    public int mov = 0;
    public Animator AnimController;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        AnimController.SetInteger("state", 2);
        Vector3 movInput = Vector3.zero;
        movInput.x = .001f;
        if (mov==0)
        {
            transform.position += movInput.normalized * speed * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.tag == "fruit")
        {
            mov = 1;
            AnimController.SetInteger("state", 1);
            Destroy(obj.gameObject);
            yield WaitForSeconds(6);
        }
    }
}
