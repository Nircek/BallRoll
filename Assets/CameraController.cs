using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public Transform player;
    public float distance = 15;
    public float smoothPosition = 1;
    public float smoothRotation = 1;
    public float height = 10;

    void Start() {
    }

    void Update() {
        Vector3 a = transform.position;
        Vector3 c = player.position + new Vector3(0, height, 0);
        float dist = Vector3.Distance(a, c);
        Vector3 b = ((dist > distance) ? 1 : -1) * (a-Vector3.MoveTowards(a, c, Math.Abs(dist - distance)));
        Vector3 d = a - b;
        if (d.y < c.y) d.y = c.y;
        transform.position = Vector3.Lerp(a, d, smoothPosition*Time.deltaTime);
        Quaternion lastRotation = transform.rotation;
        transform.LookAt(player);
        transform.rotation = Quaternion.Lerp(lastRotation, transform.rotation, smoothRotation*Time.deltaTime);
    }
}
