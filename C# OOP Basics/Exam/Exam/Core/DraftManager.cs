using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private List<Harvester> harvesters;
    private List<Provider> providers;

    public DraftManager()
    {
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
    }

    public string RegisterHarvester(List<string> arguments)
    {
        string type = arguments[0];
        string id = arguments[1];
        double oreOutput = double.Parse(arguments[2]);
        double energyRequired = double.Parse(arguments[3]);
        if (arguments.Count > 4 && type == "Sonic")
        {
            int sonicFactor = int.Parse(arguments[4]);
            var harverster = new SonicHarvester(id, oreOutput, energyRequired, sonicFactor);
            harvesters.Add(harverster);
            Console.WriteLine($"Successfully registered {type} Harvester – {id}"); 
        }
        
        else if(type == "Hammer")
        {
            var harverster = new HammerHarvester(id, oreOutput, energyRequired);
            harvesters.Add(harverster);
        }
        return $"Successfully registered { type} Harvester – { id}";
    }
    public string RegisterProvider(List<string> arguments)
    {
        string type = arguments[0];
        string id = arguments[1];
        double energyOutput = double.Parse(arguments[2]);
        if (type == "Solar" )
        {
            var solarProvider = new SolarProvider(id, energyOutput);
            providers.Add(solarProvider);

        }
        if (type == "Pressure")
        {
            var presureProvider = new PressureProvider(id, energyOutput);
            providers.Add(presureProvider);

        }
        return "Successfully registered {type} Provider – {id}";
    }
    public string Day()
    {
        double energyProvidedThisDay = 0;
        double oreMinedThisDay = 0;
        double totalEnergyRequirement;
        var result = new StringBuilder();

        result.AppendLine($"A day has passed.");
        result.AppendLine($"Energy Provided: {energyProvidedThisDay}");
        result.AppendLine($"Plumbus Ore Mined: {oreMinedThisDay}");

        return result.ToString().Trim();
    }
    public string Mode(List<string> arguments)
    {
        string command = arguments[0];
        string type = arguments[1];
        
        return $"Successfully changed working mode to {type} Mode";
    }
    public string Check(List<string> arguments)
    {
        string command = arguments[0];
        string id = arguments[1];
        return $"No element found with id – {id}";
    }
    public string ShutDown()
    {
        return $"System Shutdown";
    }

}

