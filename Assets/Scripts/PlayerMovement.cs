using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 pos = transform.position;
        pos.x += h * Time.deltaTime * speed;
        pos.z += v * Time.deltaTime * speed;

        transform.position = pos;
    }
}
