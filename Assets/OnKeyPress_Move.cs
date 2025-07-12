using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_Move : MonoBehaviour
{
    public float speed = 2;
    float vx = 0;
    float vz = 0;
    void Update()
    {
        vx = Input.GetAxisRaw("Horizontal") * speed;
        vz = Input.GetAxisRaw("Vertical") * speed;
    }

    private void FixedUpdate()
    {
        this.transform.Translate(vx / 50*-1, 0, vz / 50*-1);
    }
}
