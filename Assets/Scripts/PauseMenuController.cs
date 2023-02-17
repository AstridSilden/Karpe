using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    private float _timeScale = 1f;
    
    private void Start()
    {
        Time.timeScale = _timeScale;
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
        }
    }
}
