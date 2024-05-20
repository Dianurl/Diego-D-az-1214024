using System.ComponentModel;
using System.Globalization;

namespace Proyecto_PC_2;

public class Tablero
{
    public string Imprimir = " ";
    public string ImprimirV = " ";
    public string [,] Ajedrez = new string[8,8];
    int Golum;
    int fila;
    string Color = " ";

    public string LlamarTablero()
    {
        string columna = "\t";
        string[] letras = new string[8] {"  a", "b", "c", "d", "e", "f", "g", "h"};
        for(int i =1; i <= letras.Length; i++)
        {
            string unir = string.Join("    ", letras);
            columna += unir + "\t";
            columna = unir;
        }
        Console.WriteLine(columna);

        string fila = "\t";
        for (int j = 8; j >= 1; j--)
        {
            fila = j + "\t";
            
            Console.WriteLine(fila);
        }
        return "";
    }

    public void MoverReinaH(string [,] tablero)
    {
        for (int x = 0; x < tablero.GetLength(0); x++)
        {
            for (int y = 0; y < tablero.GetLength(1) ; y++)
            {
                Ajedrez[x,y] = tablero[x,y];
                if(Ajedrez[x,y] == ("R" + " " + "B" + "\t") || Ajedrez[x,y] == ("R" + " " + "N" + "\t"))
                {
                    fila=x;
                    Golum = y;
                }if(Ajedrez[x,y] == ("R" + " " + "B" + "\t"))
                {
                    Color="B";
                }
                if(Ajedrez[x,y] == ("R" + " " + "N" + "\t"))
                {
                    Color = "N";
                }
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Posibles movimientos a la derecha: ");
        switch(fila)
            {
                case 0: 
                    ImprimirV = "8";
                break;

                case 1: 
                    ImprimirV = "7";
                break;

                case 2: 
                    ImprimirV = "6";
                break;

                case 3: 
                    ImprimirV = "5";
                break;

                case 4: 
                    ImprimirV = "4";
                break;

                case 5: 
                    ImprimirV = "3";
                break;

                case 6: 
                    ImprimirV = "2";
                break;

                case 7: 
                    ImprimirV = "1";
                break;
            }
            
        for(int i = Golum + 1; i < tablero.GetLength(0); i++)
        {
            switch(i)
            {
                case 0:
                    Imprimir = "a";
                break;
                
                case 1:
                    Imprimir = "b";
                break;
                
                case 2:
                    Imprimir = "c";
                break;
                
                case 3:
                    Imprimir = "d";
                break;
                
                case 4:
                    Imprimir = "e";
                break;
                
                case 5:
                    Imprimir = "f";
                break;
                
                case 6:
                    Imprimir = "g";
                break;
                
                case 7:
                    Imprimir = "h";
                break;
            }
            

            if(Ajedrez[fila,i] == null)
            {
                Console.WriteLine($"La posición está vacía en {Imprimir}{ImprimirV}");
            }

            if(Color == "B")
            {
            if(Ajedrez[fila,i] != null && Ajedrez[fila,i]  == ("T" + " " + "B" + "\t") || Ajedrez[fila,i]  == ("A" + " " + "B" + "\t") || Ajedrez[fila,i]  == ("C" + " " + "B" + "\t") || Ajedrez[fila,i]  == ("P" + " " + "B" + "\t") || Ajedrez[fila,i]  == ("Ry" + " " + "B" + "\t"))
            {
                Console.WriteLine($"Se interrumpe por la pieza {Ajedrez[fila,i]}");
            }
            if(Ajedrez[fila,i] != null && Ajedrez[fila,i]  == ("T" + " " + "N" + "\t") || Ajedrez[fila,i]  == ("A" + " " + "N" + "\t") || Ajedrez[fila,i]  == ("C" + " " + "N" + "\t") || Ajedrez[fila,i]  == ("P" + " " + "N" + "\t") || Ajedrez[fila,i]  == ("Ry" + " " + "N" + "\t"))
            {
                Console.WriteLine($"La reina se puede comer la pieza {Ajedrez[fila,i]}");
            }
            if(Ajedrez[fila,i] != null)
            {
                break;
            }
            }

            if(Color == "N")
            {
            if(Ajedrez[fila,i] != null && Ajedrez[fila,i]  == ("T" + " " + "N" + "\t") || Ajedrez[fila,i]  == ("A" + " " + "N" + "\t") || Ajedrez[fila,i]  == ("C" + " " + "N" + "\t") || Ajedrez[fila,i]  == ("P" + " " + "N" + "\t") || Ajedrez[fila,i]  == ("Ry" + " " + "N" + "\t"))
            {
                Console.WriteLine($"Se interrumpe por la pieza {Ajedrez[fila,i]}");
            }
            if(Ajedrez[fila,i] != null && Ajedrez[fila,i]  == ("T" + " " + "B" + "\t") || Ajedrez[fila,i]  == ("A" + " " + "B" + "\t") || Ajedrez[fila,i]  == ("C" + " " + "B" + "\t") || Ajedrez[fila,i]  == ("P" + " " + "B" + "\t") || Ajedrez[fila,i]  == ("Ry" + " " + "B" + "\t"))
            {
                Console.WriteLine($"La reina se puede comer la pieza {Ajedrez[fila,i]}");
            }
            if(Ajedrez[fila,i] != null)
            {
                break;
            }
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Posibles movimientos a la izquierda: ");
        for(int i = Golum - 1; i > -1; i--)
        {
            switch(i)
            {
                case 0:
                    Imprimir = "a";
                break;
                
                case 1:
                    Imprimir = "b";
                break;
                
                case 2:
                    Imprimir = "c";
                break;
                
                case 3:
                    Imprimir = "d";
                break;
                
                case 4:
                    Imprimir = "e";
                break;
                
                case 5:
                    Imprimir = "f";
                break;
                
                case 6:
                    Imprimir = "g";
                break;
                
                case 7:
                    Imprimir = "h";
                break;
            }
            

            if(Ajedrez[fila,i]==null)
            {
                Console.WriteLine($"La posición está vacía en {Imprimir}{ImprimirV}");
            }

            if(Color == "B")
            {
            if(Ajedrez[fila,i] != null && Ajedrez[fila,i]  == ("T" + " " + "B" + "\t") || Ajedrez[fila,i]  == ("A" + " " + "B" + "\t") || Ajedrez[fila,i]  == ("C" + " " + "B" + "\t") || Ajedrez[fila,i]  == ("P" + " " + "B" + "\t") || Ajedrez[fila,i]  == ("Ry" + " " + "B" + "\t"))
            {
                Console.WriteLine($"Se interrumpe por la pieza {Ajedrez[fila,i]}");
            }
            if(Ajedrez[fila,i] != null && Ajedrez[fila,i]  == ("T" + " " + "N" + "\t") || Ajedrez[fila,i]  == ("A" + " " + "N" + "\t") || Ajedrez[fila,i]  == ("C" + " " + "N" + "\t") || Ajedrez[fila,i]  == ("P" + " " + "N" + "\t") || Ajedrez[fila,i]  == ("Ry" + " " + "N" + "\t"))
            {
                Console.WriteLine($"La reina se puede comer la pieza {Ajedrez[fila,i]}");
            }
            if(Ajedrez[fila,i] != null)
            {
                break;
            }
            }

            if(Color == "N")
            {
            if(Ajedrez[fila,i] != null && Ajedrez[fila,i]  == ("T" + " " + "N" + "\t") || Ajedrez[fila,i]  == ("A" + " " + "N" + "\t") || Ajedrez[fila,i]  == ("C" + " " + "N" + "\t") || Ajedrez[fila,i]  == ("P" + " " + "N" + "\t") || Ajedrez[fila,i]  == ("Ry" + " " + "N" + "\t"))
            {
                Console.WriteLine($"Se interrumpe por la pieza {Ajedrez[fila,i]}");
            }
            if(Ajedrez[fila,i] != null && Ajedrez[fila,i]  == ("T" + " " + "B" + "\t") || Ajedrez[fila,i]  == ("A" + " " + "B" + "\t") || Ajedrez[fila,i]  == ("C" + " " + "B" + "\t") || Ajedrez[fila,i]  == ("P" + " " + "B" + "\t") || Ajedrez[fila,i]  == ("Ry" + " " + "B" + "\t"))
            {
                Console.WriteLine($"La reina se puede comer la pieza {Ajedrez[fila,i]}");
            }
            if(Ajedrez[fila,i] != null)
            {
                break;
            }
            }
        } 
    }

    public void MoverReinaV(string [,] tablero)
    {
        for (int x = 0; x < tablero.GetLength(0); x++)
        {
            for (int y = 0; y < tablero.GetLength(1) ; y++)
            {
                Ajedrez[x,y] = tablero[x,y];
                if(Ajedrez[x,y] == ("R" + " " + "B" + "\t") || Ajedrez[x,y] == ("R" + " " + "N" + "\t"))
                {
                    fila=x;
                    Golum = y;
                }if(Ajedrez[x,y] == ("R" + " " + "B" + "\t"))
                {
                    Color="B";
                }
                if(Ajedrez[x,y] == ("R" + " " + "N" + "\t"))
                {
                    Color = "N";
                }
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Posibles movimientos hacia abajo: ");
        for(int i = fila + 1; i < tablero.GetLength(1); i++)
        {
            switch(Golum)
            {
                case 0:
                    ImprimirV = "a";
                break;
                
                case 1:
                    ImprimirV = "b";
                break;
                
                case 2:
                    ImprimirV = "c";
                break;
                
                case 3:
                    ImprimirV = "d";
                break;
                
                case 4:
                    ImprimirV = "e";
                break;
                
                case 5:
                    ImprimirV = "f";
                break;
                
                case 6:
                    ImprimirV = "g";
                break;
                
                case 7:
                    ImprimirV = "h";
                break;
            }
            
            switch(i)
            {
                case 0: 
                    Imprimir = "8";
                break;

                case 1: 
                    Imprimir = "7";
                break;

                case 2: 
                    Imprimir = "6";
                break;

                case 3: 
                    Imprimir = "5";
                break;

                case 4: 
                    Imprimir = "4";
                break;

                case 5: 
                    Imprimir = "3";
                break;

                case 6: 
                    Imprimir = "2";
                break;

                case 7: 
                    Imprimir = "1";
                break;
            }

            if(Ajedrez[i,Golum] == null)
            {
                Console.WriteLine($"La posición está vacía en {ImprimirV}{Imprimir}");
            }

            if(Color == "B")
            {
            if(Ajedrez[i,Golum] != null && Ajedrez[i,Golum]  == ("T" + " " + "B" + "\t") || Ajedrez[i,Golum]  == ("A" + " " + "B" + "\t") || Ajedrez[i,Golum]  == ("C" + " " + "B" + "\t") || Ajedrez[i,Golum]  == ("P" + " " + "B" + "\t") || Ajedrez[i,Golum]  == ("Ry" + " " + "B" + "\t"))
            {
                Console.WriteLine($"Se interrumpe por la pieza {Ajedrez[i,Golum]}");
            }
            if(Ajedrez[i,Golum] != null && Ajedrez[i,Golum]  == ("T" + " " + "N" + "\t") || Ajedrez[i,Golum]  == ("A" + " " + "N" + "\t") || Ajedrez[i,Golum]  == ("C" + " " + "N" + "\t") || Ajedrez[i,Golum]  == ("P" + " " + "N" + "\t") || Ajedrez[i,Golum]  == ("Ry" + " " + "N" + "\t"))
            {
                Console.WriteLine($"La reina se puede comer la pieza {Ajedrez[i,Golum]}");
            }
            if(Ajedrez[i,Golum] != null)
            {
                break;
            }
            }

            if(Color == "N")
            {
            if(Ajedrez[i,Golum] != null && Ajedrez[i,Golum]  == ("T" + " " + "N" + "\t") || Ajedrez[i,Golum]  == ("A" + " " + "N" + "\t") || Ajedrez[i,Golum]  == ("C" + " " + "N" + "\t") || Ajedrez[i,Golum]  == ("P" + " " + "N" + "\t") || Ajedrez[i,Golum]  == ("Ry" + " " + "N" + "\t"))
            {
                Console.WriteLine($"Se interrumpe por la pieza {Ajedrez[i,Golum]}");
            }
            if(Ajedrez[i,Golum] != null && Ajedrez[i,Golum]  == ("T" + " " + "B" + "\t") || Ajedrez[i,Golum]  == ("A" + " " + "B" + "\t") || Ajedrez[i,Golum]  == ("C" + " " + "B" + "\t") || Ajedrez[i,Golum]  == ("P" + " " + "B" + "\t") || Ajedrez[i,Golum]  == ("Ry" + " " + "B" + "\t"))
            {
                Console.WriteLine($"La reina se puede comer la pieza {Ajedrez[i,Golum]}");
            }
            if(Ajedrez[i,Golum] != null)
            {
                break;
            }
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Posibles movimientos hacia arriba: ");
        for(int i = fila - 1; i > -1; i--)
        {
            switch(Golum)
            {
                case 0:
                    ImprimirV = "a";
                break;
                
                case 1:
                    ImprimirV = "b";
                break;
                
                case 2:
                    ImprimirV = "c";
                break;
                
                case 3:
                    ImprimirV = "d";
                break;
                
                case 4:
                    ImprimirV = "e";
                break;
                
                case 5:
                    ImprimirV = "f";
                break;
                
                case 6:
                    ImprimirV = "g";
                break;
                
                case 7:
                    ImprimirV = "h";
                break;
            }
            
            switch(i)
            {
                case 0: 
                    Imprimir = "8";
                break;

                case 1: 
                    Imprimir = "7";
                break;

                case 2: 
                    Imprimir = "6";
                break;

                case 3: 
                    Imprimir = "5";
                break;

                case 4: 
                    Imprimir = "4";
                break;

                case 5: 
                    Imprimir = "3";
                break;

                case 6: 
                    Imprimir = "2";
                break;

                case 7: 
                    Imprimir = "1";
                break;
            }

            if(Ajedrez[i, Golum] == null)
            {
                Console.WriteLine($"La posición está vacía en {ImprimirV}{Imprimir}");
            }

            if(Color == "B")
            {
            if(Ajedrez[i, Golum] != null && Ajedrez[i, Golum]  == ("T" + " " + "B" + "\t") || Ajedrez[i, Golum]  == ("A" + " " + "B" + "\t") || Ajedrez[i, Golum]  == ("C" + " " + "B" + "\t") || Ajedrez[i, Golum]  == ("P" + " " + "B" + "\t") || Ajedrez[i, Golum]  == ("Ry" + " " + "B" + "\t"))
            {
                Console.WriteLine($"Se interrumpe por la pieza {Ajedrez[i, Golum]}");
            }
            if(Ajedrez[i, Golum] != null && Ajedrez[i, Golum]  == ("T" + " " + "N" + "\t") || Ajedrez[i, Golum]  == ("A" + " " + "N" + "\t") || Ajedrez[i, Golum]  == ("C" + " " + "N" + "\t") || Ajedrez[i, Golum]  == ("P" + " " + "N" + "\t") || Ajedrez[i, Golum]  == ("Ry" + " " + "N" + "\t"))
            {
                Console.WriteLine($"La reina se puede comer la pieza {Ajedrez[i, Golum]}");
            }
            if(Ajedrez[i, Golum] != null)
            {
                break;
            }
            }

            if(Color == "N")
            {
            if(Ajedrez[i, Golum] != null && Ajedrez[i, Golum]  == ("T" + " " + "N" + "\t") || Ajedrez[i, Golum]  == ("A" + " " + "N" + "\t") || Ajedrez[i, Golum]  == ("C" + " " + "N" + "\t") || Ajedrez[i, Golum]  == ("P" + " " + "N" + "\t") || Ajedrez[i, Golum]  == ("Ry" + " " + "N" + "\t"))
            {
                Console.WriteLine($"Se interrumpe por la pieza {Ajedrez[i, Golum]}");
            }
            if(Ajedrez[i, Golum] != null && Ajedrez[i, Golum]  == ("T" + " " + "B" + "\t") || Ajedrez[i, Golum]  == ("A" + " " + "B" + "\t") || Ajedrez[i, Golum]  == ("C" + " " + "B" + "\t") || Ajedrez[i, Golum]  == ("P" + " " + "B" + "\t") || Ajedrez[i, Golum]  == ("Ry" + " " + "B" + "\t"))
            {
                Console.WriteLine($"La reina se puede comer la pieza {Ajedrez[i, Golum]}");
            }
            if(Ajedrez[i, Golum] != null)
            {
                break;
            }
            }
        } 
    }

    public void MoverReinaDD(string[,] tablero)
    {
        for (int x = 0; x < tablero.GetLength(0); x++)
        {
            for (int y = 0; y < tablero.GetLength(1) ; y++)
            {
                Ajedrez[x,y] = tablero[x,y];
                if(Ajedrez[x,y] == ("R" + " " + "B" + "\t") || Ajedrez[x,y] == ("R" + " " + "N" + "\t"))
                {
                    fila=x;
                    Golum = y;
                }if(Ajedrez[x,y] == ("R" + " " + "B" + "\t"))
                {
                    Color="B";
                }
                if(Ajedrez[x,y] == ("R" + " " + "N" + "\t"))
                {
                    Color = "N";
                }
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Posibles movimientos diagonales derecha: ");
        int i = fila;
        int j = Golum;
        do
        {
            i--;
            j++;
            switch(i)
            {
                case 0: 
                    ImprimirV = "8";
                break;

                case 1: 
                    ImprimirV = "7";
                break;

                case 2: 
                    ImprimirV = "6";
                break;

                case 3: 
                    ImprimirV = "5";
                break;

                case 4: 
                    ImprimirV = "4";
                break;

                case 5: 
                    ImprimirV = "3";
                break;

                case 6: 
                    ImprimirV = "2";
                break;

                case 7: 
                    ImprimirV = "1";
                break;
            }
            switch(j)
            {
                case 0: 
                    Imprimir = "a";
                break;

                case 1: 
                    Imprimir = "b";
                break;

                case 2: 
                    Imprimir = "c";
                break;

                case 3: 
                    Imprimir = "d";
                break;

                case 4: 
                    Imprimir = "e";
                break;

                case 5: 
                    Imprimir = "f";
                break;

                case 6: 
                    Imprimir = "g";
                break;

                case 7: 
                    Imprimir = "h";
                break;
            }

            if(Ajedrez[i, j] == null)
            {
                Console.WriteLine($"La posición está vacía en {Imprimir}{ImprimirV}");
            }

            if(Color == "B")
            {
            if(Ajedrez[i, j] != null && Ajedrez[i, j]  == ("T" + " " + "B" + "\t") || Ajedrez[i, j]  == ("A" + " " + "B" + "\t") || Ajedrez[i, j]  == ("C" + " " + "B" + "\t") || Ajedrez[i, j]  == ("P" + " " + "B" + "\t") || Ajedrez[i, j]  == ("Ry" + " " + "B" + "\t"))
            {
                Console.WriteLine($"Se interrumpe por la pieza {Ajedrez[i, j]}");
            }
            if(Ajedrez[i, j] != null && Ajedrez[i, j]  == ("T" + " " + "N" + "\t") || Ajedrez[i, j]  == ("A" + " " + "N" + "\t") || Ajedrez[i, j]  == ("C" + " " + "N" + "\t") || Ajedrez[i, j]  == ("P" + " " + "N" + "\t") || Ajedrez[i, j]  == ("Ry" + " " + "N" + "\t"))
            {
                Console.WriteLine($"La reina se puede comer la pieza {Ajedrez[i, j]}");
            }
            if(Ajedrez[i, j] != null)
            {
                break;
            }
            }

            if(Color == "N")
            {
            if(Ajedrez[i, j] != null && Ajedrez[i, j]  == ("T" + " " + "N" + "\t") || Ajedrez[i, j]  == ("A" + " " + "N" + "\t") || Ajedrez[i, j]  == ("C" + " " + "N" + "\t") || Ajedrez[i, j]  == ("P" + " " + "N" + "\t") || Ajedrez[i, j]  == ("Ry" + " " + "N" + "\t"))
            {
                Console.WriteLine($"Se interrumpe por la pieza {Ajedrez[i, j]}");
            }
            if(Ajedrez[i, j] != null && Ajedrez[i, j]  == ("T" + " " + "B" + "\t") || Ajedrez[i, j]  == ("A" + " " + "B" + "\t") || Ajedrez[i, j]  == ("C" + " " + "B" + "\t") || Ajedrez[i, j]  == ("P" + " " + "B" + "\t") || Ajedrez[i, j]  == ("Ry" + " " + "B" + "\t"))
            {
                Console.WriteLine($"La reina se puede comer la pieza {Ajedrez[i, j]}");
            }
            if(Ajedrez[i, j] != null)
            {
                break;
            }
            }
        }while(j < 7 && i > 0);
    }


    public void MoverReinaDI(string[,] tablero)
    {
        for (int x = 0; x < tablero.GetLength(0); x++)
        {
            for (int y = 0; y < tablero.GetLength(1) ; y++)
            {
                Ajedrez[x,y] = tablero[x,y];
                if(Ajedrez[x,y] == ("R" + " " + "B" + "\t") || Ajedrez[x,y] == ("R" + " " + "N" + "\t"))
                {
                    fila=x;
                    Golum = y;
                }if(Ajedrez[x,y] == ("R" + " " + "B" + "\t"))
                {
                    Color="B";
                }
                if(Ajedrez[x,y] == ("R" + " " + "N" + "\t"))
                {
                    Color = "N";
                }
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Posibles movimientos diagonales izquierda: ");
        int i = fila;
        int j = Golum;
        do
        {
            i--;
            j--;
            switch(i)
            {
                case 0: 
                    ImprimirV = "8";
                break;

                case 1: 
                    ImprimirV = "7";
                break;

                case 2: 
                    ImprimirV = "6";
                break;

                case 3: 
                    ImprimirV = "5";
                break;

                case 4: 
                    ImprimirV = "4";
                break;

                case 5: 
                    ImprimirV = "3";
                break;

                case 6: 
                    ImprimirV = "2";
                break;

                case 7: 
                    ImprimirV = "1";
                break;
            }
            switch(j)
            {
                case 0: 
                    Imprimir = "a";
                break;

                case 1: 
                    Imprimir = "b";
                break;

                case 2: 
                    Imprimir = "c";
                break;

                case 3: 
                    Imprimir = "d";
                break;

                case 4: 
                    Imprimir = "e";
                break;

                case 5: 
                    Imprimir = "f";
                break;

                case 6: 
                    Imprimir = "g";
                break;

                case 7: 
                    Imprimir = "h";
                break;
            }

            if(Ajedrez[i, j] == null)
            {
                Console.WriteLine($"La posición está vacía en {Imprimir}{ImprimirV}");
            }

            if(Color == "B")
            {
            if(Ajedrez[i, j] != null && Ajedrez[i, j]  == ("T" + " " + "B" + "\t") || Ajedrez[i, j]  == ("A" + " " + "B" + "\t") || Ajedrez[i, j]  == ("C" + " " + "B" + "\t") || Ajedrez[i, j]  == ("P" + " " + "B" + "\t") || Ajedrez[i, j]  == ("Ry" + " " + "B" + "\t"))
            {
                Console.WriteLine($"Se interrumpe por la pieza {Ajedrez[i, j]}");
            }
            if(Ajedrez[i, j] != null && Ajedrez[i, j]  == ("T" + " " + "N" + "\t") || Ajedrez[i, j]  == ("A" + " " + "N" + "\t") || Ajedrez[i, j]  == ("C" + " " + "N" + "\t") || Ajedrez[i, j]  == ("P" + " " + "N" + "\t") || Ajedrez[i, j]  == ("Ry" + " " + "N" + "\t"))
            {
                Console.WriteLine($"La reina se puede comer la pieza {Ajedrez[i, j]}");
            }
            if(Ajedrez[i, j] != null)
            {
                break;
            }
            }

            if(Color == "N")
            {
            if(Ajedrez[i, j] != null && Ajedrez[i, j]  == ("T" + " " + "N" + "\t") || Ajedrez[i, j]  == ("A" + " " + "N" + "\t") || Ajedrez[i, j]  == ("C" + " " + "N" + "\t") || Ajedrez[i, j]  == ("P" + " " + "N" + "\t") || Ajedrez[i, j]  == ("Ry" + " " + "N" + "\t"))
            {
                Console.WriteLine($"Se interrumpe por la pieza {Ajedrez[i, j]}");
            }
            if(Ajedrez[i, j] != null && Ajedrez[i, j]  == ("T" + " " + "B" + "\t") || Ajedrez[i, j]  == ("A" + " " + "B" + "\t") || Ajedrez[i, j]  == ("C" + " " + "B" + "\t") || Ajedrez[i, j]  == ("P" + " " + "B" + "\t") || Ajedrez[i, j]  == ("Ry" + " " + "B" + "\t"))
            {
                Console.WriteLine($"La reina se puede comer la pieza {Ajedrez[i, j]}");
            }
            if(Ajedrez[i, j] != null)
            {
                break;
            }
            }
        }while(j > 0 && i < 7);
    }

    public void MoverReinaDDA(string[,] tablero)
    {
        for (int x = 0; x < tablero.GetLength(0); x++)
        {
            for (int y = 0; y < tablero.GetLength(1) ; y++)
            {
                Ajedrez[x,y] = tablero[x,y];
                if(Ajedrez[x,y] == ("R" + " " + "B" + "\t") || Ajedrez[x,y] == ("R" + " " + "N" + "\t"))
                {
                    fila=x;
                    Golum = y;
                }if(Ajedrez[x,y] == ("R" + " " + "B" + "\t"))
                {
                    Color="B";
                }
                if(Ajedrez[x,y] == ("R" + " " + "N" + "\t"))
                {
                    Color = "N";
                }
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Posibles movimientos diagonales derecha abajo: ");
        int i = fila;
        int j = Golum;
        do
        {
            i++;
            j++;
            switch(i)
            {
                case 0: 
                    ImprimirV = "8";
                break;

                case 1: 
                    ImprimirV = "7";
                break;

                case 2: 
                    ImprimirV = "6";
                break;

                case 3: 
                    ImprimirV = "5";
                break;

                case 4: 
                    ImprimirV = "4";
                break;

                case 5: 
                    ImprimirV = "3";
                break;

                case 6: 
                    ImprimirV = "2";
                break;

                case 7: 
                    ImprimirV = "1";
                break;
            }
            switch(j)
            {
                case 0: 
                    Imprimir = "a";
                break;

                case 1: 
                    Imprimir = "b";
                break;

                case 2: 
                    Imprimir = "c";
                break;

                case 3: 
                    Imprimir = "d";
                break;

                case 4: 
                    Imprimir = "e";
                break;

                case 5: 
                    Imprimir = "f";
                break;

                case 6: 
                    Imprimir = "g";
                break;

                case 7: 
                    Imprimir = "h";
                break;
            }

            if(Ajedrez[i, j] == null)
            {
                Console.WriteLine($"La posición está vacía en {Imprimir}{ImprimirV}");
            }

            if(Color == "B")
            {
            if(Ajedrez[i, j] != null && Ajedrez[i, j]  == ("T" + " " + "B" + "\t") || Ajedrez[i, j]  == ("A" + " " + "B" + "\t") || Ajedrez[i, j]  == ("C" + " " + "B" + "\t") || Ajedrez[i, j]  == ("P" + " " + "B" + "\t") || Ajedrez[i, j]  == ("Ry" + " " + "B" + "\t"))
            {
                Console.WriteLine($"Se interrumpe por la pieza {Ajedrez[i, j]}");
            }
            if(Ajedrez[i, j] != null && Ajedrez[i, j]  == ("T" + " " + "N" + "\t") || Ajedrez[i, j]  == ("A" + " " + "N" + "\t") || Ajedrez[i, j]  == ("C" + " " + "N" + "\t") || Ajedrez[i, j]  == ("P" + " " + "N" + "\t") || Ajedrez[i, j]  == ("Ry" + " " + "N" + "\t"))
            {
                Console.WriteLine($"La reina se puede comer la pieza {Ajedrez[i, j]}");
            }
            if(Ajedrez[i, j] != null)
            {
                break;
            }
            }

            if(Color == "N")
            {
            if(Ajedrez[i, j] != null && Ajedrez[i, j]  == ("T" + " " + "N" + "\t") || Ajedrez[i, j]  == ("A" + " " + "N" + "\t") || Ajedrez[i, j]  == ("C" + " " + "N" + "\t") || Ajedrez[i, j]  == ("P" + " " + "N" + "\t") || Ajedrez[i, j]  == ("Ry" + " " + "N" + "\t"))
            {
                Console.WriteLine($"Se interrumpe por la pieza {Ajedrez[i, j]}");
            }
            if(Ajedrez[i, j] != null && Ajedrez[i, j]  == ("T" + " " + "B" + "\t") || Ajedrez[i, j]  == ("A" + " " + "B" + "\t") || Ajedrez[i, j]  == ("C" + " " + "B" + "\t") || Ajedrez[i, j]  == ("P" + " " + "B" + "\t") || Ajedrez[i, j]  == ("Ry" + " " + "B" + "\t"))
            {
                Console.WriteLine($"La reina se puede comer la pieza {Ajedrez[i, j]}");
            }
            if(Ajedrez[i, j] != null)
            {
                break;
            }
            }
        }while(j > 0 && i < 7);
    }

    public void MoverReinaDIA(string[,] tablero)
    {
        for (int x = 0; x < tablero.GetLength(0); x++)
        {
            for (int y = 0; y < tablero.GetLength(1) ; y++)
            {
                Ajedrez[x,y] = tablero[x,y];
                if(Ajedrez[x,y] == ("R" + " " + "B" + "\t") || Ajedrez[x,y] == ("R" + " " + "N" + "\t"))
                {
                    fila=x;
                    Golum = y;
                }if(Ajedrez[x,y] == ("R" + " " + "B" + "\t"))
                {
                    Color="B";
                }
                if(Ajedrez[x,y] == ("R" + " " + "N" + "\t"))
                {
                    Color = "N";
                }
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Posibles movimientos diagonales izquierda abajo: ");
        int i = fila;
        int j = Golum;
        do
        {
            i++;
            j--;
            switch(i)
            {
                case 0: 
                    ImprimirV = "8";
                break;

                case 1: 
                    ImprimirV = "7";
                break;

                case 2: 
                    ImprimirV = "6";
                break;

                case 3: 
                    ImprimirV = "5";
                break;

                case 4: 
                    ImprimirV = "4";
                break;

                case 5: 
                    ImprimirV = "3";
                break;

                case 6: 
                    ImprimirV = "2";
                break;

                case 7: 
                    ImprimirV = "1";
                break;
            }
            switch(j)
            {
                case 0: 
                    Imprimir = "a";
                break;

                case 1: 
                    Imprimir = "b";
                break;

                case 2: 
                    Imprimir = "c";
                break;

                case 3: 
                    Imprimir = "d";
                break;

                case 4: 
                    Imprimir = "e";
                break;

                case 5: 
                    Imprimir = "f";
                break;

                case 6: 
                    Imprimir = "g";
                break;

                case 7: 
                    Imprimir = "h";
                break;
            }

            if(Ajedrez[i, j] == null)
            {
                Console.WriteLine($"La posición está vacía en {Imprimir}{ImprimirV}");
            }

            if(Color == "B")
            {
            if(Ajedrez[i, j] != null && Ajedrez[i, j]  == ("T" + " " + "B" + "\t") || Ajedrez[i, j]  == ("A" + " " + "B" + "\t") || Ajedrez[i, j]  == ("C" + " " + "B" + "\t") || Ajedrez[i, j]  == ("P" + " " + "B" + "\t") || Ajedrez[i, j]  == ("Ry" + " " + "B" + "\t"))
            {
                Console.WriteLine($"Se interrumpe por la pieza {Ajedrez[i, j]}");
            }
            if(Ajedrez[i, j] != null && Ajedrez[i, j]  == ("T" + " " + "N" + "\t") || Ajedrez[i, j]  == ("A" + " " + "N" + "\t") || Ajedrez[i, j]  == ("C" + " " + "N" + "\t") || Ajedrez[i, j]  == ("P" + " " + "N" + "\t") || Ajedrez[i, j]  == ("Ry" + " " + "N" + "\t"))
            {
                Console.WriteLine($"La reina se puede comer la pieza {Ajedrez[i, j]}");
            }
            if(Ajedrez[i, j] != null)
            {
                break;
            }
            }

            if(Color == "N")
            {
            if(Ajedrez[i, j] != null && Ajedrez[i, j]  == ("T" + " " + "N" + "\t") || Ajedrez[i, j]  == ("A" + " " + "N" + "\t") || Ajedrez[i, j]  == ("C" + " " + "N" + "\t") || Ajedrez[i, j]  == ("P" + " " + "N" + "\t") || Ajedrez[i, j]  == ("Ry" + " " + "N" + "\t"))
            {
                Console.WriteLine($"Se interrumpe por la pieza {Ajedrez[i, j]}");
            }
            if(Ajedrez[i, j] != null && Ajedrez[i, j]  == ("T" + " " + "B" + "\t") || Ajedrez[i, j]  == ("A" + " " + "B" + "\t") || Ajedrez[i, j]  == ("C" + " " + "B" + "\t") || Ajedrez[i, j]  == ("P" + " " + "B" + "\t") || Ajedrez[i, j]  == ("Ry" + " " + "B" + "\t"))
            {
                Console.WriteLine($"La reina se puede comer la pieza {Ajedrez[i, j]}");
            }
            if(Ajedrez[i, j] != null)
            {
                break;
            }
            }
        }while(j > 0 && i < 7 );
    }
}
