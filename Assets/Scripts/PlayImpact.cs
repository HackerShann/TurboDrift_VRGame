using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayImpact : MonoBehaviour
{
    public AudioSource ImpactSound;
    public float ImpactMinSpeed;

    void OnCollisionEnter(Collision MyPlayer)
    {
        if (MyPlayer.gameObject.CompareTag("Player"))
        {
            if(Mathf.Abs(ApplicationData.CurrentYvelocity) > ImpactMinSpeed)
            {
                ImpactSound.Play();
            }
        }
    }
}
