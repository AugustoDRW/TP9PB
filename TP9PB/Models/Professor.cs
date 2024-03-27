using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9PB.Models
{
    public class Professor
    {
        public int matricula { get; set; }
        public string Nome { get; set; }

        public Professor(int matricula, string nome) {
        
            this.matricula = matricula;
            Nome = nome;
        }
    }
}

