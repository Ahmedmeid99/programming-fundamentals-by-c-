namespace Graph_as_List
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var listOfVertices = new List<string>() { "A", "B", "C", "D", "E" };
			var graph_1 = new Graph(listOfVertices, Graph.enGraphType.Undirect);

			graph_1.addEdge("A", "B", 1);
			graph_1.addEdge("A", "C", 1);
			graph_1.addEdge("B", "D", 1);
			graph_1.addEdge("B", "E", 1);
			graph_1.addEdge("C", "D", 1);
			graph_1.addEdge("E", "D", 1);

			graph_1.presentGraph();

			graph_1.deleteEdge("E", "D");

			Console.WriteLine();
			Console.WriteLine("-------------------------------------------");
			Console.WriteLine("-----[After .deleteEdge(\"E\", \"D\");]----");
			Console.WriteLine();

			graph_1.presentGraph();

			Console.WriteLine();
			Console.WriteLine("-------------------------------------------");
			Console.WriteLine($"in-degree of A  :{graph_1.inDegreeOf("A")}");
			Console.WriteLine($"out-degree of A :{graph_1.outDegreeOf("A")}");


			////////////////////////////////////////////////////////////////////

			var graph_2 = new Graph(listOfVertices, Graph.enGraphType.Direct);

			graph_2.addEdge("A", "A", 1);
			graph_2.addEdge("A", "B", 1);
			graph_2.addEdge("A", "C", 1);
			graph_2.addEdge("B", "E", 1);
			graph_2.addEdge("D", "B", 1);
			graph_2.addEdge("D", "C", 1);
			graph_2.addEdge("D", "E", 1);

			graph_2.presentGraph();




			Console.WriteLine();
			Console.WriteLine("-------------------------------------------");
			Console.WriteLine($"in-degree of A  :{graph_2.inDegreeOf("A")}");
			Console.WriteLine($"out-degree of A :{graph_2.outDegreeOf("A")}");

			graph_2.deleteEdge("D", "C");

			Console.WriteLine();
			Console.WriteLine("-------------------------------------------");
			Console.WriteLine("-----[After .deleteEdge(\"D\", \"C\");]----");
			Console.WriteLine();

			graph_2.presentGraph();
		}
	}
}
