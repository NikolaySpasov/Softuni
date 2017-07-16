
using System;

public abstract class Harvester : TypeOfWorker
{
    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double ororeOutput,double energyRequirement)
        : base(id)
    {
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }


    public double OreOutput
    {
        get { return this.oreOutput; }
        protected set
        {
            if (this.oreOutput < 0 )
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {this.oreOutput}");
            }
            this.oreOutput = value;
        }
    }


    public double EnergyRequirement
    {
        get { return this.energyRequirement; }
        protected set
        {
            if (this.energyRequirement < 0 && this.energyRequirement > 20000)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {this.energyRequirement}");
            }
            this.energyRequirement = value;
        }
    }



}