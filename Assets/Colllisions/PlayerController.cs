using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveForce;
    public Rigidbody rig;

    void FixedUpdate() // where we want to run our physics based systems. E.G adding force, checking for certain physics interactions. This runs at a set 60 times per second regardless of the framerate unlike normal update.
    {
        float xInput = Input.GetAxis("Horizontal"); // left/right arrow keys, A and D keys, left and right joystick. This will just return zero if it is not true. -1 for the left and 1 for the right when true.

        rig.AddForce(Vector3.right * xInput * moveForce); // adding force to the rigid body after keyboard input is applied.
    }
}
