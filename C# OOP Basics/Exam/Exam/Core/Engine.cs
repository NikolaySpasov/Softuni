using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private bool isRunning;
    private DraftManager draftmanager;

    public Engine()
    {
        this.isRunning = true;
        this.draftmanager = new DraftManager();

        
    }


    public void Run()
    {
        while (this.isRunning)
        {
            var commandParameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            this.DistributeCommand(commandParameters);
        }
    }

    private void DistributeCommand(List<string> commandParameters)
        
    {
        string command = commandParameters[0];
        commandParameters.Remove(command);

        switch (command)
        {
            case "RegisterHarvester":
                draftmanager.RegisterHarvester(commandParameters);
                break;
            case "RegisterProvider":
                draftmanager.RegisterProvider(commandParameters);
                break;
            case "Day":
                draftmanager.Day();
                break;
            case "Mode":
                draftmanager.Mode(commandParameters);
                break;
            case "Check":
                draftmanager.Check(commandParameters);
                break;
            case "Shutdown":
                draftmanager.ShutDown();
                this.isRunning = false;
                break;


        }
    }
}

