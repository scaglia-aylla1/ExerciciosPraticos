using ExerciciosPraticos;
using System;

class Program
{
    static void Main()
    {
    //     //exercicio 1
    //    Console.Write("Digite seu nome: ");
    //    string nome = Console.ReadLine();
    //    MensagemBoasVindas.ExibirMensagem(nome);

    //     //exercicio 2
    //    Console.Write("Digite seu nome: ");
    //    string nome1 = Console.ReadLine();
    //    Console.Write("Digite seu sobrenome: ");
    //    string sobrenome = Console.ReadLine();
    //    NomeCompleto.Nome(nome, sobrenome);


    //     //exercicio 3
    //    double num1 = 10.5;
    //    double num2 = 2.5;
    //    Operacoes.Calcular(num1, num2);

    //     //exercicio 4
    //    Console.Write("Digite uma ou mais palavras: ");
    //    string entrada = Console.ReadLine();

    //    int quantidadeCaracteres = Split.ContarCaracteres(entrada);

    //    Console.WriteLine($"A quantidade de caracteres (ignorando espaços) é: {quantidadeCaracteres}");


    //     //exercicio 5
    //     //Solicita ao usuário para digitar a placa
    //    Console.Write("Digite a placa do veículo: ");
    //    string placa = Console.ReadLine();

    //    // Cria uma instância da classe Placa e verifica se a placa é válida
    //    Placa veiculoPlaca = new Placa(placa);
    //    bool valida = veiculoPlaca.IsValida();

    //    // Exibe o resultado
    //    if (valida)
    //    {
    //        Console.WriteLine("Verdadeiro");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Falso");
    //    }


        //exercicio 6
        // Cria uma instância da classe DataFormatada
        DataFormatada data = new DataFormatada();

        // Exibe as opções de formato
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1. Formato completo");
        Console.WriteLine("2. Apenas a data");
        Console.WriteLine("3. Apenas a hora");
        Console.WriteLine("4. Data com mês por extenso");

        int escolha = int.Parse(Console.ReadLine());

        // Exibe a data no formato escolhido
        string resultado = data.ObterDataFormatada(escolha);
        Console.WriteLine(resultado);
    }
}


