using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This exercise will help you calm your mind and relax by focusing on your breathing")
    
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        bool breatheIn = true;

        while (DateTime.Now < endTime)
        {
            if (breatheIn)
            {
                Console.Write("Inhale slowly... ");
            }
            else
            {
                Console.Write("Exhale gently... ");
            }

            int secondsLeft = (int)(endTime - DateTime.Now).TotalSeconds;
            int pauseTime = Math.Min(4, secondsLeft);
            ShowCountDown(pauseTime);
            Console.WriteLine();

            breatheIn = !breatheIn;
        }

        DisplayEndingMessage();
    }
}