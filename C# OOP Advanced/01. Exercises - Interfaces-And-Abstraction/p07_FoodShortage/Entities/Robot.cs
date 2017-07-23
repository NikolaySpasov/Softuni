﻿namespace p07_FoodShortage
{
    public class Robot : IRobot, IIdable
    {
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model { get; }
        public string Id { get; }
    }
}