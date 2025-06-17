// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Find the angle between Hour hands and Minute Hands 105 degrees
        double hour = 9;
        double minute = 30;
        //12 hrs 360 degrees so 1 hr 30 degrees
        //1 hr 30 degrees so 1 min 0.5 degrees
        double hourAngle = (hour * 30) + (minute * 0.5);
        //60 mins 360 degrees so 1 min 6 degrees
        double minuteAngle = minute * 6;
        double diff = Math.Abs(hourAngle - minuteAngle);
        //If the angle is greater than 180 degrees, then the smaller angle is 360 - diff
        if (diff > 180)
        {
            diff = 360 - diff;
        }
        Console.WriteLine(diff);
    }
}