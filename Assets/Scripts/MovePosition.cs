using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePosition : MonoBehaviour
{
    public Vector3 refPos, newPos;
    public bool isGrabbed = false;

    private float mouseX, mouseY;

    void Start()
    {
        refPos = gameObject.transform.position;
    }
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
    }
    void OnTouchDown()
    {
        isGrabbed = true;
        newPos = refPos;
    }
    void OnTouchStay()
    {
        Drag();
    }
    void OnTouchExit()
    {
        Drag();
    }
    void OnTouchUp()
    {
        isGrabbed = false;
        refPos = newPos;
    }
    void Drag()
    {
        newPos = new Vector3(mouseX, mouseY, 0);
        if (isGrabbed == true)
        {
            gameObject.transform.position += newPos;
            print("Moving");
        }
    }
}
