using System.ComponentModel.DataAnnotations.Schema;

int posicion = 0;
Console.WriteLine("Ingresar nombre para eliminar: ");
string eliminar = Console.ReadLine();
int indice = Array.IndexOf(nombres,eliminar);
if (indice != -1)
{
    for (int i = indice; i < nombres.Lenght - 1 )
    {
        nombres[i] = nombres[i + 1];
    }
    Array.Resize(ref nombres, nombres.Lenght - 1);
    posicion--;
    Console.WriteLine($"Desayuno {eliminar} eliminado");

}else
{
    Console.WriteLine("No se puede eliminar porque no existe");
}


