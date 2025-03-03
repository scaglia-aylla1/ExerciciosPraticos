
namespace ExerciciosPraticos;

/* Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
    - A soma entre esses dois números;
    - A subtração entre os dois números;
    - A multiplicação entre os dois números;
    - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
    - A média entre os dois números.
 */
public class Operacoes
{
    public static void Calcular(double num1, double num2)
    {
        Console.WriteLine($"Soma: {num1 + num2}");
        Console.WriteLine($"Subtração: {num1 - num2}");
        Console.WriteLine($"Multiplicação: {num1 * num2}");

        if (num2 != 0)
        {
            Console.WriteLine($"Divisão: {num1 / num2}");
        }
        else
        {
            Console.WriteLine("Erro: divisão por zero não permitida!");
        }

        Console.WriteLine($"Média: {(num1 + num2) / 2}");
    }
}
