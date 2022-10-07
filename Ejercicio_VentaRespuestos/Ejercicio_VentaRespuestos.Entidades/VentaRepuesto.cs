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
            _listaRepuestos.Add(repuesto);
        }

        public void QuitarRepuesto(int codigo)
        {
            bool flag = false;

            foreach(Repuesto repuesto in ListaRepuestos)
            {
                if(repuesto.Codigo == codigo)
                {
                    if(repuesto.Stock != 0)
                    {
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }

                    if(flag == true)
                    {
                        ListaRepuestos.Remove(repuesto);
                    }

                }
            }
        }

        public void ModificarPrecio(int codigo, double precio)
        {
            foreach (Repuesto repuesto in _listaRepuestos)
            {
                if (repuesto.Codigo == codigo)
                {
                    repuesto.Precio = precio;   
                }
            }
        }

        public void AgregarStockRepuesto(int codigo, int stock)
        {
            foreach (Repuesto repuesto in _listaRepuestos)
            {
                if(repuesto.Codigo == codigo)
                {
                    repuesto.Stock += stock;
                }
            }
        }

        public void QuitarStockRepuesto(int codigo, int stock)
        {
            bool flag = false;
 
            foreach (Repuesto repuesto in _listaRepuestos)
            {
                if (repuesto.Codigo == codigo)
                {
                    if(repuesto.Stock < stock)
                    {
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                    if (flag == true)
                    {
                        repuesto.Stock -= stock;                      
                    }
                }
            }
        }

        //public Repuesto TraerCategoria(int codigo)
        //{

        //}

    }
}
