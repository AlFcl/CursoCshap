using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class prueba
{
    public static void Main()
    {
        Console.WriteLine("Escribe tu nombre");
        string nombre2 = Console.ReadLine();
        Console.WriteLine("Escribe tu apellido");
        string apellido = Console.ReadLine();
        Console.WriteLine("Escribe tu edad");
        string edad = Console.ReadLine();
        Console.WriteLine("Sabe programar? (si/no)");
        string sabeProgramar = Console.ReadLine();
        Console.WriteLine("Tu nombre es: " + nombre2 + " " + apellido + ", tu edad es: " + edad + " y " + sabeProgramar + " sabes programar");
    }
}

