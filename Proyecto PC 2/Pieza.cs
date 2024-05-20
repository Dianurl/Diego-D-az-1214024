using System.Numerics;

namespace Proyecto_PC_2;

public class Pieza
{
    public string[,] tablero = new string[8, 8];
    public string tipop = " ";
    public string color = " ";


    public void Agregarpieza()
    {

        Console.WriteLine("Que tipo de pieza utilizara?: / T (Torre), A (Alfil), C (Caballo), P (Peon), Ry (Rey)");
        tipop = Console.ReadLine() + "";

        Console.WriteLine("Que color?: / N (Negro) o B (Blanco)");
        color = Console.ReadLine() + "";

        string posiscion;
        Console.WriteLine("Donde desea posiscionar su pieza?: / Escribir en minusculas");
        posiscion = Console.ReadLine() + "";


        switch (posiscion)
        {
            case "a1":
                if (tablero[7, 0] == null)
                {
                    tablero[7, 0] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[7, 0]}");
                }
                break;

            case "a2":
                if (tablero[6, 0] == null)
                {
                    tablero[6, 0] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[6, 0]}");
                }
                break;

            case "a3":
                if (tablero[5, 0] == null)
                {
                    tablero[5, 0] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[5, 0]}");
                }
                break;

            case "a4":
                if (tablero[4, 0] == null)
                {
                    tablero[4, 0] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[4, 0]}");
                }
                break;

            case "a5":
                if (tablero[3, 0] == null)
                {
                    tablero[3, 0] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[3, 0]}");
                }
                break;

            case "a6":
                if (tablero[2, 0] == null)
                {
                    tablero[2, 0] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[2, 0]}");
                }
                break;

            case "a7":
                if (tablero[1, 0] == null)
                {
                    tablero[1, 0] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[1, 0]}");
                }
                break;

            case "a8":
                if (tablero[0, 0] == null)
                {
                    tablero[0, 0] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[0, 0]}");
                }
                break;

            case "b1":
                if (tablero[7, 1] == null)
                {
                    tablero[7, 1] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[7, 1]}");
                }
                break;

            case "b2":
                if (tablero[6, 1] == null)
                {
                    tablero[6, 1] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[6, 1]}");
                }
                break;

            case "b3":
                if (tablero[5, 1] == null)
                {
                    tablero[5, 1] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[5, 1]}");
                }
                break;

            case "b4":
                if (tablero[4, 1] == null)
                {
                    tablero[4, 1] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[4, 1]}");
                }
                break;

            case "b5":
                if (tablero[3, 1] == null)
                {
                    tablero[3, 1] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[3, 1]}");
                }
                break;

            case "b6":
                if (tablero[2, 1] == null)
                {
                    tablero[2, 1] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[2, 1]}");
                }
                break;

            case "b7":
                if (tablero[1, 1] == null)
                {
                    tablero[1, 1] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[1, 1]}");
                }
                break;

            case "b8":
                if (tablero[0, 1] == null)
                {
                    tablero[0, 1] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[0, 1]}");
                }
                break;

            case "c1":
                if (tablero[7, 2] == null)
                {
                    tablero[7, 2] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[7, 2]}");
                }
                break;

            case "c2":
                if (tablero[6, 2] == null)
                {
                    tablero[6, 2] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[6, 2]}");
                }
                break;

            case "c3":
                if (tablero[5, 2] == null)
                {
                    tablero[5, 2] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[5, 2]}");
                }
                break;

            case "c4":
                if (tablero[4, 2] == null)
                {
                    tablero[4, 2] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[4, 2]}");
                }
                break;

            case "c5":
                if (tablero[3, 2] == null)
                {
                    tablero[3, 2] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[3, 2]}");
                }
                break;

            case "c6":
                if (tablero[2, 2] == null)
                {
                    tablero[2, 2] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[2, 2]}");
                }
                break;

            case "c7":
                if (tablero[1, 2] == null)
                {
                    tablero[1, 2] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[1, 2]}");
                }
                break;

            case "c8":
                if (tablero[0, 2] == null)
                {
                    tablero[0, 2] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[0, 2]}");
                }
                break;

            case "d1":
                if (tablero[7, 3] == null)
                {
                    tablero[7, 3] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[7, 3]}");
                }
                break;

            case "d2":
                if (tablero[6, 3] == null)
                {
                    tablero[6, 3] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[6, 3]}");
                }
                break;

            case "d3":
                if (tablero[5, 3] == null)
                {
                    tablero[5, 3] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[5, 3]}");
                }
                break;

            case "d4":
                if (tablero[4, 3] == null)
                {
                    tablero[4, 3] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[4, 3]}");
                }
                break;

            case "d5":
                if (tablero[3, 3] == null)
                {
                    tablero[3, 3] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[3, 3]}");
                }
                break;

            case "d6":
                if (tablero[2, 3] == null)
                {
                    tablero[2, 3] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[2, 3]}");
                }
                break;

            case "d7":
                if (tablero[1, 3] == null)
                {
                    tablero[1, 3] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[1, 3]}");
                }
                break;

            case "d8":
                if (tablero[0, 3] == null)
                {
                    tablero[0, 3] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[0, 3]}");
                }
                break;

            case "e1":
                if (tablero[7, 4] == null)
                {
                    tablero[7, 4] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[7, 4]}");
                }
                break;

            case "e2":
                if (tablero[6, 4] == null)
                {
                    tablero[6, 4] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[6, 4]}");
                }
                break;

            case "e3":
                if (tablero[5, 4] == null)
                {
                    tablero[5, 4] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[5, 4]}");
                }
                break;

            case "e4":
                if (tablero[4, 4] == null)
                {
                    tablero[4, 4] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[4, 4]}");
                }
                break;

            case "e5":
                if (tablero[3, 4] == null)
                {
                    tablero[3, 4] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[3, 4]}");
                }
                break;

            case "e6":
                if (tablero[2, 4] == null)
                {
                    tablero[2, 4] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[2, 4]}");
                }
                break;

            case "e7":
                if (tablero[1, 4] == null)
                {
                    tablero[1, 4] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[1, 4]}");
                }
                break;

            case "e8":
                if (tablero[0, 4] == null)
                {
                    tablero[0, 4] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[0, 4]}");
                }
                break;

            case "f1":
                if (tablero[7, 5] == null)
                {
                    tablero[7, 5] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[7, 5]}");
                }
                break;

            case "f2":
                if (tablero[6, 5] == null)
                {
                    tablero[6, 5] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[6, 5]}");
                }
                break;

            case "f3":
                if (tablero[5, 5] == null)
                {
                    tablero[5, 5] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[5, 5]}");
                }
                break;

            case "f4":
                if (tablero[4, 5] == null)
                {
                    tablero[4, 5] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[4, 5]}");
                }
                break;

            case "f5":
                if (tablero[3, 5] == null)
                {
                    tablero[3, 5] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[3, 5]}");
                }
                break;

            case "f6":
                if (tablero[2, 5] == null)
                {
                    tablero[2, 5] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[2, 5]}");
                }
                break;

            case "f7":
                if (tablero[1, 5] == null)
                {
                    tablero[1, 5] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[1, 5]}");
                }
                break;

            case "f8":
                if (tablero[0, 5] == null)
                {
                    tablero[0, 5] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[0, 5]}");
                }
                break;

            case "g1":
                if (tablero[7, 6] == null)
                {
                    tablero[7, 6] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[7, 6]}");
                }
                break;

            case "g2":
                if (tablero[6, 6] == null)
                {
                    tablero[6, 6] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[6, 6]}");
                }
                break;

            case "g3":
                if (tablero[5, 6] == null)
                {
                    tablero[5, 6] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[5, 6]}");
                }
                break;

            case "g4":
                if (tablero[4, 6] == null)
                {
                    tablero[4, 6] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[4, 6]}");
                }
                break;

            case "g5":
                if (tablero[3, 6] == null)
                {
                    tablero[3, 6] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[3, 6]}");
                }
                break;

            case "g6":
                if (tablero[2, 6] == null)
                {
                    tablero[2, 6] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[2, 6]}");
                }
                break;

            case "g7":
                if (tablero[1, 6] == null)
                {
                    tablero[1, 6] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[1, 6]}");
                }
                break;

            case "g8":
                if (tablero[0, 6] == null)
                {
                    tablero[0, 6] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[0, 6]}");
                }
                break;

            case "h1":
                if (tablero[7, 7] == null)
                {
                    tablero[7, 7] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[7, 7]}");
                }
                break;

            case "h2":
                if (tablero[6, 7] == null)
                {
                    tablero[6, 7] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[6, 7]}");
                }
                break;

            case "h3":
                if (tablero[5, 7] == null)
                {
                    tablero[5, 7] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[5, 7]}");
                }
                break;

            case "h4":
                if (tablero[4, 7] == null)
                {
                    tablero[4, 7] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[4, 7]}");
                }
                break;

            case "h5":
                if (tablero[3, 7] == null)
                {
                    tablero[3, 7] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[3, 7]}");
                }
                break;

            case "h6":
                if (tablero[2, 7] == null)
                {
                    tablero[2, 7] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[2, 7]}");
                }
                break;

            case "h7":
                if (tablero[1, 7] == null)
                {
                    tablero[1, 7] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[1, 7]}");
                }
                break;

            case "h8":
                if (tablero[0, 7] == null)
                {
                    tablero[0, 7] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[0, 7]}");
                }
                break;

            default:
                Console.WriteLine("La posicion no existe dentro del tablero.");
                break;
        }

    }
    public void AgregarReina()
    {
        tipop = "R";

        Console.WriteLine("Que color?: / N (Negro) o B (Blanco)");
        color = Console.ReadLine() + "";

        string posiscion;
        Console.WriteLine("Donde desea posiscionar su pieza?: / Escribir en minusculas");
        posiscion = Console.ReadLine() + "";


        switch (posiscion)
        {
            case "a1":
                if (tablero[7, 0] == null)
                {
                    tablero[7, 0] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[7, 0]}");
                }
                break;

            case "a2":
                if (tablero[6, 0] == null)
                {
                    tablero[6, 0] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[6, 0]}");
                }
                break;

            case "a3":
                if (tablero[5, 0] == null)
                {
                    tablero[5, 0] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[5, 0]}");
                }
                break;

            case "a4":
                if (tablero[4, 0] == null)
                {
                    tablero[4, 0] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[4, 0]}");
                }
                break;

            case "a5":
                if (tablero[3, 0] == null)
                {
                    tablero[3, 0] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[3, 0]}");
                }
                break;

            case "a6":
                if (tablero[2, 0] == null)
                {
                    tablero[2, 0] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[2, 0]}");
                }
                break;

            case "a7":
                if (tablero[1, 0] == null)
                {
                    tablero[1, 0] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[1, 0]}");
                }
                break;

            case "a8":
                if (tablero[0, 0] == null)
                {
                    tablero[0, 0] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[0, 0]}");
                }
                break;

            case "b1":
                if (tablero[7, 1] == null)
                {
                    tablero[7, 1] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[7, 1]}");
                }
                break;

            case "b2":
                if (tablero[6, 1] == null)
                {
                    tablero[6, 1] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[6, 1]}");
                }
                break;

            case "b3":
                if (tablero[5, 1] == null)
                {
                    tablero[5, 1] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[5, 1]}");
                }
                break;

            case "b4":
                if (tablero[4, 1] == null)
                {
                    tablero[4, 1] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[4, 1]}");
                }
                break;

            case "b5":
                if (tablero[3, 1] == null)
                {
                    tablero[3, 1] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[3, 1]}");
                }
                break;

            case "b6":
                if (tablero[2, 1] == null)
                {
                    tablero[2, 1] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[2, 1]}");
                }
                break;

            case "b7":
                if (tablero[1, 1] == null)
                {
                    tablero[1, 1] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[1, 1]}");
                }
                break;

            case "b8":
                if (tablero[0, 1] == null)
                {
                    tablero[0, 1] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[0, 1]}");
                }
                break;

            case "c1":
                if (tablero[7, 2] == null)
                {
                    tablero[7, 2] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[7, 2]}");
                }
                break;

            case "c2":
                if (tablero[6, 2] == null)
                {
                    tablero[6, 2] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[6, 2]}");
                }
                break;

            case "c3":
                if (tablero[5, 2] == null)
                {
                    tablero[5, 2] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[5, 2]}");
                }
                break;

            case "c4":
                if (tablero[4, 2] == null)
                {
                    tablero[4, 2] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[4, 2]}");
                }
                break;

            case "c5":
                if (tablero[3, 2] == null)
                {
                    tablero[3, 2] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[3, 2]}");
                }
                break;

            case "c6":
                if (tablero[2, 2] == null)
                {
                    tablero[2, 2] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[2, 2]}");
                }
                break;

            case "c7":
                if (tablero[1, 2] == null)
                {
                    tablero[1, 2] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[1, 2]}");
                }
                break;

            case "c8":
                if (tablero[0, 2] == null)
                {
                    tablero[0, 2] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[0, 2]}");
                }
                break;

            case "d1":
                if (tablero[7, 3] == null)
                {
                    tablero[7, 3] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[7, 3]}");
                }
                break;

            case "d2":
                if (tablero[6, 3] == null)
                {
                    tablero[6, 3] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[6, 3]}");
                }
                break;

            case "d3":
                if (tablero[5, 3] == null)
                {
                    tablero[5, 3] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[5, 3]}");
                }
                break;

            case "d4":
                if (tablero[4, 3] == null)
                {
                    tablero[4, 3] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[4, 3]}");
                }
                break;

            case "d5":
                if (tablero[3, 3] == null)
                {
                    tablero[3, 3] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[3, 3]}");
                }
                break;

            case "d6":
                if (tablero[2, 3] == null)
                {
                    tablero[2, 3] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[2, 3]}");
                }
                break;

            case "d7":
                if (tablero[1, 3] == null)
                {
                    tablero[1, 3] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[1, 3]}");
                }
                break;

            case "d8":
                if (tablero[0, 3] == null)
                {
                    tablero[0, 3] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[0, 3]}");
                }
                break;

            case "e1":
                if (tablero[7, 4] == null)
                {
                    tablero[7, 4] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[7, 4]}");
                }
                break;

            case "e2":
                if (tablero[6, 4] == null)
                {
                    tablero[6, 4] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[6, 4]}");
                }
                break;

            case "e3":
                if (tablero[5, 4] == null)
                {
                    tablero[5, 4] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[5, 4]}");
                }
                break;

            case "e4":
                if (tablero[4, 4] == null)
                {
                    tablero[4, 4] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[4, 4]}");
                }
                break;

            case "e5":
                if (tablero[3, 4] == null)
                {
                    tablero[3, 4] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[3, 4]}");
                }
                break;

            case "e6":
                if (tablero[2, 4] == null)
                {
                    tablero[2, 4] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[2, 4]}");
                }
                break;

            case "e7":
                if (tablero[1, 4] == null)
                {
                    tablero[1, 4] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[1, 4]}");
                }
                break;

            case "e8":
                if (tablero[0, 4] == null)
                {
                    tablero[0, 4] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[0, 4]}");
                }
                break;

            case "f1":
                if (tablero[7, 5] == null)
                {
                    tablero[7, 5] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[7, 5]}");
                }
                break;

            case "f2":
                if (tablero[6, 5] == null)
                {
                    tablero[6, 5] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[6, 5]}");
                }
                break;

            case "f3":
                if (tablero[5, 5] == null)
                {
                    tablero[5, 5] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[5, 5]}");
                }
                break;

            case "f4":
                if (tablero[4, 5] == null)
                {
                    tablero[4, 5] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[4, 5]}");
                }
                break;

            case "f5":
                if (tablero[3, 5] == null)
                {
                    tablero[3, 5] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[3, 5]}");
                }
                break;

            case "f6":
                if (tablero[2, 5] == null)
                {
                    tablero[2, 5] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[2, 5]}");
                }
                break;

            case "f7":
                if (tablero[1, 5] == null)
                {
                    tablero[1, 5] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[1, 5]}");
                }
                break;

            case "f8":
                if (tablero[0, 5] == null)
                {
                    tablero[0, 5] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[0, 5]}");
                }
                break;

            case "g1":
                if (tablero[7, 6] == null)
                {
                    tablero[7, 6] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[7, 6]}");
                }
                break;

            case "g2":
                if (tablero[6, 6] == null)
                {
                    tablero[6, 6] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[6, 6]}");
                }
                break;

            case "g3":
                if (tablero[5, 6] == null)
                {
                    tablero[5, 6] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[5, 6]}");
                }
                break;

            case "g4":
                if (tablero[4, 6] == null)
                {
                    tablero[4, 6] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[4, 6]}");
                }
                break;

            case "g5":
                if (tablero[3, 6] == null)
                {
                    tablero[3, 6] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[3, 6]}");
                }
                break;

            case "g6":
                if (tablero[2, 6] == null)
                {
                    tablero[2, 6] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[2, 6]}");
                }
                break;

            case "g7":
                if (tablero[1, 6] == null)
                {
                    tablero[1, 6] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[1, 6]}");
                }
                break;

            case "g8":
                if (tablero[0, 6] == null)
                {
                    tablero[0, 6] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[0, 6]}");
                }
                break;

            case "h1":
                if (tablero[7, 7] == null)
                {
                    tablero[7, 7] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[7, 7]}");
                }
                break;

            case "h2":
                if (tablero[6, 7] == null)
                {
                    tablero[6, 7] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[6, 7]}");
                }
                break;

            case "h3":
                if (tablero[5, 7] == null)
                {
                    tablero[5, 7] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[5, 7]}");
                }
                break;

            case "h4":
                if (tablero[4, 7] == null)
                {
                    tablero[4, 7] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[4, 7]}");
                }
                break;

            case "h5":
                if (tablero[3, 7] == null)
                {
                    tablero[3, 7] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[3, 7]}");
                }
                break;

            case "h6":
                if (tablero[2, 7] == null)
                {
                    tablero[2, 7] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[2, 7]}");
                }
                break;

            case "h7":
                if (tablero[1, 7] == null)
                {
                    tablero[1, 7] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[1, 7]}");
                }
                break;

            case "h8":
                if (tablero[0, 7] == null)
                {
                    tablero[0, 7] = tipop + " " + color + "\t";
                    Console.WriteLine("La pieza se agrego exitosamente");
                }
                else
                {
                    Console.WriteLine($"Esa posicion ya esta siendo utilizada por {tablero[0, 7]}");
                }
                break;

            default:
                Console.WriteLine("La posicion no existe dentro del tablero.");
                break;
        }

    }

    public void ImprimirMatriz()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (tablero[i, j] == null)
                {
                    tablero[i, j] = "|_|" + "\t";
                }
                Console.Write(tablero[i, j]);
            }
            Console.WriteLine(""); 
            Console.WriteLine("");

        }
    }

    public void movimientos()
    {
        Tablero tablas = new Tablero();
        tablas.MoverReinaH(tablero);
        tablas.MoverReinaV(tablero);
        tablas.MoverReinaDD(tablero);
        tablas.MoverReinaDI(tablero);
        tablas.MoverReinaDDA(tablero);
        tablas.MoverReinaDIA(tablero);
    }

}