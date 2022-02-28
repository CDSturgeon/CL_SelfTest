using System;
namespace CL_SelfTets
{
    public interface IEmployee
    {
        public string Name { get; set; }

        public string DoWork(int hoursPerDay);
    }
}

