using System;

public class SolarProvider : Provider
{
   
    public SolarProvider(string id, double energyOutput) 
        :base(id,energyOutput)
    {
        this.id = id;
        this.energyOutput = energyOutput;
    }

    public string id { get; set; }
    public double energyOutput { get; set; }
}

