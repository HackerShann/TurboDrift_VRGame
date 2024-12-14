using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelSpinner : MonoBehaviour
{

    public Rigidbody Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var locVel = Player.transform.InverseTransformDirection(Player.velocity);

        ApplicationData.CurrentZvelocity = locVel.z;
        ApplicationData.CurrentYvelocity = locVel.y;
        transform.Rotate(0, 0, locVel.z, Space.Self);

    }
}
