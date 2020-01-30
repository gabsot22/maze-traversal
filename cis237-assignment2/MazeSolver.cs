﻿using System;

namespace cis237_assignment2
{
    /// <summary>
    /// This class is used for solving a char array maze.
    /// You might want to add other methods to help you out.
    /// A print maze method would be very useful, and probably neccessary to print the solution.
    /// If you are real ambitious, you could make a seperate class to handle that.
    /// </summary>
    class MazeSolver
    {
        /// <summary>
        /// This is the public method that will allow someone to use this class to solve the maze.
        /// Feel free to change the return type, or add more parameters if you like, but it can be done
        /// exactly as it is here without adding anything other than code in the body.
        /// </summary>
        public void SolveMaze(char[,] maze, int xStart, int yStart)
        {
            // Do work needed to use mazeTraversal recursive call and solve the maze.
            
            mazeTraversal(xStart, yStart, maze);

            

        }


        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// More than likely you will need to pass in at a minimum the current position
        /// in X and Y maze coordinates. EX: mazeTraversal(int currentX, int currentY)
        /// </summary>
        private void mazeTraversal(int currentX, int currentY, char[,] maze)
        {
            // Implement maze traversal recursive call

            //if (currentX == 1 && currentY == 1)
            //{
            //    return;
            //}
            //return currentX * mazeTraversal(currentX - 1);

            // This is the base case
            if ('.' == maze[currentX, currentY])
            {
                Console.WriteLine("Moved to {0}, {1}", currentX, currentY);
           
                mazeTraversal(currentX - 1, currentY, maze);
                mazeTraversal(currentX + 1, currentY, maze);

                mazeTraversal(currentX, currentY + 1, maze);
                mazeTraversal(currentX, currentY - 1, maze);
            }

            //if (direction == up)
            //{
            //    mazeTraversal(currentY + 1, currentX, direction, up, right, down, left);
            //}
            //if (direction == down)
            //{
            //    mazeTraversal(currentY - 1, currentX, direction, up, right, down, left);
            //}
            //if (direction == left)
            //{
            //    mazeTraversal(currentX - 1, currentY, direction, up, right, down, left);
            //}
            //if (direction == right)
            //{
            //    mazeTraversal(currentX + 1, currentY, direction, up, right, down, left);
            //}


        }

        public void PrintOriginalMaze(char[,] maze, int xStart, int yStart)
        {

            //Before Transposing
            for (int r = 0; r < maze.GetLength(0); r++)
            {
                for (int c = 0; c < maze.GetLength(1); c++)
                    Console.Write("{0}  ", maze[r, c]);            // rOW, cOLUMN - USE IT kiss!
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void PrintTransposedMaze(char[,] maze, int xStart, int yStart)
        {

        }


    }
}
