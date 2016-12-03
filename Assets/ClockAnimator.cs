using UnityEngine;
using System.Collections;
using System;

public class ClockAnimator : MonoBehaviour
{
    private const float hourToDegrees = 360 / 12;
    private const float minutesToDegrees = 360 / 60;
    private const float secondsToDegrees = 360 / 60;

    public Transform hours, minutes, seconds;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DateTime datetime = DateTime.Now;
        hours.localRotation = Quaternion.Euler(0f, 0f, datetime.Hour * -hourToDegrees);
        minutes.localRotation = Quaternion.Euler(0f, 0f, datetime.Minute * -minutesToDegrees);
        seconds.localRotation = Quaternion.Euler(0f, 0f, datetime.Second * -secondsToDegrees);

    }
}
