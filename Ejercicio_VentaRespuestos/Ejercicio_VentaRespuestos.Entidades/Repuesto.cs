using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_VentaRespuestos.Entidades
{
    public class Repuesto
    {
        public Repuesto(int codigo, string nombre, double precio, int stock)
        {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
            _stock = stock;
            _categorias = new List<Categoria>();           
        }

        private int _codigo;
        private string _nombre; 
        private double _precio; 
        private int _stock;
        private List<Categoria> _categorias;       

        public int Codigo
        {
            get
            {
                return _codigo; 
            }
            set
            {
                _codigo = value;    
            }
        }

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

        public double Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio= value;
            }
        }

        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock= value;
            }
        }

        public List<Categoria> Categorias
        {
            get
            {
                return _categorias;
            }
        }
    }
}
