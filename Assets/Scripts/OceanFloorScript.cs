using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanFloorScript : MonoBehaviour
{
    private bool BangPlayed = false;

    void OnCollisionEnter(Collision MyPlayer)
    {
        if(MyPlayer.gameObject.tag == "Player")
        {
            if (BangPlayed == false)
            {
                GetComponent<AudioSource>().Play();
                BangPlayed = true;
            }
              
        }
        print("hit");


        Invoke("LetBounceOnOceanFloor", 3f);

    }

    public void LetBounceOnOceanFloor()
    {
        ApplicationData.HitOceanFloor = true;
        print("reload");
    }

}
