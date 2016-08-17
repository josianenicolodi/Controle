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

            Aluno al = new Aluno(4f, 5.3f, 9f);

            Console.WriteLine("Media: " + al.GetMedia());
            Console.WriteLine("Aluno foi: " + al.Passou());

            Console.ReadLine();
        }
    }
}
