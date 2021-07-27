using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drops : MonoBehaviour
{
    [Header("Set In Inspector")]
    public GameObject item;
    private Transform player;
    public bool inRedGate;
    public bool inGreenGate;
    public bool inBlueGate;



    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    
    }
    private void Update()
    {
        inRedGate = RedGate.inRed;
        inGreenGate = GreenGate.inGreen;
        inBlueGate = BlueGate.inBlue;

    }

    public void SpawnDroppedItem()
    {
        Vector3 playerPos;


        if (inRedGate == true)
        {
            playerPos = new Vector3(-10, 3, -2);
        } else if(inGreenGate == true)
        {
            playerPos = new Vector3(-15, 3, 5);
        } else if(inBlueGate == true)
        {
            playerPos = new Vector3(-10, 3, 10);
        } else
        {
            playerPos = new Vector3(player.position.x - 3, player.position.y + 1, player.position.z - 3);
        }

        Instantiate(item, playerPos, Quaternion.identity);



    }
}
