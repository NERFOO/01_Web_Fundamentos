using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{


    public class Temperaturas
    {
        private string _Meses;
        private int _Maxima;
        private int _Minima;

        public string Meses
        {
            get
            {
                return this._Meses;
            }
            set
            {
                this._Meses = value;
            }
        }


    }
}
