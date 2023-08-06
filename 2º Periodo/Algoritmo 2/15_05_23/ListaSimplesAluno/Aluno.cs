using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimplesAluno
{
    public class Aluno
    {
        // 1 crias a classi
        // 2 mudar ára public a internal classe
        // 3 colocar os atributos
        public string? nome, cpf;
        public double? notas, media;

        // 4 criar o ponteiro, mesmo nome da classe
        // '?' significa que a variavel pode ser nula
        public Aluno? prox;
    }
}
