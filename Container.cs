using System;

namespace CoffeeMachine
{
    public class Container
    {
        public int FillLimit { get; private set; }
        public string Item { get; private set; }
        public Container(int fillLimit, string item)
        {
            Item = item;
            FillLimit = fillLimit;
        }
    }
}
