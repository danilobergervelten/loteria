using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria.Modelo
{
    class Elemento
    {
        public int id;

        public List<int> numeros;

        public DateTime data;

        public Elemento(int id, List<int> numeros, DateTime data)
        {
            this.id = id;
            this.numeros = numeros;
            this.data = data;
        }
    }
}
