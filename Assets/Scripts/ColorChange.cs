using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    void OnTouchDown()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }
    void OnTouchStay()
    {
        GetComponent<MeshRenderer>().material.color = Color.magenta;
    }
    void OnTouchUp()
    {
        GetComponent<MeshRenderer>().material.color = Color.grey;
    }
    void OnTouchExit()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
