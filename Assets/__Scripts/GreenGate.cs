using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenGate : MonoBehaviour
{
    [Header("Set In Inspector")]
    public bool openGreenGate = false;
    public static bool green;
    private Renderer rend;
    public GameObject text;

    public static bool inGreen;
    public bool inAreaGreen;

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
            inAreaGreen = true;
            inGreen = inAreaGreen;
            text.SetActive(true);
        }
    }

    public void OnCollisionExit(Collision coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            inAreaGreen = false;
            inGreen = inAreaGreen;
            text.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GreenKey"))
        {
            openGreenGate = true;
            green = openGreenGate;
            Destroy(other.gameObject);

            rend.material.color = Color.green;
        } else
        {
            other.gameObject.transform.position = player.transform.position;
        }

    }
}
