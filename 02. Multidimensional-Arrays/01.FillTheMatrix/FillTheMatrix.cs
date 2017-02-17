using System;

class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string charachter = Console.ReadLine();

        int[,] matrix = new int[n, n];

        string direction = "down";
        int currentCol = 0;
        int currentRow = 0;
        int filler = 1;
        switch (charachter)
        {
            case "a":
                for (int i = 0; i <= n - 1; i++)
                {
                    if (i != n)
                    {
                        filler = i + 1;
                    }

                    for (int j = 0; j <= n - 1; j++)
                    {
                        matrix[i, j] = filler;
                        Console.Write("{0} ", matrix[i, j]);
                        filler += 4;
                    }
                    Console.WriteLine();
                }; break;
            case "b":
                for (int i = 1; i <= n * n; i++)
                {
                    if (direction == "down" && (currentRow >= n || matrix[currentRow, currentCol] != 0))
                    {
                        currentRow--;
                        currentCol++;
                        direction = "up";
                    }
                    else if (direction == "up" && (currentRow < 0 || matrix[currentRow, currentCol] != 0))
                    {
                        currentRow++;
                        currentCol++;
                        direction = "down";
                    }

                    matrix[currentRow, currentCol] = i;

                    if (direction == "up")
                    {
                        currentRow--;
                    }
                    else if (direction == "down")
                    {
                        currentRow++;
                    }
                }
                for (int i = 0; i <= n - 1; i++)
                {
                    for (int j = 0; j <= n - 1; j++)
                    {
                        Console.Write("{0} ", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
                break;
            case "c":
                
                int startRow = (n - 1) - 1;
                int startCol = 1;
          
                currentCol = 0;
                currentRow = (n - 1);

                for (int i = 1; i <= n * n; i++)
                {
                    if (direction == "down" && currentRow > n - 1)
                    {
                        if (currentCol == n)
                        {
                            direction = "half";
                        }
                        else
                        {
                            currentCol = 0;
                            currentRow = startRow;
                            startRow -= 1;
                        }
                    }
                    if (direction == "half" && currentCol == n )
                    {
                        currentRow = 0;
                        currentCol = startCol;
                        startCol += 1;

                    }

                    matrix[currentRow, currentCol] = i;

                    if (direction == "half")
                    {
                        currentCol++;
                        currentRow++;
                    }
                    if (direction == "down")
                    {
                        currentRow++;
                        currentCol++;
                    }
                }
                for (int i = 0; i <= n - 1; i++)
                {
                    for (int z = 0; z <= n - 1; z++)
                    {
                        Console.Write("{0} ", matrix[i, z]);
                    }
                    Console.WriteLine();
                }
                break;
            case "d":
                for (int i = 1; i <= n * n; i++)
                {
                    if (direction == "down" && (currentRow >= n || matrix[currentRow, currentCol] != 0))
                    {
                        currentRow--;
                        currentCol++;
                        direction = "right";
                    }
                    else if (direction == "right" && (currentCol >= n || matrix[currentRow, currentCol] != 0))
                    {
                        currentRow--;
                        currentCol--;
                        direction = "up";
                    }
                    else if (direction == "up" && (currentRow < 0 || matrix[currentRow, currentCol] != 0))
                    {
                        currentRow++;
                        currentCol--;
                        direction = "left";
                    }
                    else if (direction == "left" && (currentCol < 0 || matrix[currentRow, currentCol] != 0))
                    {
                        currentRow++;
                        currentCol++;
                        direction = "down";
                    }

                    matrix[currentRow, currentCol] = i;

                    if (direction == "down")
                    {
                        currentRow++;
                    }
                    else if (direction == "right")
                    {
                        currentCol++;
                    }
                    else if (direction == "up")
                    {
                        currentRow--;
                    }
                    else if (direction == "left")
                    {
                        currentCol--;
                    }

                }
                for (int i = 0; i <= n - 1; i++)
                {
                    for (int j = 0; j <= n - 1; j++)
                    {
                        Console.Write("{0} ", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
               ; break;

            default:
                break;
        }
        {

        }
    }
}
