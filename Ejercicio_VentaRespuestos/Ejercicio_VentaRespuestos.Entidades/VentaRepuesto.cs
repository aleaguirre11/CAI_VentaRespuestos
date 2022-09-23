using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_VentaRespuestos.Entidades
{
    public class VentaRepuesto
    {
        public VentaRepuesto(string nombreComercio, string direccion)
        {
            _nombreComercio = nombreComercio;
            _direccion = direccion;
            _listaRepuestos = new List <Repuesto>();

        }

        private string _nombreComercio;
        private string _direccion;  
        private List <Repuesto> _listaRepuestos;


        public string NombreComercio
        {
            get
            {
                return _nombreComercio;
            }
            set
            {
                _nombreComercio = value;    
            }
        }

        public string Direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                _direccion = value;
            }
        }

        public List <Repuesto> ListaRepuestos
        {
            get
            {
                return _listaRepuestos;
            }
        }

        public void AgregarRepuesto(Repuesto repuesto)
        {

        }

        public void QuitarRepuesto(int codigo)
        {

            foreach(Repuesto repuesto in _listaRepuestos)
            {
                if(repuesto.Codigo == codigo)
                {
                    _listaRepuestos.RemoveAt(repuesto.Codigo);

                }
            }
        }
    }
}
