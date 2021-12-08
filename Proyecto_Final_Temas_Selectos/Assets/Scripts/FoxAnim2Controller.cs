using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxAnim2Controller : MonoBehaviour
{

    public Animator Anim2Controller;
    public AudioSource Audio2;
    // Start is called before the first frame update
    void Start()
    {
        Audio2 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Anim2Controller.SetInteger("stado", 0);
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.tag == "fruit")
        {
            Anim2Controller.SetInteger("stado", 1);
            Audio2.Play();
            Destroy(obj.gameObject);
        }
    }
}
