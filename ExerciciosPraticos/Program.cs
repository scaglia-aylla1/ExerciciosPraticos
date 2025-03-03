using ExerciciosPraticos;
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        MensagemBoasVindas.ExibirMensagem(nome);
    }
}

