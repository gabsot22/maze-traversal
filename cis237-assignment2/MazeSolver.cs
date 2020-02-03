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
        /// <summary>
        /// This is the public method that will allow someone to use this class to solve the maze.
        /// Feel free to change the return type, or add more parameters if you like, but it can be done
        /// exactly as it is here without adding anything other than code in the body.
        /// </summary>
        public void SolveMaze(char[,] maze, int xStart, int yStart)
        {
            // Do work needed to use mazeTraversal recursive call and solve the maze.

            // solveMaze(xStart, yStart, maze);
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
            ///*******************ATTEMPT 2***************/
            //// Checks if coordinates are outside the maze
            //if (currentX == 12 || currentY == 12)
            //{
            //    // Implement maze traversal recursive call
            //    //PrintOriginalMaze(maze, currentX, currentY);


            //}
            //else if ('.' == maze[currentX, currentY])
            //// If the coordinate is a '.' , continue(This is the base case)

            //{

            //    // Implement maze traversal recursive call
            //    PrintOriginalMaze(maze, currentX, currentY);

            //    // Changes location to a X so you cant go back.
            //    maze[currentX, currentY] = 'X';

            //    mazeTraversal(currentX, currentY + 1, maze);
            //    mazeTraversal(currentX - 1, currentY, maze);
            //    mazeTraversal(currentX + 1, currentY, maze);
            //    mazeTraversal(currentX, currentY - 1, maze);

            //    //if ('X' == maze[currentX, currentY])
            //    //{
            //    //    maze[currentX, currentY] = '0';
            //    //}
            //}



            /*************** ATTEMPT 1 ******************/

            var maxX = maze.GetUpperBound(0);
            var maxY = maze.GetUpperBound(1);



            // Checks if coordinates are inside the maze
            if (currentX <= 11 && currentY <= 11) //(currentX < maxX || currentX > 0 || currentY < maxY || currentY > 0)
            {

                // If the coordinate is a '.' , continue(This is the base case)
                if ('.' == maze[currentX, currentY])
                {
                    // Changes location to a X so you cant go back.
                    maze[currentX, currentY] = 'X';

                    // Implement maze traversal recursive call
                    PrintOriginalMaze(maze, currentX, currentY);

                    if (currentX != 11 && currentY != 11)
                    {
                        if ('.' != maze[currentX, currentY])
                            mazeTraversal(currentX, currentY + 1, maze);
                        if ('X' != maze[currentX, currentY])
                            mazeTraversal(currentX - 1, currentY, maze);
                        if ('X' != maze[currentX, currentY])
                            mazeTraversal(currentX + 1, currentY, maze);
                        if ('X' != maze[currentX, currentY])
                            mazeTraversal(currentX, currentY - 1, maze);
                    }
                    return ;
                }

                
            }
            
        }

        public void PrintOriginalMaze(char[,] maze, int xStart, int yStart)
        {
            Console.WriteLine("Moved to {0}, {1}", xStart, yStart);

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
            for (int c = 0; c < maze.GetLength(1); c++)
            {
                for (int r = 0; r < maze.GetLength(0); r++)
                {
                    Console.Write("{0}  ", maze[r, c]); // do assignments

                }

                Console.WriteLine();

            }
        }


    }
}
