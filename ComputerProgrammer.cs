using System;
namespace CL_SelfTets
{
    public class ComputerProgrammer : IEmployee
    {
        public string Name { get;set; }

        public ComputerProgrammer(string name)
        {
            Name = name;
        }

        public string DoWork(int hoursPerDay)
        {
            return $"writes code {hoursPerDay} hours a day";
        }
    }
}

