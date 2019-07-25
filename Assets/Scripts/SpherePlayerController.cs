using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpherePlayerController : MonoBehaviour
{
    public float speed = 1;
    void Update()
    {
        Vector3 direction = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow)) direction += Vector3.forward;
        if (Input.GetKey(KeyCode.RightArrow)) direction += Vector3.right;
        if (Input.GetKey(KeyCode.DownArrow)) direction += Vector3.back;
        if (Input.GetKey(KeyCode.LeftArrow)) direction += Vector3.left;
        transform.GetComponent<Rigidbody>().AddTorque(direction*speed);
    }
}
