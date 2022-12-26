using System;
using Academico.Common.Models;

Menu menu = new Menu();

    int opcao = 0;

    List<Aluno> alunos = new List<Aluno>();

//Colocar tudo dentro de um While
do
{

    Console.WriteLine("\n-----------------------------");
    Console.WriteLine(menu.GetMenu());
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:

        string? nomeAluno;
        char sexoAluno;
        string? localNascimentoAluno;
        string? dataNascimentoAluno;
        double? nota1Aluno, nota2Aluno, nota3Aluno;

        Console.WriteLine("\n-----------------------------");
        
        Console.WriteLine("CADASTRO");

        Console.WriteLine("Digite o nome: ");
        nomeAluno = Console.ReadLine();

        Console.WriteLine("Digite o sexo: ");
        sexoAluno = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Digite o local de nascimento: ");
        localNascimentoAluno = Console.ReadLine();

        Console.WriteLine("Digite a data de nascimento: ");
        dataNascimentoAluno = Console.ReadLine();

        Console.WriteLine("Digite a 1° nota: ");
        nota1Aluno = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a 2° nota: ");
        nota2Aluno = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a 3° nota: ");
        nota3Aluno = Convert.ToDouble(Console.ReadLine());

        Aluno aluno = new Aluno();

        alunos.Add(aluno);

        break;
    
        case 2:

        break;

        case 3:

        string? nomeProfessor;
        char sexoProfessor;
        string? localNascimentoProfessor;
        string? dataNascimentoProfessor;
        string? formacalProfessor;

        Console.WriteLine("\n-----------------------------");
        
        Console.WriteLine("CADASTRO");

        Console.WriteLine("Digite o nome: ");
        nomeProfessor = Console.ReadLine();

        Console.WriteLine("Digite o sexo: ");
        sexoProfessor = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Digite o local de nascimento: ");
        localNascimentoProfessor = Console.ReadLine();

        Console.WriteLine("Digite a data de nascimento: ");
        dataNascimentoProfessor = Console.ReadLine();

        Console.WriteLine("Digite a formação: ");
        formacalProfessor = Console.ReadLine();

        break;

        case 4:

        break;

        case 5:

        string? nomeCoordenador;
        char sexoCoordenador;
        string? localNascimentoCoordenador;
        string? dataNascimentoCoordenador;
        string? cursoCoordenador;

        Console.WriteLine("\n-----------------------------");
        
        Console.WriteLine("CADASTRO");

        Console.WriteLine("Digite o nome: ");
        nomeCoordenador = Console.ReadLine();

        Console.WriteLine("Digite o sexo: ");
        sexoCoordenador = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Digite o local de nascimento: ");
        localNascimentoCoordenador = Console.ReadLine();

        Console.WriteLine("Digite a data de nascimento: ");
        dataNascimentoCoordenador = Console.ReadLine();

        Console.WriteLine("Digite o curso: ");
        cursoCoordenador = Console.ReadLine();

        break;

        case 6:

        break;

        case 7:

        string? nomeEstagiario;
        char sexoEstagiario;
        string? localNascimentoEstagiario;
        string? dataNascimentoEstagiario;
        string? instituicaoEstagiario;
        string? periodoAtualEstagiario;
        string? cursoEstagiario;

        Console.WriteLine("\n-----------------------------");
        
        Console.WriteLine("CADASTRO");

        Console.WriteLine("Digite o nome: ");
        nomeEstagiario = Console.ReadLine();

        Console.WriteLine("Digite o sexo: ");
        sexoEstagiario = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Digite o local de nascimento: ");
        localNascimentoEstagiario = Console.ReadLine();

        Console.WriteLine("Digite a data de nascimento: ");
        dataNascimentoEstagiario = Console.ReadLine();

        Console.WriteLine("Digite a instituição: ");
        instituicaoEstagiario = Console.ReadLine();

        Console.WriteLine("Digite o periodo atual: ");
        periodoAtualEstagiario = Console.ReadLine();

        Console.WriteLine("Digite o curso: ");
        cursoEstagiario = Console.ReadLine();

        break;
    }

} while (opcao != 0);
    

    







   