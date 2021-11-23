using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Week11
{
    public enum manufracturerName {nissan, ford, dodge };
    class Vehicle
    {
        private int numCyclinders;

        public Vehicle(int numCyclinders)
        {
            this.numCyclinders = numCyclinders;
        }

        public int NumCyclinders { get => numCyclinders; set => numCyclinders = value; }

        public static string manuName(manufracturerName mode)
        {
            if(mode == manufracturerName.dodge)
            {
                return "Dodge";
            }
            else if(mode == manufracturerName.ford)
            {
                return "ford";
            }
            else
            {
                return "nissan";
            }
        }
    }
}
