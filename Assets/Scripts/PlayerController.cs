using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Joystick joystick;
    private Rigidbody rb;

    void Start()
    {
        joystick = GameObject.Find("Background").GetComponent<Joystick>();
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        
        float moveHorizontal = joystick.Horizontal;
        float moveVertical = joystick.Vertical;

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
}
