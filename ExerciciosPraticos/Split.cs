
namespace ExerciciosPraticos;


/*Crie um programa em que o usuário digita uma ou mais palavras e é exibido a 
 * quantidade de caracteres que a palavra inserida tem.
 */
public class Split
{

    public static int ContarCaracteres(string texto)
    {
        int contador = 0;

        foreach (char c in texto)
        {
            if (!char.IsWhiteSpace(c))
            {
                contador++;
            }
        }

        return contador;
    }
}
