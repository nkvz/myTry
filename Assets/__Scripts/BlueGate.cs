using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueGate : MonoBehaviour
{
    [Header("Set In Inspector")]
    public bool openBlueGate = false;
    public static bool blue;
    private Renderer rend;
    public GameObject text;

    public static bool inBlue;
    public bool inAreaBlue;

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
            inAreaBlue = true;
            inBlue = inAreaBlue;
            text.SetActive(true);
        }
    }

    public void OnCollisionExit(Collision coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            inAreaBlue = false;
            inBlue = inAreaBlue;
            text.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BlueKey"))
        {
            openBlueGate = true;
            blue = openBlueGate;
            Destroy(other.gameObject);

            rend.material.color = Color.green;

        } else
        {
            other.gameObject.transform.position = player.transform.position;
        }

    }
}
