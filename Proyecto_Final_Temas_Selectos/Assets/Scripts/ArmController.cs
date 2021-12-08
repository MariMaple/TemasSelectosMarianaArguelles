using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmController : MonoBehaviour
{
    public Animator AnimController;
    //public AudioSource Audio;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow)    || Input.GetKey("a")
            ||Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d")
            ||Input.GetKey(KeyCode.UpArrow)    || Input.GetKey("w")
            ||Input.GetKey(KeyCode.DownArrow)  || Input.GetKey("s"))
        {
            AnimController.SetInteger("active", 1);
        }
        else
        {
            AnimController.SetInteger("active", 0);
        }
    }
    void OnTriggerEnter(Collider obj)
    {
        //if (obj.tag == "fruit")
        //{
        //    Destroy(obj.gameObject);
        //}
        if (obj.tag == "fruit")
        {
            AnimController.SetInteger("active", 2);
        }
    }
}
