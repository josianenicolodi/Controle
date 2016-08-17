using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTurma
{
    class Aluno
    {
        public float nota1;
        public float nota2;
        public float nota3;

        public Aluno(float n1,float n2, float n3)
        {
            nota1 = n1;
            nota2 = n2;
            nota3 = n3;
        }

        public float GetMedia()
        {
            float media = nota1 + nota2 + nota3;
            media = media / 3;
            return media;
        }

        public string Passou()
        {
            if(GetMedia() > 7f)
            {
                return "Passou";
            }
            return "Reprovou";
        }
    }
}
