using System;
using System.Text;
/*
Ejercicio 1
 Escribe un programa que reciba tu nombre y lo escriba por consola.
 
 */


Console.WriteLine("Ejercicios en C#\r");
Console.WriteLine("------------------------\n");

Console.WriteLine("Ejercicios 1 seccion 1 \r");
Console.WriteLine("------------------------\n");
Console.WriteLine("Escribe tu nombre");
string? nombre = Console.ReadLine();
Console.WriteLine("Tu nombre es: " + nombre);


Console.WriteLine("------------------------\n");

Console.WriteLine("Ejercicios 2 seccion 1 \r");
Console.WriteLine("------------------------\n");
/*
 * Ejercicio 2
 * Escribe un programa que tome la hora y la escriba por pantalla.
 * 
 */

Console.WriteLine("Escribe la hora");
string? hora = Console.ReadLine();
Console.WriteLine("La hora es: " + hora);

Console.WriteLine("fin seccion 1 \r");
Console.WriteLine("------------------------\n");

/*------------------------------SECCION 2--------------- */

/*
Ejercicio 1
Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc
 
 */


Console.WriteLine("Inicio  seccion 2 \r");
Console.WriteLine("------------------------\n");


Console.WriteLine("Ejercicio 1 seccion 2 \r");
Console.WriteLine("------------------------\n");

Console.WriteLine("Escribe tu nombre");
        string? nombre2 = Console.ReadLine();
        Console.WriteLine("Escribe tu apellido");
        string? apellido = Console.ReadLine();
        Console.WriteLine("Escribe tu edad");
        string? edad = Console.ReadLine();
        Console.WriteLine("Sabe programar? (si/no)");
        string? sabeProgramar = Console.ReadLine();
Console.WriteLine("Tu nombre es: " + nombre2 + " " + apellido + ", tu edad es: " + edad + " y " + sabeProgramar + " sabes programar");


Console.WriteLine("------------------------\n");



Console.WriteLine("Ejercicio 2 seccion 2 \r");
Console.WriteLine("------------------------\n");

/*
 * Ejercicio 2

Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:

Coche: puertas, ruedas, marca, ITV vigente

Mesa: peso, largo, material, color

Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.
 * 
 */


Console.WriteLine("Coche(auto) \r");
Console.WriteLine("Cantidad de puertas?");
int puertas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Cantidad de ruedas?");
int ruedas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Marca?");
string? marca = Console.ReadLine();
Console.WriteLine("ITV vigente? (si/no)");
string? itv = Console.ReadLine();

Console.WriteLine("El auto de la marcar" + marca + " tiene " + puertas + " puertas y " + ruedas + " ruedas, y estado de  ITV vigente " + itv);

Console.WriteLine("------------------------\n");
Console.WriteLine("------------------------\n");

Console.WriteLine("Mesa \r");
Console.WriteLine("Peso?");
int peso = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Largo?");
int largo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Material?");
string? material = Console.ReadLine();
Console.WriteLine("Color?");
string? color = Console.ReadLine();
Console.WriteLine("La mesa de material " + material + " tiene un peso de " + peso + " y un largo de " + largo + " y color " + color);






Console.WriteLine("------------------------\n");


Console.WriteLine("Ejercicio 3 seccion 2 \r");
Console.WriteLine("------------------------\n");

/*
 * Ejercicio 3

Operadores Determina los operadores para verificar las siguientes condiciones:

Un número es mayor o igual a 18

Un char es ‘a’

Se cumplen dos conciones a la vez (ambas verdaderas)

Se cumple una de dos condiciones a la vez (una true y otra false)

Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.*/

Console.WriteLine("Escribe un numero");
int numero = Convert.ToInt32(Console.ReadLine());
if (numero >= 18)
{
    Console.WriteLine("El numero es mayor o igual a 18");
}
else
{
    Console.WriteLine("El numero es menor a 18");
}

Console.WriteLine("Escribe un caracter");
char caracter = Convert.ToChar(value: Console.ReadLine());
if (caracter == 'a')
{
    Console.WriteLine("El caracter es a");
}
else
{
    Console.WriteLine("El caracter no es a");
}

