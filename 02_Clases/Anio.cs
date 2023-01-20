using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    public class Anio
    {

        public int TemperaturaMaximaYear { get; set; }
        public int TemperaturaMinimaYear { get; set; }

        public float GetTemperaturaMediaYear()
        {
            return (this.TemperaturaMaximaYear + this.TemperaturaMinimaYear) / 2;
        }

    }
}
