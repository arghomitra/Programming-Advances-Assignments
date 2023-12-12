namespace _08_Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maze maze = new Maze(5);
            maze.AddEdge(0, 1);
            maze.AddEdge(1, 2);
            maze.AddEdge(0, 2);
            maze.AddEdge(3, 0);
            maze.AddEdge(3, 4);

            Console.WriteLine(maze.ToString());
            for (int i = 0; i < 4; i++)
            {
                string result = maze.cyclic(i);
                if (result== "cyclic")
                {
                    Console.WriteLine(result);
                    break;
                }
            }
            
        }
    }
}