using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode forward;
    public KeyCode backward;
    public KeyCode left;
    public KeyCode right;
    public KeyCode up;
    public float speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direction = new Vector3(0,0,0);
        if (Input.GetKey(forward))
        {
            direction.x = speed;
        }
        if (Input.GetKey(backward))
        {
            direction.x = -speed;
        }
        if (Input.GetKey(left))
        {
            direction.z = speed;
        }
        if (Input.GetKey(right))
        {
            direction.z = -speed;
        }
        if (Input.GetKey(up))
        {
            direction.y = 3;
        }
        GetComponent<Rigidbody>().velocity += direction;
    }
}
