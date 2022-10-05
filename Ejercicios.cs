using System;
using System.Text;
/*
Ejercicio 1
 Escribe un programa que reciba tu nombre y lo escriba por consola.
 
 */

Console.WriteLine("Escribe tu nombre");
string nombre = Console.ReadLine();
Console.WriteLine("Tu nombre es: " + nombre);

/*
 * Ejercicio 2
 * Escribe un programa que tome la hora y la escriba por pantalla.
 * 
 */

Console.WriteLine("Escribe la hora");
string hora = Console.ReadLine();
Console.WriteLine("La hora es: " + hora);



/*------------------------------SECCION 2--------------- */


/*
Ejercicio 1
Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc
 
 */





        Console.WriteLine("Escribe tu nombre");
        string nombre2 = Console.ReadLine();
        Console.WriteLine("Escribe tu apellido");
        string apellido = Console.ReadLine();
        Console.WriteLine("Escribe tu edad");
        string edad = Console.ReadLine();
        Console.WriteLine("Sabe programar? (si/no)");
        string sabeProgramar = Console.ReadLine();
        Console.WriteLine("Tu nombre es: " + nombre2 + " " + apellido + ", tu edad es: " + edad + " y " + sabeProgramar + " sabes programar");
