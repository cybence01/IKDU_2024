using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeeklySchedule : MonoBehaviour
{
    public string DaysOfTheWeek = "Monday";
    public int listDay = 0; //This variable makes it so I can put listDay = into the cases. 
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("Today is {0}", Schedule[listDay]); //This Debug.Log prints out what day it is. The Schedule[listDay] then looks at after the listday attached to the days down in the cases. 

        ScheduleOfTheWeek(); // This Code prints out my switch statements.

        
    }


    public void ScheduleOfTheWeek() // This code block holds all my cases, which are called after the days of the week. Each case has a Debug.Log attached, printing out a thing to do on that date. 
    {
        switch(DaysOfTheWeek)
        {
            case "Monday":
                Debug.Log("Monday: cry because it's monday :(");
                listDay = 0;
                break;
            case "Tuesday":
                Debug.Log("Tuesday: go to school and learn stuff :)");
                listDay = 1;
                break;
            case "Wednesday":
                Debug.Log("Wednesday: go hang out with people after school");
                listDay = 2;
                break;
            case "Thursday":
                Debug.Log("Thursday: be happy - it's almost friday");
                listDay = 3;
                break;
            case "Friday":
                Debug.Log("Friday: go to the bar!");
                listDay = 4;
                break;
            case "Saturday":
                Debug.Log("Saturday: regret the things you did yesterday, and go do it again");
                listDay = 5;
                break;
            case "Sunday":
                Debug.Log("Sunday: have a hangover");
                listDay = 6;
                break; 
        }
    }

    List<string> Schedule= new List<string>() //This code block is a list over the days of the week. 
    {
        "Monday",
        "Tuesday",
        "Wednesday",
        "Thursday",
        "Friday",
        "Saturday",
        "Sunday"
    };
    
        
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
