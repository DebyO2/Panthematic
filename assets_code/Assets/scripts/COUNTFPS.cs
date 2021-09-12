using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class COUNTFPS : MonoBehaviour
{
    public float timer, refresh, avgFPS;
    public string display = "{0} FPS";
    public Text FPSdisplay;
    void Update()
    {
        float timelapse = Time.smoothDeltaTime;
        timer = timer <= 0 ? refresh : timer -= timelapse;

        if (timer <= 0) avgFPS = (int)(1f / timelapse);
        FPSdisplay.text = string.Format(display, avgFPS.ToString());
    }
}
