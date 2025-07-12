using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tyokusinn : MonoBehaviour
{
    public float speedX = 1;
    public float speedY= 0;
    public float speedZ = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void FixedUpdate()
    {
        this.transform.Translate(speedX / 5, speedY, speedZ);
    }
}
