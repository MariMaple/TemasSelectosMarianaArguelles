using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxAnimController : MonoBehaviour
{
    public float speed = 1f;
    public int randomize = 0;
    public int mov = 0;
    public Animator AnimController;
    public AudioSource Audio;
    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (mov == 1)
        {
            if (AnimController.GetCurrentAnimatorStateInfo(0).IsName("Armature|idle")){
                mov = 0;
                AnimController.SetInteger("state", 2);
            }
        }
        else {
            mov = 0;
            AnimController.SetInteger("state", 2);
        }
        
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
            AnimController.SetInteger("state", 1);
            mov = 1;

            Audio.Play();
            Destroy(obj.gameObject);
   
        }
    }
}
