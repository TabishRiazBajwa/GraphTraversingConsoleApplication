using System;
using System.Linq;

namespace GraphTraversing
{
    class Program
    {
        static void Main(string[] args)
        {
            var vertices2 = new[] { 0, 1, 2, 3, 4, 5 };
            var edges2 = new[]{ Tuple.Create(0,1) ,Tuple.Create(1,2), Tuple.Create(1,5),
                Tuple.Create(2,3), Tuple.Create(2,4), Tuple.Create(4,5)};
            var graph2 = new Graph<int>(vertices2, edges2);
            var vertices = new[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            var edges = new[]{ Tuple.Create('A','B') ,Tuple.Create('B','C'), Tuple.Create('B','E'),
                Tuple.Create('C','A'), Tuple.Create('C','D'), Tuple.Create('C','G'), Tuple.Create('D','A'),
                Tuple.Create('E','C'), Tuple.Create('E','F'), Tuple.Create('F','G')};
            var graph = new Graph<char>(vertices, edges);
            var algorithms = new Algorithms();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Perform Depth First Traversal");
                Console.WriteLine("2. Perform Breadth First Traversal");
                Console.WriteLine("3. Search Graph 1 (DFS)");
                Console.WriteLine("4. Search Graph 2 (BFS)");
                Console.WriteLine("5. Exit");
                var option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine("1. Perform Depth First Traversal on Graph 1");
                    Console.WriteLine("2. Perform Depth First Traversal on Graph 2");
                    option = Console.ReadLine();
                    if (option == "1")
                    {
                        Console.WriteLine(string.Join(", ", algorithms.DFS(graph, 'A')));
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(string.Join(", ", algorithms.DFS(graph2, 0)));
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                    }
                }
                else if (option == "2")
                {
                    Console.WriteLine("1. Perform Breadth First Traversal on Graph 1");
                    Console.WriteLine("2. Perform Breadth First Traversal on Graph 2");
                    option = Console.ReadLine();
                    if (option == "1")
                    {
                        Console.WriteLine(string.Join(", ", algorithms.BFS(graph, 'A')));
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(string.Join(", ", algorithms.BFS(graph2, 0)));
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                    }
                }
                else if (option == "3")
                {
                    Console.WriteLine("Please Input the Node");
                    option = Console.ReadLine();
                    if (vertices.Any(x => x.Equals(Convert.ToChar(option))))
                    {
                        Console.WriteLine(string.Join(", ", algorithms.DFS(graph, Convert.ToChar(option))));
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(option + " is not a Node");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                    }
                }
                else if (option == "4")
                {
                    Console.WriteLine("Please Input the Node");
                    option = Console.ReadLine();
                    if (option=="0" || option == "1" || option == "2" || option == "3" || option == "4" 
                        || option == "5")
                    {
                        Console.WriteLine(string.Join(", ", algorithms.BFS(graph2, Convert.ToInt32(option))));
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(option + " is not a Node");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                    }
                }
                else if (option == "5")
                {
                    break;
                }
            }
        }
    }
}
