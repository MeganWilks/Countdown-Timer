using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI TextTimer;
    float ElapsedTime = 10f;
    bool TimeWorking = false;


    private void Start()
    {
        TimeWorking = true;
    }

    void Update()
    {
        if (TimeWorking)
        {
            if (ElapsedTime <= 1)
            {
                ElapsedTime = 0;
                TimeWorking = false;
            }
            else
            {

                ElapsedTime = ElapsedTime - Time.deltaTime; // Subtracts In game time from Elapsed time (60)
                int Minutes = Mathf.FloorToInt(ElapsedTime / 60);
                int Seconds = Mathf.FloorToInt(ElapsedTime % 60);
                TextTimer.text = string.Format("{0:00}:{1:00}", Minutes, Seconds);

            }

           
        }
    }
}
