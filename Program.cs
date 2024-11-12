using Purbea;

Desayuno E = new Desayuno();
string regresar = "";
do{
    Console.WriteLine("--- Menú de Desayunos ---");
    Console.WriteLine("a) Crear desayuno");
    Console.WriteLine("b) Listar desayunos");
    Console.WriteLine("c) Eliminar desayuno");
    Console.WriteLine("d) Fin");
    Console.Write("Selecciona una opción: ");
    string opcion = Console.ReadLine();

    switch (opcion){
        case "a":
            E.desayunos();
            break;
        case "b":
            E.Lista();
            break;
        case "c":
            E.Eliminar();
            break;
        case "d":
            Console.WriteLine("Esta seguro?");
            break;
        default:
            Console.WriteLine("opcion no valida, vuelva a intentar");
            break;
    }

    Console.WriteLine("regresar al menú [si/no]:");
    regresar = Console.ReadLine();
    Console.Clear();

} while (regresar == "si");
