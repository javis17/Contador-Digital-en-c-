namespace Contador_Digital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array de representaciones digitales de números del 1 al 10
            string[] numerosDigitales = {
            "    \n  |\n  |",        // 1
            " _ \n _|\n|_ ",         // 2
            " _ \n _|\n _|",         // 3
            "   \n|_|\n  |",         // 4
            " _ \n|_ \n _|",         // 5
            " _ \n|_ \n|_|",         // 6
            " _ \n  |\n  |",         // 7
            " _ \n|_|\n|_|",         // 8
            " _ \n|_|\n _|",         // 9
            "   _\n| | |\n| |_|"     // 10
            };

            for (int i = 0; i < numerosDigitales.Length; i++)
            {
                // Limpiar la consola para que solo se vea el número actual
                Console.Clear();
                
                // Imprimir el número actual en formato digital
                Console.WriteLine($"Número {i + 1} en formato digital:");
                Console.WriteLine(numerosDigitales[i]);

                // Esperar 1 segundo antes de pasar al siguiente número
                Thread.Sleep(1000);
            }


        }
    }
}
