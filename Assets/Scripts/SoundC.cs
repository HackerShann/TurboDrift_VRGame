using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundC : MonoBehaviour
{
    public AudioSource CarSound;

    // Update is called once per frame
    void Update()
    {
        CarSound.volume = Mathf.Abs(ApplicationData.CurrentZvelocity / 20.0f);
        CarSound.pitch = Mathf.Abs(ApplicationData.CurrentZvelocity / 20.0f) + 0.3f;
    }
}
