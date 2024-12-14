using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTriggerScript : MonoBehaviour
{
    public GameObject StartTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FrontBumper")
        {

            print("lap complete");
            ApplicationData.LapCount++;

            if (ApplicationData.MyTime < ApplicationData.Bestlap || ApplicationData.Bestlap == 0f)
            {
                ApplicationData.Bestlap = ApplicationData.MyTime;
            }

            ApplicationData.MyTime = 0;
            StartTrigger.SetActive(true);
            this.gameObject.SetActive(false);

        }
    }
}
