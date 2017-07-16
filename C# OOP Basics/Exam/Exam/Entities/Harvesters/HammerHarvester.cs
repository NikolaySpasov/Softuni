using System;

public class HammerHarvester : Harvester
{


    public HammerHarvester(string id, double ororeOutput, double energyRequirement) 
        : base(id, ororeOutput, energyRequirement)
    {
        this.OreOutput += (ororeOutput * 200 / 100.00);
        this.EnergyRequirement += (energyRequirement * 100 / 100.00) ;
    }


}

