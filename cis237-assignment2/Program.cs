﻿using System;

namespace cis237_assignment2
{
    class Program
    {
        /// <summary>
        /// This is the main entry point for the program.
        /// You are free to add anything else you would like to this program,
        /// however the maze solving part needs to occur in the MazeSolver class.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Starting Coordinates.
            const int X_START = 1;
            const int Y_START = 1;

            // The first maze that needs to be solved.
            // Note: You may want to make a smaller version to test and debug with.
            // You don't have to, but it might make your life easier.
            char[,] maze1 =
                { { '#', '#', '#', '#', '#' },
                 { '#', '.', '.', '#', '#', },
                 { '#', '#', '.', '#', '#', },
                 { '#', '#', '.', '.', '.', },
                 { '#', '#', '#', '#', '#' } };
                // USE THIS
            //{ { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
            //{ '#', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '#' },
            //{ '#', '.', '#', '.', '#', '.', '#', '#', '#', '#', '.', '#' },
            //{ '#', '#', '#', '.', '#', '.', '.', '.', '.', '#', '.', '#' },
            //{ '#', '.', '.', '.', '.', '#', '#', '#', '.', '#', '.', '.' },
            //{ '#', '#', '#', '#', '.', '#', '.', '#', '.', '#', '.', '#' },
            //{ '#', '.', '.', '#', '.', '#', '.', '#', '.', '#', '.', '#' },
            //{ '#', '#', '.', '#', '.', '#', '.', '#', '.', '#', '.', '#' },
            //{ '#', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '#' },
            //{ '#', '#', '#', '#', '#', '#', '.', '#', '#', '#', '.', '#' },
            //{ '#', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '#' },
            //{ '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' } };

            // Create a new instance of a mazeSolver.
            MazeSolver mazeSolver = new MazeSolver();

            // Print original maze
            mazeSolver.PrintOriginalMaze(maze1, X_START, Y_START);

            mazeSolver.PrintTransposedMaze(maze1, X_START, Y_START);

            // Create the second maze by transposing the first maze
           // char[,] maze2 = transposeMaze(maze1);

            
            // Solve the original maze.
            mazeSolver.SolveMaze(maze1, X_START, Y_START);

            // Solve the transposed maze.
           // mazeSolver.SolveMaze(maze2, X_START, Y_START);

            

        }

        /// <summary>
        /// This method will take in a 2 dimensional char array and return
        /// a char array maze that is flipped along the diagonal, or in mathematical
        /// terms, transposed.
        /// ie. if the array looks like 1, 2, 3
        ///                             4, 5, 6
        ///                             7, 8, 9
        /// The returned result will be:
        ///                             1, 4, 7
        ///                             2, 5, 8
        ///                             3, 6, 9
        /// The current return statement is just a placeholder so the program
        /// doesn't complain about no return value.
        /// 
        /// It is important that you return a "new" char array as the transposed maze.
        /// If you do not, you could end up only solving the transposed maze.
        /// </summary>
        /// <param name="mazeToTranspose"></param>
        /// <returns>transposedMaze</returns>
        static char[,] transposeMaze(char[,] mazeToTranspose)
        {
            //Write code here to create a transposed maze.

            ////Before Transposing
            //for (int r = 0; r < mazeToTranspose.GetLength(0); r++)
            //{
            //    for (int c = 0; c < mazeToTranspose.GetLength(1); c++)
            //        Console.Write("{0}  ", mazeToTranspose[r, c]);            // rOW, cOLUMN
            //    Console.WriteLine();
            //}
            //Console.WriteLine();


            // Output Transposed maze
            for (int c = 0; c < mazeToTranspose.GetLength(1); c++)
            {
                for (int r = 0; r < mazeToTranspose.GetLength(0); r++)
                    Console.Write("{0}  ", mazeToTranspose[r, c]); // do assignments
                Console.WriteLine();
                
            }
            
            return new char[1, 1]; // Just a place holder
        }
    }
}
