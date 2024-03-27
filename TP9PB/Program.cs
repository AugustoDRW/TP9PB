using TP9PB.Models;
using TP9PB.Models.TP9ProjetodeBloco.Models;

namespace TP9PB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Aluno a = new Aluno(1,"Augusto");
            Turma b = new Turma(1);
            Turma c = new Turma(2);
            Aluno d = new Aluno(2, "Ricardo");

            Disciplina e = new Disciplina(1,"Projeto de Bloco");
            Professor f = new Professor(1, "Elberth");






            Console.WriteLine(a.Nome);
            Console.WriteLine(a.matricula);
            Console.WriteLine(a.AddTurma(b));
            Console.WriteLine(a.AddTurma(c));
            Console.WriteLine(b.AddAluno(d));

            Console.WriteLine(a.ExibirTurmas());
            Console.WriteLine(b.ExibirAlunos());


            Console.WriteLine(b.abrirTurma());
            Console.WriteLine(b.abrirTurma());

            Console.WriteLine(b.gerarPauta());


            Console.WriteLine(f.Nome);
            Console.WriteLine(f.matricula);


            Console.WriteLine(e.Nome);
            Console.WriteLine(e.codigo);


        }
    }
}