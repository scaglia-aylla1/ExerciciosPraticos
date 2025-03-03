
namespace ExerciciosPraticos;

/*1. Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
    - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
    - Apenas a data no formato "01/03/2024".
    - Apenas a hora no formato de 24 horas.
    - A data com o mês por extenso.
 */
public class DataFormatada
{
    private DateTime dataAtual;

    public DataFormatada()
    {
        dataAtual = DateTime.Now;
    }

    // Método que retorna a data no formato escolhido
    public string ObterDataFormatada(int escolha)
    {
        switch (escolha)
        {
            case 1:
                // Formato completo: dia da semana, dia do mês, mês, ano, hora, minutos, segundos
                return dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss");
            case 2:
                // Apenas a data no formato "01/03/2024"
                return dataAtual.ToString("dd/MM/yyyy");
            case 3:
                // Apenas a hora no formato de 24 horas
                return dataAtual.ToString("HH:mm");
            case 4:
                // Data com o mês por extenso
                return dataAtual.ToString("dd 'de' MMMM 'de' yyyy");
            default:
                return "Opção inválida.";
        }
    }
}
