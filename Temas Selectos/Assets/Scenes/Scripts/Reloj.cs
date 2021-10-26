using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reloj : MonoBehaviour
{
    private float IniTimer;
    // Start is called before the first frame update
    void Start()
    {
        IniTimer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float Control;
        string Min;
        string Seg;
        string RelojText;

        Control = Time.time - IniTimer;
        Min = ((int)Control / 60).ToString("00");
        Seg = (Control % 60).ToString("00");
        RelojText = string.Format("{00}:{01}", Min, Seg);
        GetComponent<Text>().text = RelojText.ToString();
    }
}
