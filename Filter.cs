using System;

namespace CoffeeMachine
{
    public class Filter
    {
        public int FilterPercentage { get; private set; }
        public Filter(int filterPercentage)
        {
            FilterPercentage = filterPercentage;
        }
    }
}
