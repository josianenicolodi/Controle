using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTurma
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno al = new Aluno();

            Console.WriteLine("Digite o nome do aluno:");
            al.nome = Console.ReadLine();

            Console.WriteLine("Digite o nota1: ");
            al.nota1 = float.Parse( Console.ReadLine() );

            Console.WriteLine("Digite o nota2: ");
            al.nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nota3: ");
            al.nota3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Media: " + al.GetMedia());
            Console.WriteLine(al.nome +" " + al.Passou());

            Console.ReadLine();
        }
    }
}
