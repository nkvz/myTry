using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGate : MonoBehaviour
{
    [Header("Set In Inspector")]
    public bool openRedGate = false;
    public static bool red;
    private Renderer rend;
    public GameObject text;

    public static bool inRed;
    public bool inAreaRed;

    private Transform player;



    public void Start()
    {
        rend = GetComponent<Renderer>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void OnCollisionEnter(Collision coll)
    {

        if (coll.gameObject.tag == "Player")
        {
            inAreaRed = true;
            inRed = inAreaRed;
            text.SetActive(true);

        }
    }

    public void OnCollisionExit(Collision coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            inAreaRed = false;
            inRed = inAreaRed;
            text.SetActive(false);
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RedKey"))
        {
            openRedGate = true;
            red = openRedGate;
            Destroy(other.gameObject);

            rend.material.color = Color.green;
        } else
        {
            other.gameObject.transform.position = player.transform.position;
        }

    }
}
