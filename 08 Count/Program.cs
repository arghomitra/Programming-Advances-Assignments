namespace _08_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maze maze = new Maze(4);
            maze.AddEdge(1, 2);
            //maze.AddEdge(2, 3);
            //maze.AddEdge(1, 3);

            Console.WriteLine(maze.ToString());
            Console.WriteLine(maze.Count(4));
        }
    }
}