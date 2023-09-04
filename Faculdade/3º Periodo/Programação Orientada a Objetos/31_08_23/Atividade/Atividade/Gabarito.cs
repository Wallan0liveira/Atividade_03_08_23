using System.ComponentModel;

class Gabarito
{
    private List<char> respostasCorretas;

    public Gabarito(List<char> respostasCorretas)
    {
        this.respostasCorretas = respostasCorretas;
    }

    public char RespostaQuestao(int numeroQuestao)
    {
        if (numeroQuestao >= 1 && numeroQuestao <= respostasCorretas.Count)
        {
            return respostasCorretas[numeroQuestao - 1];
        }
        else
        {
            return '\0'; // Retorna um caractere nulo se a questão não existir no gabarito
        }
    }
}