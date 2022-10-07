
/*
 * Ejercicio 1

Crea una estructura de datos para un cliente con estos campos:

Nombre completo

Teléfono

Dirección

Email

Si es nuevo cliente

Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)
 * 
 * 
 *
a
*/
Clientes Misclientes = new Clientes();

Misclientes.nombre2 = "Gonzalo Loyola";
Misclientes.telefono2 = "123456789";
Misclientes.direccion2 = "Calle falsa123";
Misclientes.email2 = "contacto@gloyola.cl";
Misclientes.esNuevoCliente2 = true;

Console.WriteLine("Nombre: " + Misclientes.nombre2);
Console.WriteLine("Telefono: " + Misclientes.telefono2);
Console.WriteLine("Direccion: " + Misclientes.direccion2);
Console.WriteLine("Email: " + Misclientes.email2);
Console.WriteLine("Es nuevo cliente: " + Misclientes.esNuevoCliente2);
Console.WriteLine("------------------------\n");

public struct Clientes  //estructura de datos
{
    public string nombre2 { get; set; }
    public string telefono2 { get; set; }
    public string direccion2 { get; set; }
    public string email2 { get; set; }
    public bool esNuevoCliente2 { get; set; }

}


