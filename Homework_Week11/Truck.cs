using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Week11
{
    class Truck : Vehicle
    {
        private double loadCapacity;
        private int towingCapacity;

        public Truck(string truckName, int numCyclinders, double loadCapacity, int towingCapacity) : base(numCyclinders)
        {
            this.NumCyclinders = numCyclinders;
            this.LoadCapacity = loadCapacity;
            this.TowingCapacity = towingCapacity;
            truckName = Vehicle.manuName(manufracturerName.dodge);
        }

        public double LoadCapacity { get => loadCapacity; set => loadCapacity = value; }
        public int TowingCapacity { get => towingCapacity; set => towingCapacity = value; }

        public override bool Equals(object obj)
        {
            return obj is Truck truck &&
                   NumCyclinders == truck.NumCyclinders &&
                   loadCapacity == truck.loadCapacity &&
                   towingCapacity == truck.towingCapacity &&
                   LoadCapacity == truck.LoadCapacity &&
                   TowingCapacity == truck.TowingCapacity;
        }

        public String toString()
        {
            return "Truck| Number of cyclinders [ " + this.NumCyclinders + " ] Towing Capacity [ " + this.towingCapacity + "] Load capacity [ " + this.loadCapacity + "] ";
        }
    }
}
