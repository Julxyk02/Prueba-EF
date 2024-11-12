using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purbea
{
    internal class Desayuno{
        public string[] nombres = new string[0];
        int posicion = 0;
        string seguir = "";
        public void desayunos(){
            do{
                Console.WriteLine("escriba el nombre del desayuno");
                string nom = Console.ReadLine();
                Array.Resize(ref nombres, nombres.Length + 1);
                nombres[posicion] = nom;
                posicion++;
                Console.WriteLine($"desayuno {nom} agregado");
                Console.WriteLine("desea seguir registrando?[si/no]:");
                seguir = Console.ReadLine();
            } while (seguir == "si");
        }

        public void Lista(){
            Console.WriteLine("Lista de desayunos:");
            for (int i = 0; i < nombres.Length; i++){
                Console.WriteLine($"- {nombres[i]} ");
            }
        }

        public void Eliminar(){
            Console.WriteLine("Ingresar nombre para eliminar:");
            string eliminar = Console.ReadLine();
            int indice = Array.IndexOf(nombres, eliminar);
            if (indice != -1){
                for (int i = indice; i < nombres.Length - 1; i++){
                    nombres[i] = nombres[i + 1];

                }
                Array.Resize(ref nombres, nombres.Length - 1);
                posicion--;
                Console.WriteLine($"Desayuno {eliminar} eliminado");
            }
            else{
                Console.WriteLine("No se puede eliminar porque no existe");
            }
        }
    }
}
