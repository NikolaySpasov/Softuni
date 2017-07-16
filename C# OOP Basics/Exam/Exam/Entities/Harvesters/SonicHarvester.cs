using System;

public class SonicHarvester : Harvester
{
    private int sonicFactor;

    public SonicHarvester(string id, double ororeOutput, double energyRequirement, int sonicFactor) 
        : base(id, ororeOutput, energyRequirement)
    {
        this.EnergyRequirement /=  sonicFactor;
    }
}

