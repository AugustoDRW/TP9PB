using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP9PB.Models.TP9ProjetodeBloco.Models;

namespace TP9PB.Models
{
    public class Aluno
    {

        public int matricula { get; set; }
        public string Nome { get; set; }
        public List<Turma> ListaTurmas { get; set; }

        public Aluno(int matricula, string nome)
        {
            this.matricula = matricula;
            Nome = nome;
            ListaTurmas = new List<Turma>();
        }

        public string AddTurma(Turma turma)
        {
            ListaTurmas.Add(turma);
            return "Aluno adicionado na turma "+ turma.codigo;
        }

        public string ExibirTurmas()
        {
            string mensagem = "O aluno esta nas turmas: \n";
            foreach (var i in ListaTurmas)
            {
                mensagem += i.codigo + "\n";
            }
            return mensagem;
        }

    }
}

