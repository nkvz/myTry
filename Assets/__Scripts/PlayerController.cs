using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Set In Inspector")]
    public float speed = 10f;
    public Rigidbody rb;
    public float jumpPower = 200f;
    public bool inGround;

    [Header("Set In Inspector. keys")]

    public bool isSelected = false;
    public int selectedKey = 0;

    public bool selectRedKey = false;
    public bool hasRedKey = false;
    public bool selectGreenKey = false;
    public bool hasGreenKey = false;
    public bool selectBlueKey = false;
    public bool hasBlueKey = false;



    public void Update()
    {
        GetInput();
    }

    void GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(inGround == true)
            {
                rb.AddForce(transform.up * jumpPower);
            }
        }

        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            inGround = true;
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            inGround = true;
        }
    }


}
