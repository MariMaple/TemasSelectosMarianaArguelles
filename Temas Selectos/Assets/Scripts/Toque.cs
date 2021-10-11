using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toque : MonoBehaviour
{
    public Texture[] texture;
    public int currentTexture;
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touches[0].phase == TouchPhase.Began)
        {
            currentTexture++;
            currentTexture %= texture.Length;
            gameObject.GetComponent<Renderer>().material.mainTexture = texture[currentTexture];
        }
    }
}
