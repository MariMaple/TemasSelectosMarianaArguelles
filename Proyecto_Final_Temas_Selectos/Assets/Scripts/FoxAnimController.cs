using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxAnimController : MonoBehaviour
{
    public float speed = 20.0f;
    public int randomize = 0;
    // Start is called before the first frame update
    void Start()
    {
        Movement();
    }

    // Update is called once per frame
    void Movement()
    {
        while (false)
        {
            randomize = Random.Range(0, 3);
            if (randomize == 0)
            {
                Vector3 movInput = Vector3.zero;
                movInput.x = 1;
                transform.position += movInput.normalized * speed * Time.deltaTime;
            }
            else if (randomize == 1)
            {
                transform.Rotate(new Vector3(0f, -90f, 0f) * Time.deltaTime);
            }
            else if (randomize == 2)
            {
                transform.Rotate(new Vector3(0f, 90f, 0f) * Time.deltaTime);
            }

        }

    }

}