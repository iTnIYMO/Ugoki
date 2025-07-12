using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forever_MoveSin : MonoBehaviour
{
    float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(time);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Debug.Log(time);
    }

    /*
   private void OnMouseDown()
   {
       this.transform.Translate(2, 0, 0);
   }


   private void FixedUpdate()
   {
       time += Time.deltaTime;
       Debug.Log(time);
       this.transform.Translate(Mathf.Sin(time),0, 0);
   }
   */
}
