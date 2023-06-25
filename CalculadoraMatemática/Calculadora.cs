using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMatemática
{
    class Calculadora // Nombre de la clase.
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora Básica - MARSFOREVER472"; // Se agrega un título a la ventana de la consola.
            string resp = "";
            do
            {
                int value1 = 0; // Se guarda el valor 1 ingresado en la consola.
                int value2 = 0; // Se guarda el valor 2 ingresado en la consola.
                int ResultadoFinal = 0; // Resultado final de la operación.

                // Se mostrarán los mensajes de las operaciones respectivas en el menú principal.

                Console.WriteLine(" ************** BIENVENIDO DE NUEVO ************** ");
                Console.WriteLine(" Selecciona una operación matemática a realizar: ");
                Console.WriteLine(" + para sumar"); // Suma.
                Console.WriteLine(" - para restar"); // Resta.
                Console.WriteLine(" * para multiplicar"); // Multiplicación.
                Console.WriteLine(" / para dividir"); // División.
                Console.Write(" Elige una opción: "); // 4 operaciones a su elección.
                resp = Console.ReadLine(); // Imprime cada respuesta con salto de línea.
                string eleccion = Convert.ToString(resp); // Conversión a términos numéricos.

                //  Mensajes para ingresar sus datos requeridos (opcional).

                Console.WriteLine(" Ingresa 2 números "); // 2 Números cualquiera.
                Console.Write("Valor 1: "); // Ingresar primer valor.
                value1 = int.Parse(Console.ReadLine()); // Imprime el valor 1 ingresado en la consola.
                Console.WriteLine("Valor 2: "); // Ingresar segundo valor.
                value2 = int.Parse(Console.ReadLine()); // Imprime el valor 2 ingresado en la consola.
                Console.WriteLine(); // Imprime todo por líneas.

                switch (eleccion) // 4 operaciones aritméticas a su elección.
                {
                    case "+": // En caso de que sea la suma.
                        Console.WriteLine("La suma total es: ");
                        ResultadoFinal = value1 + value2; // Imprime el resultado final de la suma.
                        Console.WriteLine("{0} + {1} = {2}", value1, value2, ResultadoFinal); // Se apoya mediante texto como se calcula la suma.
                        break;

                    case "-": // En caso de que sea la resta.
                        Console.WriteLine("La resta total es: ");
                        ResultadoFinal = value1 - value2; // Imprime el resultado final de la resta.
                        Console.WriteLine("{0} - {1} = {2}", value1, value2, ResultadoFinal); // Se apoya mediante texto como se calcula la resta.
                        break;

                    case "*": // En caso de que sea la multiplicación.
                        Console.WriteLine("La multiplicación total es: ");
                        ResultadoFinal = value1 * value2; // Imprime el resultado final de la multiplicación.
                        Console.WriteLine("{0} * {1} = {2}", value1, value2, ResultadoFinal); // Se apoya mediante texto como se calcula la multiplicación.
                        break;

                    case "/": // En caso de que sea la división.
                        Console.WriteLine("La división total es: ");
                        ResultadoFinal = value1 / value2; // Imprime el resultado final de la división.
                        Console.WriteLine("{0} / {1} = {2}", value1, value2, ResultadoFinal); // Se apoya mediante texto como se calcula la división.
                        break;
                }
                Console.Write(" ¿Desea continuar? s/n: "); // Escibir s para continuar y n para salir.
                resp = Console.ReadLine();
            }
            while (resp == "s" || resp == "s");
        }
    }
}
