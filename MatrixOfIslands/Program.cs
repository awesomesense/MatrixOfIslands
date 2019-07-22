using System;

namespace MatrixOfIslands
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] islandsArr = new int[4, 5];


            // Fill the matrix randomly
            var random = new Random();

            // i - row
            // j - col
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    var tempValue = random.Next(0, 5);
                    islandsArr[i, j] = tempValue >= 3 ? 1 : 0;
                    Console.Write($"{islandsArr[i, j]}\t");
                }
                Console.WriteLine();
            }


            // Iterate and count a number of islands
            var numberOfIslands = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (islandsArr[i, j] == 1)
                    {
                        if (numberOfIslands == 0) // first hit
                        {
                            numberOfIslands++;
                            continue;
                        }


                        // Look at the values on the left and on the top of the current cell

                        // if top AND left BOTH are 1: do --
                        if (i > 0 && j > 0            &&  // do not check for 1st row or 1st col
                            islandsArr[i, j - 1] == 1 &&
                            islandsArr[i - 1, j] == 1)
                        {
                            numberOfIslands--;
                            continue;
                        }

                        // if top AND left both are 0: do ++
                        if ((i == 0 || islandsArr[i - 1, j] == 0) && // if TOP  val is 0  (do not check if it's 1st row: i==0)
                            (j == 0 || islandsArr[i, j - 1] == 0))   // if LEFT val is 0  (do not check if it's 1st col: j==0)
                        {
                            numberOfIslands++;
                            continue;
                        }
                    }
                }
            }

            Console.WriteLine($"\r\nNumber of islands = {numberOfIslands}");
            Console.ReadLine();
        }
    }
}
