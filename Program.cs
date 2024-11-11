
string seguir = "";
int posicion = 0;
string[]nombres=new string[0];   

    do
    {
        Console.WriteLine("escriba el nombre del desayuno");
        string nom = Console.ReadLine();
        Array.Resize(ref nombres,nombres.Length+1);
        nombres[posicion] = nom;
        posicion++;
        Console.WriteLine($"desayuno {nom} agregado");
        Console.WriteLine("desea seguir registrando?[si]");
         seguir =Console.ReadLine();
    } while (seguir == "si");



