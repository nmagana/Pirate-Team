﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour
{

    public GameObject toggle;
    float y_change = (float)7;
    float y2_change = -7f;

    bool ispressed = false; //true - pressed

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        if (!ispressed)
        {
            toggle.transform.Translate(0, y_change, 0);
            ispressed = true;
        }
        else {
            toggle.transform.Translate(0, y2_change, 0);
            ispressed = false;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}

