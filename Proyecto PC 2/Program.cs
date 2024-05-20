using Proyecto_PC_2;

Console.WriteLine("Bienvenido a The World of Chess");
Console.WriteLine("");

Console.WriteLine("A continuación se mostrara la tabla de Ajedrez:");

Tablero tab = new Tablero();
Pieza piezas = new Pieza();

string[,] tablero = new string[8, 8];
Console.WriteLine(tab.LlamarTablero());

int opcion = 0;
            
do
{
    Console.WriteLine(" ");
    Console.WriteLine("Que le gustaria realizar?: ");
    Console.WriteLine("1) Agregar piezas");
    Console.WriteLine("2) Agregar Reina");
    Console.WriteLine("3) Mover Reina");
    Console.WriteLine("4) Imprimir Matriz");
    Console.WriteLine("5) Salir");
    opcion = int.Parse(Console.ReadLine() + "");

    switch (opcion)
    {
        case 1:
            piezas.Agregarpieza();
        break;

        case 2:
            piezas.AgregarReina();
        break;

        case 3:
            piezas.movimientos();
        break;

        case 4:
            piezas.ImprimirMatriz();
        break;

        case 5:
            Console.WriteLine("Se ha salido exitosamente.");
        break;
    }
} while(opcion !=5);