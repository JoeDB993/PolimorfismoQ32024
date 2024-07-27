
//Polimorfismo mediante listas
using PolimorfismoQ32024;

List<Edificio>  edificioLista = new List<Edificio> ();
string opcion = "";

do
{
    Edificio edificio = new Edificio();
    Console.WriteLine("Ingrese tipo de edificio: ");
    edificio.Tipo = Console.ReadLine();
    Console.WriteLine("Ingrese el precio: ");
    edificio.Precio = Convert.ToDouble(Console.ReadLine());
    edificioLista.Add(edificio);
    Console.WriteLine("¿Desea continuar? Presione S o s para salir");
    opcion = Console.ReadLine();
} while (opcion != "S" || opcion != "s");

Console.WriteLine();
Console.WriteLine("Lista de edificios");
foreach (Edificio edificio in edificioLista)
{
    edificio.Vender();
}
    