// Criação do gabarito
Gabarito gabarito = new Gabarito(new List<char> { 'A', 'B', 'C', 'D', 'E' });

// Criação de duas provas com respostas de alunos
Prova prova1 = new Prova(gabarito);
prova1.RespostaAluno('A');
prova1.RespostaAluno('B');
prova1.RespostaAluno('C');
prova1.RespostaAluno('D');
prova1.RespostaAluno('E');

Prova prova2 = new Prova(gabarito);
prova2.RespostaAluno('A');
prova2.RespostaAluno('B');
prova2.RespostaAluno('C');
prova2.RespostaAluno('D');
prova2.RespostaAluno('D');

// Calcula a nota e os acertos de cada prova
Console.WriteLine("Prova 1 - Nota: " + prova1.Nota() + " Acertos: " + prova1.Acertos());
Console.WriteLine("Prova 2 - Nota: " + prova2.Nota() + " Acertos: " + prova2.Acertos());

// Encontra a maior nota entre as duas provas
double maiorNota = Prova.Maior(prova1, prova2);
Console.WriteLine("Maior nota entre as provas: " + maiorNota);