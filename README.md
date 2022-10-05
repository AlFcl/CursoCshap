## Documentación de curso de C#
**Este sera mi documentación donde colocaré distintos tipos de apuntes relacionados con c# **


## **C#: ¿qué es?**

Ante la pregunta qué es C# la respuesta más básica y sencilla es: un **lenguaje de programación**. Pero como es lógico, esta explicación te sabrá a poco. C# ha sido desarrollado por Microsoft con el objetivo de permitir a los desarrolladores crear una multitud de aplicaciones ejecutadas en **.NET _Framework_** (una tecnología que admite la compilación y ejecución de aplicaciones y servicios web XML).

C# es un lenguaje **sencillo, con seguridad de tipos y orientado a objetivos**. Su sintaxis es fácil de aprender y muy intuitiva, lo que hace que cualquier persona familiarizada con algún otro tipo de lenguaje de programación aprenda en poco tiempo a utilizarlo.

## **C#: orígenes, ¿quién lo inventó?**

**Andrés Hejlsberg** decidió formar un equipo de trabajo en 1999 para crear un nuevo lenguaje de programación, que hoy conocemos como C#. En cambio, en sus inicios el nombre inicial que se barajó fue **Cool** (C _Object Oriented Language_), lo que en español traduciríamos con un lenguaje de programación orientado a objetivos.

C# tiene sus **orígenes en la familia de lenguajes C** y su primera versión, tal y como explica [Microsoft](https://docs.microsoft.com/es-es/dotnet/csharp/whats-new/csharp-version-history), se parecía mucho a **Java**. De hecho, se creó con el fin de ser una alternativa viable en este en Windows. Muchas de sus características fueron evolucionando y mejorando hasta llegar a la versión actual.

Por ejemplo, ahora el lenguaje de C# admite los conceptos de encapsulación, herencia y polimorfismo y **facilita el desarrollo de componentes de software** mediante varias construcciones de lenguaje innovadoras.

## **Características de C#**

Ya te habrá quedado claro que C# es un lenguaje de programación simple, pero vamos a detallar **algunas de sus características más importantes**:

-   **Sintaxis sencilla** que facilita al desarrollador la escritura de código.
-   **Sistema de tipo unificado**, permitiendo realizar operaciones comunes y que los valores de todos los tipos se puedan almacenar, transportar y utilizar de manera coherente.
-   **Orientación a componentes**. Hemos dicho que C# es lenguaje orientado a objetos, pero también a componentes porque permite definir propiedades sin necesidad de crear métodos o usar eventos sin tratar con punteros a funciones.
-   **Espacio de nombres**. Se puede aislar o agrupar código mediante
-   **Bibliotecas**. Todos los compiladores de C# tienen un mínimo de biblioteca de clases disponibles para usar.
-   **Integración con otros lenguajes.**
-   **Multihilo**. En C# puedes dividir el código en múltiples hilos de ejecución, trabajar en paralelo y sincronizarlos al final.



## Tipos de variables

## Variable de Tipo String

En este tipo de variables se almacenan secuencias de caracteres o texto, estos deben estar entre comillas dobles.

    C#
    
    string  postre  =  "Gelatina de Fresa";
    
    Console.WriteLine(postre);
    
    // Devuelve
    
    Gelatina de Fresa

En el ejemplo anterior he colocado el texto o string “Gelatina de Fresa” entre comillas dobles.

## Variable de Tipo Integer

En este tipo de variables podemos almacenar números enteros desde -2147483648 hasta 2147483647, nos sirve para trabajar con cantidades, edades, etc.

    C#
    
    int  stock  =  46;
    
    Console.WriteLine(stock);
    
    // Devuelve
    
    46

En el ejemplo anterior he colocado un stock de unidades 46, el cual es un número.

## Variable de Tipo Char

Dentro de este tipo de variables podemos almacenar un solo caracter entre comillas simples como por ejemplo ‘N’ o ‘c’.

    C#
    
    char  calificación  =  'C';
    
    Console.WriteLine(calificación);
    
    // Devuelve
    
    C

En el ejemplo anterior he colocado la nota C de un alumno dentro de una variable de tipo char.

## Variable de Tipo Booleano

Este tipo de variables solo nos permite usar los valores _true_ o _false_

    C#
    
    bool  existe  =  true;
    
    Console.WriteLine(existe);
    
    // Devuelve
    
    True

En el código anterior coloqué el valor _true_ dentro de la variable booleana **existe**, por ejemplo pude haber verificado si un valor existe (true) o si no existe (false), entonces este tipo de variable nos permite validar si un valor existe o no en el código.

## Variable de Tipo Float

Este tipo de variable permite agregar en su interior números fraccionarios de 3.4 – 038 a 3.4e + 038 y siempre debe finalizar con una letra **F**. Después del punto tiene una precisión de 6 o 7 dígitos.

    C#
    
    float  precio  =  3.55F;
    
    Console.WriteLine(precio);
    
    // Devuelve
    
    3.55

En el código anterior he colocado el precio 3.55 de un producto.

## Variable de Tipo Double

Este tipo de variables es similar al tipo de variable _float_, solo que una variable de tipo _double_ después del punto, tiene una precisión aproximadamente de 15 dígitos, por lo tanto es más seguro usarlo para la mayoría de cálculos u operaciones matemáticas. Al final del número se debe colocar la letra **D**.

    C#
    
    double  precio  =  29.59D;
    
    Console.WriteLine(precio);
    
    // Devuelve
    
    29.59

En el ejemplo anterior al igual que en la variable de tipo _float_ he colocado el precio de un producto.

## Variable de Tipo Long

Este tipo de variable nos permite almacenar en su interior números enteros desde -9223372036854775808 hasta 9223372036854775807, es útil para almacenar números grandes, algo que la variable de tipo int (integer) no permite hacer. Al final del número se debe colocar la letra **L**.

    C#
    
    long  numero  =  73000000000L;
    
    Console.WriteLine(numero);
    
    // Devuelve
    
    73000000000

## Todas las Variables Juntas

A continuación veamos todas las variables que hemos visto en este Post.

    C#
    
    using  System;
    
    class  MiClaseBonita
    
    {
    
    static  void  Main()
    
    {
    
    string  postre  =  "Gelatina de Fresa";  // String
    
    int  stock  =  46;  // Integer
    
    char  calificación  =  'C';  // Char
    
    bool  existe  =  true;  // Booleano
    
    float  precio  =  3.55F;  // Float
    
    double  precio  =  29.59D;  // Double
    
    long  numero  =  73000000000L;  // Long
    
    }
    
    }



