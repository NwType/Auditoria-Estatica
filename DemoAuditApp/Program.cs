using System;

namespace DemoAuditApp
{
    /// <summary>
    /// Clase principal que gestiona el acceso de usuarios basado en la edad.
    /// Cumple con los estándares de seguridad y documentación IEEE 1028.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Punto de entrada de la aplicación.
        /// </summary>
        /// <param name="args">Argumentos de línea de comandos.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Sistema de Validación de Acceso ---");
            Console.WriteLine("Ingrese su edad:");

            try
            {
                string input = Console.ReadLine();

                // Validación de entrada: SE-01 (Seguridad)
                // Se usa TryParse para evitar excepciones por formato incorrecto
                if (int.TryParse(input, out int edad))
                {
                    // Lógica robusta: Verificación de rangos válidos
                    if (edad < 0 || edad > 120)
                    {
                        Console.WriteLine("Error: La edad ingresada no es válida.");
                    }
                    else if (edad >= 18)
                    {
                        Console.WriteLine("Acceso permitido.");
                    }
                    else
                    {
                        Console.WriteLine("Acceso denegado: Debe ser mayor de edad.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Debe ingresar un número entero válido.");
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones: SE-02 (Seguridad)
                // Previene el cierre inesperado de la aplicación
                Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
            }
            
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
