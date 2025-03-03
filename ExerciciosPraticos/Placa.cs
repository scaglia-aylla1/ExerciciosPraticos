
namespace ExerciciosPraticos;

/*1. Crie um programa em que o usuário precisa digitar a placa de um veículo e o 
 * programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
    - A placa deve ter 7 caracteres alfanuméricos;
    - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
    - Os quatro últimos caracteres são números;
    Ao final, o programa deve exibir Verdadeiro se a placa for válida e Falso caso contrário.
 */
public class Placa
{
    public string PlacaVeiculo { get; set; }

    // Construtor para inicializar a placa
    public Placa(string placa)
    {
        PlacaVeiculo = placa;
    }

    // Método que verifica se a placa é válida
    public bool IsValida()
    {
        // Expressão regular para verificar o padrão da placa
        string padrao = @"^[A-Za-z]{3}\d{4}$";
        return System.Text.RegularExpressions.Regex.IsMatch(PlacaVeiculo, padrao);
    }
}
