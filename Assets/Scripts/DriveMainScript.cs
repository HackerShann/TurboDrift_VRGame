using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public static class ApplicationData
{
    public static bool HitOceanFloor = false;
    public static bool DidItHitWater = false;
    public static float CurrentZvelocity;
    public static float CurrentYvelocity;

    public static bool TimerIsRunning = false;
    public static bool GatePassed = false;
    public static int LapCount = 0;
    public static float MyTime = 0;
    public static float Bestlap = 0;
    public static bool CountDownIsRUnning = true;

}

public class DriveMainScript : MonoBehaviour
{

    public float HorizAxis;
    public float VertAxis;

    public GameObject MyPlayer;
    public float ForwardForce;
    public float TurnForce;

    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizAxis = Input.GetAxis("Horizontal");
        VertAxis = Input.GetAxis("Vertical");

        if (VertAxis > 0)
        {
            GoForward();
        }

        if (VertAxis < 0)
        { 
            GoBack();
        }

        if (VertAxis == 0)
        {
            NoGas();
        }

        if (HorizAxis < 0)
        {
            TurnLeft();
        }

        if (HorizAxis > 0)
        {
            TurnRight();
        }

        if (ApplicationData.HitOceanFloor == true)
        {
            ApplicationData.HitOceanFloor = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void GoForward()
    {
        MyPlayer.GetComponent<ConstantForce>().relativeForce = new Vector3(0, 0, ForwardForce);
    }

    public void NoGas()
    {
        MyPlayer.GetComponent<ConstantForce>().relativeForce = new Vector3(0, 0, 0);
    }

    public void GoBack()
    {
        MyPlayer.GetComponent<ConstantForce>().relativeForce = new Vector3(0, 0, -ForwardForce);
    }

    public void TurnLeft()
    {
        MyPlayer.transform.Rotate(Vector3.down * Time.deltaTime * TurnForce * Mathf.Abs(HorizAxis));
    }

    public void TurnRight()
    {
        MyPlayer.transform.Rotate(Vector3.up * Time.deltaTime * TurnForce * Mathf.Abs(HorizAxis));
    }
}
