using Projeto_Academico.Models;

    Aluno aluno = new Aluno();

    Menu menu = new Menu();

    aluno.Nome = "Mateus";
    aluno.Sexo = 'M';
    aluno.DataNascimento = "19/06/2005";
    aluno.LocalNascimento = "Hospital";
    aluno.Nota1 = 7;
    aluno.Nota2 = 8.5;
    aluno.Nota3 = 6.9;

    aluno.Apresentacao();

    Console.WriteLine(menu.GetMenu());

    







   
