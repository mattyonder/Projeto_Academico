using Projeto_Academico.Models;

    Menu menu = new Menu();

//Colocar tudo dentro de um While

    Console.WriteLine(menu.GetMenu());
    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:

        string? nomeAluno;
        char sexoAluno;
        string? localNascimentoAluno;
        string? dataNascimentoAluno;
        double? nota1Aluno, nota2Aluno, nota3Aluno;

        Console.WriteLine("n-----------------------------");
        
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

        break;
    }

    







   
