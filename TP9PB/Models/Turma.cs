using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9PB.Models
{
    namespace TP9ProjetodeBloco.Models
    {
        public class Turma
        {
            public int codigo { get; set; }
            private int cont = 0;
            public List<Aluno> ListaAlunos { get; set; }

            public Turma(int codigo) {
            
            this.codigo = codigo;
                ListaAlunos = new List<Aluno>();
            }

            public string AddAluno(Aluno aluno)
            {
                ListaAlunos.Add(aluno);
                return "O aluno " + aluno.Nome + " foi adicionado com sucesso";
            }

            public string ExibirAlunos()
            {
                string mensagem = "Na turma possui esses alunos: \n";
                foreach (var i in ListaAlunos)
                {
                    mensagem += i.Nome + "\n";
                }
                return mensagem;
            }

            public string abrirTurma()
            {
                if (cont == 0)
                {
                    cont = 1;
                    return "aberto";
                }
                else
                {
                    cont = 0;
                    return "fechado";
                }

            }

            public string gerarPauta()
            {
                return "pauta gerada";
            }
        }
    }
}
