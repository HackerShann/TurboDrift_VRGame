using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public TMP_Text TimeText;
    public TMP_Text Speed;
    public TMP_Text LapCount;
    public TMP_Text BestLapText;

    // Start is called before the first frame update
    void Start()
    {
        ApplicationData.MyTime = 0;
        float Bminutes = Mathf.FloorToInt(ApplicationData.Bestlap / 60);
        float Bseconds = Mathf.FloorToInt(ApplicationData.Bestlap % 60);
        BestLapText.text = string.Format("BEST COMPLETED LAP: {0:00}:{1:00}", Bminutes, Bseconds);
        LapCount.text = "LAPS COMPLETED: " + ApplicationData.LapCount.ToString();
        Speed.text = "Speed: " + ApplicationData.CurrentZvelocity.ToString("00.00");


    }

    // Update is called once per frame
    void Update()
    {
        ApplicationData.MyTime += Time.deltaTime;
        DisplayTime(ApplicationData.MyTime);
        Speed.text = "SPEED: " + ApplicationData.CurrentZvelocity.ToString("00:00");
        LapCount.text = "LAPS COMPLETED: " + ApplicationData.LapCount.ToString();
        float Bminutes = Mathf.FloorToInt(ApplicationData.Bestlap / 60);
        float Bseconds = Mathf.FloorToInt(ApplicationData.Bestlap % 60);
        BestLapText.text = string.Format("BEST COMPLETED LAP: {0:00}:{1:00}", Bminutes, Bseconds);
    }

    public void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        TimeText.text = string.Format("THIS LAP: {00:00}", seconds, minutes);
    }
}
