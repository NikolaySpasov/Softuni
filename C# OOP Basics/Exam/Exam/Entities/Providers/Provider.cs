
using System;

public abstract class Provider :TypeOfWorker
{
    private string id;
    private double energyOutput;

    public Provider(string id, double energyOutput)
        :base(id)
    {
        this.EnergyOutput = energyOutput;
    }


    public double EnergyOutput
    {
        get { return this.energyOutput; }
        protected set
        {
            if (this.energyOutput < 0 && this.energyOutput > 10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's {this.energyOutput}");
            }
            energyOutput = value;
        }
    }
}

