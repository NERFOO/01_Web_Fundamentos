using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    public enum TipoGenero { Masculino, Femenino }
    public enum Paises { España, Italia, EEUU, Polonia }

    public class Persona
    {
        #region CAMPOS DE PROPIEDAD 
        private TipoGenero _Genero;
        private int _Edad;
        #endregion

        public Persona() {
            this.DomicilioVacaciones = new Direccion("AA", "AAA", 1111);
        }

        #region PROPIEDADES
        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }

        //DE ESTA MANERA HABRIA QUE HACERLO PARA CORREGIR ERRORES DE SEGURIDAD
        public TipoGenero Genero
        {
            get { return this._Genero; }
            set
            {
                if (value != TipoGenero.Masculino &&
                    value != TipoGenero.Femenino)
                {
                    throw new Exception("Valor no disponible en enumeración");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        public Paises Nacionalidad { get; set; }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public int Edad
        {
            get
            {
                return this._Edad;
            }
            set
            {
                //DESEAMOS COMPROBAR EL DATO QUE VIENE DENTRO DE VALUE
                if(value < 0)
                {
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;
                }
            }
        }
        #endregion

        #region
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        //QUEREMOS DEVOLVER EL NOMBRE EN ORDEN INVERSO
        public string GetNombreCompleto(bool orden)
        {
            if (orden == true)
            {
                return this.Apellidos + " " + this.Nombre;
            }
            else
            {
                return this.GetNombreCompleto();
            }
        }
        public void GetNombreCompleto(string dato) { }
        public void GetNombreCompleto(int numero) { }
        public void GetNombreCompleto(int num1, int num2) { }

        //SI LE ENVIAS VALOR LOS RECOGE, PERO SI ESTA IGUALADO ES "OPCIONAL" YA QUE SI NO SE ENVIA RECOGE EL VALOR ASIGNADO PREESTABLECIDO
        public void MetodoParametrosOpcionales(int numero1, int numero2 = 1212)
        {

        }
        #endregion
    }
}
