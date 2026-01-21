using System;

namespace DemoAuditApp
{
    /// <summary>
    /// Clase principal que gestiona el acceso de usuarios.
    /// Implementada siguiendo estándares de calidad y seguridad IEEE 1028.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Punto de entrada principal de la aplicación.
        /// Realiza la lectura de edad con validación de nulidad y formato.
        /// </summary>
        /// <param name="args">Argumentos de la línea de comandos.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Auditoría de Sistemas: Verificación de Acceso ---");
            Console.WriteLine("Ingrese su edad:");

            try
            {
                // Solución al error CS8600: Se usa 'string?' para permitir nulos 
                // o se maneja el valor predeterminado para asegurar que 'input' no sea nulo.
                string? input = Console.ReadLine();

                // Validación de entrada (Atiende Hallazgo de Seguridad SE-01)
                if (int.TryParse(input, out int edad))
                {
                    // Lógica reforzada para rangos de edad
                    if (edad < 0 || edad > 125)
                    {
                        Console.WriteLine("Error: La edad ingresada está fuera de un rango lógico.");
                    }
                    else if (edad >= 18)
                    {
                        Console.WriteLine("Acceso permitido.");
                    }
                    else
                    {
                        Console.WriteLine("Acceso denegado: Menor de edad.");
                    }
                }
                else
                {
                    // Manejo de datos no numéricos
                    Console.WriteLine("Error: La entrada no es un número entero válido.");
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones (Atiende Hallazgo de Seguridad SE-02)
                Console.WriteLine($"Se produjo un error inesperado durante la ejecución: {ex.Message}");
            }

            Console.WriteLine("\nPresione cualquier tecla para cerrar la aplicación...");
            Console.ReadKey();
        }
    }
}
