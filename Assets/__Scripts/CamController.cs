using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    [Header("Set In Inspector")]
    private float mouseX;
    private float mouseY;

    public float sensitivity = 212f;

    public Transform Player;

    public GameObject inventPanel;
    public static bool openedInventory = false;

    public float maxUp = 60f;
    public float minUp = -40f;
    public float xRotation;

    public void Start()
    {
        inventPanel.SetActive(false);
    }

    public void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        //Player.Rotate(mouseX * new Vector3(0, 1, 0));
        //transform.Rotate(-mouseY * new Vector3(1, 0, 0));

        SetMouseRotation();


        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (openedInventory)
            {
                closeInv();
            } else
            {
                openedInv();
            }
        }
    }

    private void SetMouseRotation()
    {
        xRotation -= mouseY;
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        xRotation = Mathf.Clamp(xRotation, (maxUp * -1), (minUp * -1));
        Player.Rotate(Vector3.up * mouseX);
    }

    void closeInv()
    {
        inventPanel.SetActive(false);
        Time.timeScale = 1f;
        openedInventory = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void openedInv()
    {
        inventPanel.SetActive(true);
        Time.timeScale = 0f;
        openedInventory = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
}
