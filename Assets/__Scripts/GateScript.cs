using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    [Header("Set In Inspector")]
    public bool select = false;
    public bool openRedGate = false;
    public bool openGreenGate = false;
    public bool openBlueGate = false;

    public void OnCollisionEnter(Collision coll)
    {

        if(coll.gameObject.tag == "Player")
        {
            TakeKey();
        }  
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RedKey"))
        {
            openRedGate = true;
            Destroy(other.gameObject);
            Debug.Log("yeeeep, red gate has open");

        }

        if (other.CompareTag("GreenKey"))
        {
            openGreenGate = true;
            Destroy(other.gameObject);
            Debug.Log("yeeeep, green gate has open");

        }


        if (other.CompareTag("BlueKey"))
        {
            openBlueGate = true;
            Destroy(other.gameObject);
            Debug.Log("yeeeep, blue gate has open");

        }
    }

    public void TakeKey()
    {
        Debug.Log("give me ur soul...");
    }
}
