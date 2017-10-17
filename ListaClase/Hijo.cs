using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaClase
{
    class Hijo:ManejadorListas
    {
        List<string> listastring = new List<string>;

    
        public override void Agregar(object obj)
        {
            listastring.Add(obj);
        }

        public override object Consultar(int index)
        {
            return listastring[index];
        }

        public override void bool Eliminar(int index)
        {
            if (index == index)
            {
                listastring.Add("");
                return true;
            }
            return false;
        }

    }
}
