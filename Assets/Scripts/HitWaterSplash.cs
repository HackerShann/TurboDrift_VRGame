using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitWaterSplash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ApplicationData.DidItHitWater = false;
    }

    void OnCollisionEnter(Collision Myplayer)
    {
        if (Myplayer.gameObject.CompareTag("Player"))
        {
            if (ApplicationData.DidItHitWater == false)
            {
                print("hit water");
                GetComponent<AudioSource>().Play();
                ApplicationData.DidItHitWater = true;
            }
        }
    } 
}
