using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxAnim2Controller : MonoBehaviour
{

    public Animator AnimController;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        AnimController.SetInteger("state", 1);
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.tag == "fruit")
        {
            AnimController.SetInteger("state", 1);
            Destroy(obj.gameObject);
        }
    }
}
