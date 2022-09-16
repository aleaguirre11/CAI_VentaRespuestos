using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_VentaRespuestos.Entidades
{
    public class VentaRepuesto
    {
        public VentaRepuesto(string nombre, string direccion)
        {
            _nombre = nombre;
            _direccion = direccion;
            _listaProductos = new List <Repuesto>();

        }

        private string _nombre;
        private string _direccion;  
        private List <Repuesto> _listaProductos;


        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;    
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

        public List <Repuesto> ListaProductos
        {
            get
            {
                return _listaProductos;
            }
        }
    }
}
