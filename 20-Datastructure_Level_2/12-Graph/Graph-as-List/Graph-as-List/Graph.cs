using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_as_List
{
	internal class Graph
	{
		public enum enGraphType { Direct = 1, Undirect = 2 };
		enGraphType _graphType = enGraphType.Undirect;

		// [[],[],[]] 
		private Dictionary<string,List<Tuple<string,int>>> _adjacencyList;

		// dictionry
		private Dictionary<string, int> _vertixDictionary;


		public Graph(List<string> vertices, enGraphType graphType)
		{
			// initalization
			//_adjacencyList = new int[vertices.Count, vertices.Count];

			_vertixDictionary = new Dictionary<string, int>();

			_graphType = graphType;

			// [A,B,C,D,E]
			for (int i = 0; i < vertices.Count; i++)
			{
				_vertixDictionary.Add(vertices[i], i);

			}

		}

		private bool _isVertixExist(string vertix)
		{
			return _vertixDictionary.ContainsKey(vertix);
		}

		public void addEdge(string source, string to, int weight)
		{
			if (_isVertixExist(source) && _isVertixExist(source))
			{
				int sourceIndex = 0;
				int toIndex = 0;

				sourceIndex = _vertixDictionary.FirstOrDefault((vertix) => vertix.Key == source).Value;
				toIndex = _vertixDictionary.FirstOrDefault((vertix) => vertix.Key == to).Value;

				//_adjacencyList[sourceIndex, toIndex] = weight;


				if (_graphType == enGraphType.Undirect)
				{
					//_adjacencyList[toIndex, sourceIndex] = weight;
				}

			}
			else
			{
				Console.WriteLine("you can not add edge to undefined vertix");
			}
		}

		public void deleteEdge(string source, string to)
		{
			addEdge(source, to, 0);
		}

		public int inDegreeOf(string source)
		{
			int inDegree = 0;

			if (_isVertixExist(source))
			{
				int sourceIndex = 0;

				sourceIndex = _vertixDictionary.FirstOrDefault((vertix) => vertix.Key == source).Value;


				// in column how many income edge to vertix
				//for (int i = 0; i < _adjacencyList.GetLength(1); i++)
				//{
					//if (_adjacencyList[sourceIndex, i] > 0)
					//{
					//	inDegree++;
					//}
				//}

			}

			return inDegree;


		}

		public int outDegreeOf(string source)
		{
			int outDegree = 0;


			if (_isVertixExist(source))
			{
				int sourceIndex = 0;

				sourceIndex = _vertixDictionary.FirstOrDefault((vertix) => vertix.Key == source).Value;

				// in row how many outcome edge to vertix
				//for (int i = 0; i < _adjacencyList.GetLength(0); i++)
				//{
				//	if (_adjacencyList[i, sourceIndex] > 0)
				//	{
				//		outDegree++;
				//	}
				//}

			}
			return outDegree;
		}

		public void presentGraph()
		{
			// header
			Console.Write("  ");
			foreach (var vertix in _vertixDictionary)
			{
				Console.Write(vertix.Key + " ");
			}
			Console.WriteLine();


			// body
			//for (int i = 0; i < _adjacencyList.GetLength(0); i++)
			//{
			//	var vertix = _vertixDictionary.ElementAt(i);

			//	Console.Write(vertix.Key + " "); // first char in each row

			//	for (int j = 0; j < _adjacencyList.GetLength(1); j++)
			//	{
			//		Console.Write(_adjacencyList[i, j] + " ");
			//	}
			//	Console.WriteLine();

			//}
		}
	}
}
