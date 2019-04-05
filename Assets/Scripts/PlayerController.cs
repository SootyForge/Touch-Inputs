using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public VariableJoystick joystick;
    public Rigidbody rb;

    void Start()
    {
        // joystick = GameObject.Find("Background").GetComponent<VariableJoystick>();
        // rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        
        float moveHorizontal = joystick.Horizontal;
        float moveVertical = joystick.Vertical;

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
}
