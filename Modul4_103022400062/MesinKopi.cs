using System;

public class MesinKopi
{
    // ENUM untuk state
    public enum State
    {
        OFF,STANDBY, BREWING, MAINTENANCE
    }

    private State currentState;

    // Constructor (state awal OFF)
    public MesinKopi()
    {
        currentState = State.OFF;
        Console.WriteLine("State awal: OFF");
    }

    public void PowerOn()
    {
        if (currentState == State.OFF)
        {
            currentState = State.STANDBY;
            Console.WriteLine("OFF -> STANDBY");
        }
        else
        {
            Console.WriteLine("Tidak bisa PowerOn dari state " + currentState);
        }
    }

    public void PowerOff()
    {
        if (currentState == State.STANDBY)
        {
            currentState = State.OFF;
            Console.WriteLine("STANDBY -> OFF");
        }
        else
        {
            Console.WriteLine("Tidak bisa PowerOff dari state " + currentState);
        }
    }

    public void StartBrew()
    {
        if (currentState == State.STANDBY)
        {
            currentState = State.BREWING;
            Console.WriteLine("STANDBY -> BREWING");
        }
        else
        {
            Console.WriteLine("Tidak bisa StartBrew dari state " + currentState);
        }
    }

    public void FinishBrew()
    {
        if (currentState == State.BREWING)
        {
            currentState = State.STANDBY;
            Console.WriteLine("BREWING -> STANDBY");
        }
        else
        {
            Console.WriteLine("Tidak bisa FinishBrew dari state " + currentState);
        }
    }

    public void StartMaintenance()
    {
        if (currentState == State.STANDBY)
        {
            currentState = State.MAINTENANCE;
            Console.WriteLine("STANDBY -> MAINTENANCE");
        }
        else
        {
            Console.WriteLine("Tidak bisa Maintenance dari state " + currentState);
        }
    }

    public void FinishMaintenance()
    {
        if (currentState == State.MAINTENANCE)
        {
            currentState = State.STANDBY;
            Console.WriteLine("MAINTENANCE -> STANDBY");
        }
        else
        {
            Console.WriteLine("Tidak bisa FinishMaintenance dari state " + currentState);
        }
    }
}