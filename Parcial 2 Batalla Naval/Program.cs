try
{
    int op;
    Console.WriteLine("                     BIENVENIDO A BATALLA NAVAL");
    Console.WriteLine("      Ingresa a las intrucciones si no entiendes de que va el juego");
    Console.WriteLine("  Y si ya lo conoces pues ingresa la dificultad en la que quieres jugar");
    Console.WriteLine("");
    Console.WriteLine("Selecciona el numero correspondiente a la dificultad\n");
    Console.WriteLine("1. Fácil (Tablero de 5x5 con tres barcos en el agua)");
    Console.WriteLine("2. Intermedio (Tablero de 10x10 con 15 barcos en el agua)");
    Console.WriteLine("3. Díficil (Tablero de 15x15 con 45 barcos en el agua)");
    Console.WriteLine("4. Instrucciones");

    op = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    if (op > 4)
    {
        Console.WriteLine("Debes de ingresar una de las opciones disponibles");
    }
    else
    {
        switch (op)
        {
            case 1: //CASO UNO DIFICULTAD FACIL 
                {
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
                            for (int c = 0; c < 5; c++)
                            {
                                if (tablero[f, c] == 0)
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
                        int contador = 0;
                        int barcosrestantes = 3;
                        Console.WriteLine("Has seleccionado el modo facil, !EMPIEZA A ATACAR!\n");
                        while (Barcos_en_Tablero())
                        {
                            imprimir_tablero();
                            try
                            {
                                int f, c;
                                Console.WriteLine("Ingrese la fila (1-5): ");
                                f = int.Parse(Console.ReadLine()) - 1;
                                Console.WriteLine("Ingrese la columna (1-5): ");
                                c = int.Parse(Console.ReadLine()) - 1;

                                if (tablero[f, c] == 1)
                                {
                                    tablero[f, c] = 2;
                                    Console.Beep();
                                    Console.Clear();
                                    Console.WriteLine("¡Has golpeado un barco!");
                                    Console.Beep();
                                    Console.WriteLine($"Quedan {barcosrestantes = barcosrestantes - 1} barcos en el tablero");
                                    contador++;
                                }

                                else
                                {
                                    tablero[f, c] = -1;
                                    Console.Clear();
                                    Console.WriteLine("Has fallado.");
                                    contador++;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Has ingresado una posicion que no existe en el tablero, inténtalo de nuevo (PRESIONA ENTER)");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }

                        Console.WriteLine("¡Has hundido todos los barcos!");
                        Console.WriteLine("Los intentos que has hecho son de: " + contador);
                        imprimir_tablero();
                    }
                    Game();
                    break;
                }

            case 2: //CASO 2 DIFICULTAD INTERMEDIA 
                {
                    int[,] tablero = new int[10, 10];
                    Random random = new Random();
                    void barcos()
                    {
                        int barkitos = 0;
                        while (barkitos < 15)
                        {
                            int f = random.Next(10);
                            int c = random.Next(10);
                            if (tablero[f, c] == 0)
                            {
                                tablero[f, c] = 1;
                                barkitos++;
                            }
                        }
                    }

                    bool Barcos_en_Tablero()
                    {
                        for (int f = 0; f < 10; f++)
                        {
                            for (int c = 0; c < 10; c++)
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
                        Console.WriteLine("   1 2 3 4 5 6 7 8 9 10");
                        for (int f = 0; f < 10; f++)
                        {
                            if(f<9)
                            {
                                Console.Write(f + 1 + "  ");
                            }
                            else
                            {
                                Console.Write(f + 1 + " ");
                            }
                            for (int c = 0; c < 10; c++)
                            {
                                if (tablero[f, c] == 0)
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
                        int contador = 0;
                        int barcosrestantes = 15;
                        Console.WriteLine("Has seleccionado el modo intermedio, !EMPIEZA A ATACAR!\n");
                        while (Barcos_en_Tablero())
                        {
                            imprimir_tablero();
                            try
                            {
                                int f, c;
                                Console.WriteLine("Ingrese la fila (1-10): ");
                                f = int.Parse(Console.ReadLine()) - 1;
                                Console.WriteLine("Ingrese la columna (1-10): ");
                                c = int.Parse(Console.ReadLine()) - 1;

                                if (tablero[f, c] == 1)
                                {
                                    tablero[f, c] = 2;
                                    Console.Beep();
                                    Console.Clear();
                                    Console.WriteLine("¡Has golpeado un barco!");
                                    Console.Beep();
                                    Console.WriteLine($"Quedan {barcosrestantes = barcosrestantes - 1} barcos en el tablero");
                                    contador++;
                                }

                                else
                                {
                                    tablero[f, c] = -1;
                                    Console.Clear();
                                    Console.WriteLine("Has fallado.");
                                    contador++;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Has ingresado una posicion que no existe en el tablero, inténtalo de nuevo (PRESIONA ENTER)");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }

                        Console.WriteLine("¡Has hundido todos los barcos!");
                        Console.WriteLine("Los intentos que has hecho son de: " + contador);
                        imprimir_tablero();
                    }
                    Game();
                }
                break;

            case 3: //CASO 3 DIFICULTAD DÍFICIL 
                {
                    int[,] tablero = new int[15, 15];
                    Random random = new Random();
                    void barcos()
                    {
                        int barkitos = 0;
                        while (barkitos < 45)
                        {
                            int f = random.Next(15);
                            int c = random.Next(15);
                            if (tablero[f, c] == 0)
                            {
                                tablero[f, c] = 1;
                                barkitos++;
                            }
                        }
                    }

                    bool Barcos_en_Tablero()
                    {
                        for (int f = 0; f < 15; f++)
                        {
                            for (int c = 0; c < 15; c++)
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
                        Console.WriteLine("   1  2  3  4  5  6  7  8  9  10 11 12 13 14 15");
                        for (int f = 0; f < 15; f++)
                        {
                            if (f < 9)
                            {
                                Console.Write(f + 1 + " ");
                            }
                            else
                            {
                                Console.Write(f + 1 + "");
                            }

                            for (int c = 0; c < 15; c++)
                            {
                                if (tablero[f, c] == 0)
                                {
                                    Console.Write(" - ");
                                }
                                else if (tablero[f, c] == 1)
                                {
                                    Console.Write(" - ");
                                }
                                else if (tablero[f, c] == 2)
                                {
                                    Console.Write(" X ");
                                }
                                else
                                {
                                    Console.Write(" 0 ");
                                }

                            }
                            Console.WriteLine();
                        }

                    }

                    void Game()
                    {
                        barcos();
                        int contador = 0;
                        int barcosrestantes = 45;
                        Console.WriteLine("Has seleccionado el modo díficil, !EMPIEZA A ATACAR!\n");
                        while (Barcos_en_Tablero())
                        {
                            imprimir_tablero();
                            try
                            {
                                int f, c;
                                Console.WriteLine("Ingrese la fila (1-15): ");
                                f = int.Parse(Console.ReadLine()) - 1;
                                Console.WriteLine("Ingrese la columna (1-15): ");
                                c = int.Parse(Console.ReadLine()) - 1;

                                if (tablero[f, c] == 1)
                                {
                                    tablero[f, c] = 2;
                                    Console.Beep();
                                    Console.Clear();
                                    Console.WriteLine("¡Has golpeado un barco!");
                                    Console.Beep();
                                    Console.WriteLine($"Quedan {barcosrestantes = barcosrestantes - 1} barcos en el tablero");
                                    contador++;
                                }

                                else
                                {
                                    tablero[f, c] = -1;
                                    Console.Clear();
                                    Console.WriteLine("Has fallado.");
                                    contador++;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Has ingresado una posicion que no existe en el tablero, inténtalo de nuevo (PRESIONA ENTER)");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }

                        Console.WriteLine("¡Has hundido todos los barcos!");
                        Console.WriteLine("Los intentos que has hecho son de: " + contador);
                        imprimir_tablero();
                    }
                    Game();
                }
                break;

            case 4:
                {
                    Console.WriteLine("INSTRUCCIONES\n");
                    Console.WriteLine("El juego se trata de que tienes un tablero con filas y columnas");
                    Console.WriteLine("y en cada posicion del tablero se colocan barcos aleatoriamente");
                    Console.WriteLine("los cuales debes de derribar disparando en la posicion que deseas");
                    Console.WriteLine("siempre y cuando esta exista en el tablero, sino tendrás que disparar de nuevo.");
                    Console.WriteLine("Los disparos son infinitos, y puedes hacerlo hasta terminar el juego");
                }
                break;

        }
    }
}
catch (Exception)
{
    Console.WriteLine("Ups, no ingresaste una de las opciones disponibles, vuelve a intentaro :) (PRESIONA ENTER)");

}

