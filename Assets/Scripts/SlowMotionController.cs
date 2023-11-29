using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotionController : MonoBehaviour
{
    public float slowdownFactor = 0.05f;
    public float slowdownLenght = 2f;

    public void DoSlowmotion()
    {
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }

    public void DoNormalTime()
    {
        Time.timeScale = 1;
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }
}
