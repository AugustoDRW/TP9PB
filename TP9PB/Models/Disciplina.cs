using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9PB.Models
{
    public class Disciplina
    {
        public int codigo { get; set; }
        public string Nome { get; set; }

        public Disciplina(int codigo, string nome)
        {
            this.codigo = codigo;
            Nome = nome;
        }
    }
}
