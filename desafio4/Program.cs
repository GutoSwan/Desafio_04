

using desafio4;

Aluno orlandoAluno = new Aluno("orlando", 24, 9.5);

Aluno scobyAluno = new Aluno("scoby", 22, 4);

Aluno chubsAluno = new Aluno("chubs", 65, 10);

List<Aluno> alunos = new List<Aluno>();
alunos.Add(orlandoAluno);
alunos.Add(scobyAluno);
alunos.Add(chubsAluno);

var somaDasNotas = alunos.Select(x => x.nota).Sum();
Console.WriteLine(somaDasNotas);

var somaFinal = alunos.ToArray().Select(x => x.nota).Sum();
Console.WriteLine(somaFinal);
Console.ReadKey();