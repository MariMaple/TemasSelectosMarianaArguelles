using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{   public Animator AnimController;
    public AudioSource audioPersonaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            AnimController.SetBool("avanza", true);
            AnimController.SetBool("ruge", true);
        }
        if(AnimController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="walking"|| AnimController.GetCurrentAnimatorClipInfo(0)[0].clip.name == "roar")
        {
            AnimController.SetBool("avanza", false);
            AnimController.SetBool("ruge", false);
            if (!audioPersonaje.isPlaying)
            {
                audioPersonaje.Play();
            }
        }
        if (AnimController.GetCurrentAnimatorClipInfo(0)[0].clip.name == "idle")
        {
            audioPersonaje.Pause();
        }
    }
}
