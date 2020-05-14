using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class DistanceMode : Mode
    {
        public DistanceMode(Form1 _host) : base(_host){}

        public override string ToString()
        {
            return "Distance Mode";
        }
    }
}
