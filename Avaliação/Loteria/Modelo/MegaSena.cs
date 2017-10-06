using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria.Modelo
{
    public class MegaSena
    {
        public MegaSena(int id, List<int> numeros, DateTime data)
        {
            this.Id = id;
            this.Numeros = numeros;
            this.Data = data;
        }

        public int Id { get; set; }

        public List<int> Numeros { get; set; }

        public DateTime Data { get; set; }

        public int Acertos { get; set; }
    }
}




    