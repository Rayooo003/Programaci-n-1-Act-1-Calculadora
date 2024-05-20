
//Es una colección de clases e interfaces fundamentales de C#
using System;

//Nombre del programa
namespace CalculadoraBásica1
{
    //Clase para crear objetos y definir el tipo de datos y las operaciones disponibles.
    class Program
    {
        //Static void es un método que no devuelve ningún valor, Main es el punto de entradada del programa, String [] args es un arreglo
        //que contiene los argumentos de línea de comandos que se pueden pasar al programa
        static void Main(string[] args)
        {

            //Se imprime en la consola en mensaje CASIO 
            Console.WriteLine("CASIO");

            //Imprime en la consola una orden al usuario
            Console.Write("Ingrese el primer número: ");

            //Lee la información usada por el usuario
            double num1 = Convert.ToDouble(Console.ReadLine());

            //Imnprime en la consola una orden al usuario
            Console.Write("Ingrese el segundo número: ");

            //Lee la información usada por el usuario
            double num2 = Convert.ToDouble(Console.ReadLine());

            //Imprime en la consola una orden aln usuario pqara elegir la operación a realizar
            Console.WriteLine("Elige la operación a realizar:");

            //Imprime en la consola la opción 1 suma
            Console.WriteLine("\t1 - Suma");

            //Imprime en la consola la opción 2 resta
            Console.WriteLine("\t2 - Resta");

            //Imprime en la consola la opción 3 multiplicación
            Console.WriteLine("\t3 - Multiplicación");

            //Imprime en la consola la opción 4 división
            Console.WriteLine("\t4 - División");

            //Imprime en la consola la opción selaccionada por el usuario
            Console.Write("Opción: ");

            //Pide al usuario que ingrese su elección de operación y la convierte a un entero que se almacena en opcion
            int opcion = Convert.ToInt32(Console.ReadLine());


            //Se declara la variabale resultado y es de tipo doble aquíi se almacenará el resultado 
            double resultado = 0;

            //Switch es una estructura para contrulen este caso lo usamos para ejecutar diferentes bloques en base al valor de opcion
            switch (opcion)
            {

                //Si el usuario elige la opción 1, se realiza la suma del num1 y num2 , se alamacena en resultado y break termina la ejecución
                case 1:
                    resultado = num1 + num2;
                    break;

                //Si el usuario elige la opción 2, se realiza la resta del num1 y num2 , se alamacena en resultado y break termina la ejecución
                case 2:
                    resultado = num1 - num2;
                    break;

                //Si el usuario elige la opción 3, se realiza la multiplicación del num1 y num2 , se alamacena en resultado y break termina la ejecución
                case 3:
                    resultado = num1 * num2;
                    break;

                //Si el usuario elige la opción 4 , se realiza la división del num1 y num2
                //además se verifica que alguno de los números no sea sero y da un mensaje de , se alamacena en resultado y break termina la ejecución
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre cero, tonoto.");
                    }
                    break;
                default:
                    Console.WriteLine("Error intente nuevamente.");
                    break;
            }


            // Si la operación no incluye una división que incluya el cero, si todo es correcto se imprime en la consola el resultado
            if (opcion >= 1 && opcion <= 4 && !(opcion == 4 && num2 == 0))
            {
                Console.WriteLine($"El resultado es: {resultado}");
            }
            //Al finalizar  el programa se le pide al usuario presionar caulquier tecla para salir 
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}