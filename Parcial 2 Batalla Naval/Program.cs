int[,] tablero = new int[5, 5];
Random random = new Random();

void barcos()
{
    int barkitos = 0;
    while (barkitos < 3)
    {
        int f = random.Next(5);
        int c = random.Next(5);
        if (tablero[f, c] == 0)
        {
            tablero[f, c] = 1;
            barkitos++;
        }
    }
}

 bool Barcos_en_Tablero()
{
    for (int f = 0; f < 5; f++)
    {
        for (int c = 0; c < 5; c++)
        {
            if (tablero[f, c] == 1)
            {
                return true;
            }
        }
    }
    return false;
}
void imprimir_tablero()
{
    Console.WriteLine("  1 2 3 4 5");
        for (int f = 0; f < 5; f++)
        {
            Console.Write(f + 1 + " ");
            for(int c = 0; c < 5; c++)
            {
                if(tablero[f, c] == 0)
                {
                    Console.Write("- "); 
                }
                else if (tablero[f, c] == 1)
                {
                    Console.Write("- ");
                }
                else if (tablero[f, c] == 2)
                {
                    Console.Write("X ");
                }
                else
                {
                    Console.Write("0 ");
                }
            
            }
        Console.WriteLine();
        }
        
}

void Game()
{
    barcos();

        while(Barcos_en_Tablero())
        {
            imprimir_tablero();

            int f, c;
            Console.WriteLine("Ingrese la fila (1-5): ");
            f = int.Parse(Console.ReadLine()) -1;
            Console.WriteLine("Ingrese la columna (1-5): ");
            c = int.Parse(Console.ReadLine()) -1;
            
                if(tablero[f, c] == 1)
                {
                    tablero[f, c] = 2;
                    Console.Beep();
                    Console.Clear();
                    Console.WriteLine("¡Has golpeado un barco!");
                    Console.Beep();
                }
                
                else
                {
                tablero[f, c] = -1;
                Console.Clear();
                Console.WriteLine("Has fallado.");
                }
                    
        }
    Console.WriteLine("¡Has hundido todos los barcos!");
    imprimir_tablero();
}
Game();