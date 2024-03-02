using System;

class Program
{
    static void Main()
    {
        JuegoAdivinanza();

        Console.WriteLine("\nFin del programa.");
    }

    static void JuegoAdivinanza()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int intentos = 0;
        int intentoUsuario;

        Console.WriteLine("¡Bienvenido al juego de adivinanza!");

        do
        {
            Console.Write("Ingrese un número entre 1 y 100: ");
            while (!int.TryParse(Console.ReadLine(), out intentoUsuario) || intentoUsuario < 1 || intentoUsuario > 100)
            {
                Console.Write("Ingrese un número válido entre 1 y 100: ");
            }

            if (intentoUsuario < numeroSecreto)
                Console.WriteLine("El número secreto es mayor. Intenta de nuevo.");
            else if (intentoUsuario > numeroSecreto)
                Console.WriteLine("El número secreto es menor. Intenta de nuevo.");

            intentos++;
        } while (intentoUsuario != numeroSecreto);

        Console.WriteLine($"¡Felicidades! Has adivinado el número secreto ({numeroSecreto}) en {intentos} intentos.");
    }
}
