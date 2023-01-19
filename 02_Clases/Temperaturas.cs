using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{


    public class Temperaturas
    {
        private List<string> _Meses;
        private int _Maxima;
        private int _Minima;

        public List<string> Meses()
        {
            return GetMeses();
        }


        public List<string> GetMeses()
        {
            List<string> months = new List<string> { };
            DateTime fecha = DateTime.Parse("01/01/2023");

            for(int i = 0; i < 12; i++)
            {
                string mesNombre = fecha.ToString("MMMM");
                fecha.AddMonths(1);
                months.Add(mesNombre);
            }
            return months;
        }


    }
}
