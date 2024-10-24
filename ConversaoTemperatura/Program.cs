//Problema "temperatura"
//Deseja-se converter uma medida de temperatura da escala Celsius para Fahrenheit ou vice-versa. Para
//isso, você deve construir um programa que leia a letra "C" ou "F" indicando em qual escala vai ser
//informada uma temperatura. Em seguida o programa deve mostrar a temperatura na outra escala com
//duas casas decimais.

using System.Globalization;

namespace ConversaoTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;
            char escala;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Voce vai digitar a temperatura em qual escala (C/F)? ");
            escala = char.Parse(Console.ReadLine());

            if (escala == 'F')
            {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                fahrenheit = double.Parse(Console.ReadLine(), CI);

                celsius = (fahrenheit - 32) * 5 / 9;

                Console.Write($"Temperatura equivalente em Celsius: {celsius.ToString("F2", CI)}");
            }
            else
            {
                Console.Write("Digite a temperatura em Celsius: ");
                celsius = double.Parse(Console.ReadLine(), CI);

                fahrenheit = (celsius * 9 / 5) + 32;

                Console.Write($"Temperatura equivalente em Fahrenheit: {fahrenheit.ToString("F2", CI)}");
            }
        }
    }
}
