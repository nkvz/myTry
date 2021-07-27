using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GameEndManager : MonoBehaviour
{
    public bool redOPEN;
    public bool greenOPEN;
    public bool blueOPEN;
    //public GameObject textWin;

    public VideoPlayer vplay;

    void Start()
    {
        //textWin.SetActive(false);
    }

   
    void Update()
    {
        redOPEN = RedGate.red;
        greenOPEN = GreenGate.green;
        blueOPEN = BlueGate.blue;

        if (redOPEN == true & greenOPEN == true & blueOPEN == true)
        {
            vplay.Play();
            //textWin.SetActive(true);
        }
    }
}
