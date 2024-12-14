using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class MyUnderwater : MonoBehaviour
{
    public int underwaterLevel;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < underwaterLevel)
        {
            this.GetComponent<UnityEngine.Rendering.PostProcessing.PostProcessVolume>().enabled = true;
        }

        else
        {
            this.GetComponent<UnityEngine.Rendering.PostProcessing.PostProcessVolume>().enabled = false;
        }
    }
}
