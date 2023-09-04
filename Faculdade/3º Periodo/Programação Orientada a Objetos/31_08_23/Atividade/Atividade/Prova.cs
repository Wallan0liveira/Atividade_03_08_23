class Prova
{
    private Gabarito gabarito;
    private List<char> respostasAluno;
    private int questaoAtual;

    public Prova(Gabarito gabarito)
    {
        this.gabarito = gabarito;
        this.respostasAluno = new List<char>();
        this.questaoAtual = 0;
    }

    public void RespostaAluno(char resposta)
    {
        if (questaoAtual < gabarito.RespostasCorretas.Count)
        {
            respostasAluno.Add(resposta);
            questaoAtual++;
        }
    }

    public int Acertos()
    {
        int acertos = 0;
        for (int i = 0; i < respostasAluno.Count; i++)
        {
            if (respostasAluno[i] == gabarito.RespostaQuestao(i + 1))
            {
                acertos++;
            }
        }
        return acertos;
    }

    public double Nota()
    {
        int acertos = Acertos();
        int totalQuestoes = gabarito.RespostasCorretas.Count;
        double notaMaxima = 10.0;
        double nota = (acertos / (double)totalQuestoes) * notaMaxima;
        return nota;
    }

    public static double Maior(Prova prova1, Prova prova2)
    {
        int acertosProva1 = prova1.Acertos();
        int acertosProva2 = prova2.Acertos();

        if (acertosProva1 > acertosProva2)
        {
            return prova1.Nota();
        }
        else if (acertosProva2 > acertosProva1)
        {
            return prova2.Nota();
        }
        else
        {
            double notaProva1 = prova1.Nota();
            double notaProva2 = prova2.Nota();
            return Math.Max(notaProva1, notaProva2);
        }
    }
}