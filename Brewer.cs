using System;

namespace CoffeeMachine
{
    public class Brewer
    {
        public Container LiquidContainer { get; private set; }
        public Container BeanContainer { get; private set; }
        public Filter MachineFilter { get; private set; }
        public Brewer(Container liquidContainer, Container beanContainer, Filter machineFilter)
        {
            LiquidContainer = liquidContainer;
            BeanContainer = beanContainer;
            MachineFilter = machineFilter;
        }
    }
}
