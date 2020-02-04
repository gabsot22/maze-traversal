using System;

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
        // Boolean to make recursion stop
        bool endOfMaze = false;

        /// <summary>
        /// This is the public method that will allow someone to use this class to solve the maze.
        /// </summary>
        public void SolveMaze(char[,] maze, int xStart, int yStart)
        {
            endOfMaze = false;

            // Calls method to traverse through the maze
            mazeTraversal(xStart, yStart, maze);
        }

        /// <summary>
        /// Recursive method that gets called to solve the maze.
        /// </summary>
        private void mazeTraversal(int currentX, int currentY, char[,] maze)
        {
            /*************** ATTEMPT 1 ******************/

            // Checks if coordinates are inside the maze
            if (currentX <= 11 && currentY <= 11) //(currentX < maxX || currentX > 0 || currentY < maxY || currentY > 0)
            {

                // If the coordinate is a '.' , continue(This is the base case)
                if ('.' == maze[currentX, currentY])
                {
                    // Changes location to a X so you cant go back.
                    maze[currentX, currentY] = 'X';

                    // Prints maze with the current coordiantes
                    PrintOriginalMaze(maze, currentX, currentY);

                    // Checks if coordinate is at the end of maze
                    if (currentX != 11 && currentY != 11)
                    {
                        // Checks boolean to see if endOfMaze is not true
                        if (endOfMaze != true)
                            mazeTraversal(currentX, currentY + 1, maze); // Move Y coordinate up
                        if (endOfMaze != true)
                            mazeTraversal(currentX - 1, currentY, maze); // Move X coordinate left
                        if (endOfMaze != true)
                            mazeTraversal(currentX + 1, currentY, maze); // Move X coordinate right
                        if (endOfMaze != true)
                            mazeTraversal(currentX, currentY - 1, maze); // Move Y coordinate down
                    }
                    else
                    {
                        // End of maze... set true to stop recursion.
                        // Will return to where it was called.
                        endOfMaze = true;

                    }

                    //if ('X' == maze[currentX, currentY])
                    //{
                    //    maze[currentX, currentY] = '0';
                    //}
                }
            }
        }
        /// <summary>
        /// Method that prints out the maze
        /// </summary>
        /// <param name="maze"></param>
        /// <param name="xStart"></param>
        /// <param name="yStart"></param>
        public void PrintOriginalMaze(char[,] maze, int xStart, int yStart)
        {
            // Prints current coordinate
            Console.WriteLine("Moved to {0}, {1}", yStart, xStart);

            // Prints Maze...before Transposing
            for (int r = 0; r < maze.GetLength(0); r++)
            {
                for (int c = 0; c < maze.GetLength(1); c++)
                    Console.Write("{0}  ", maze[r, c]);            // rOW, cOLUMN - USE IT kiss!
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
