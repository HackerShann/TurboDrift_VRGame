using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRotate : MonoBehaviour
{  
   // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * 0.2f *  Time.deltaTime);
    }
}
 