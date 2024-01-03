namespace GraphVisualization;

internal class Graph
{
    private readonly Dictionary<(int, int), int> _edgeWeights = new();
    private readonly List<int>[] _adjacencyList;

    public Graph(int verticesCount)
    {
        VerticesCount = verticesCount;
        _adjacencyList = new List<int>[verticesCount];

        for (int i = 0; i < verticesCount; i++)
            _adjacencyList[i] = new List<int>();
    }

    public int VerticesCount { get; }
    public static event Action<int>? VertexSelected;
    public static event Action<Dictionary<int, (int Distance, List<int> Path)>>? DistancesChanged;

    public void AddEdgeWithWeight(int startVertex, int endVertex, int weight)
    {
        if (startVertex == endVertex)
            return;

        _adjacencyList[startVertex].Add(endVertex);
        _adjacencyList[endVertex].Add(startVertex);

        if (weight <= 0)
            return;

        _edgeWeights[(startVertex, endVertex)] = weight;
        _edgeWeights[(endVertex, startVertex)] = weight;
    }

    public bool IsUnlinked(int vertex) => vertex < 0 || vertex >= _adjacencyList.Length || _adjacencyList[vertex].Count == 0;

    public IEnumerable<int> GetNeighbors(int vertex) => _adjacencyList[vertex];

    public int GetEdgeWeight(int startVertex, int endVertex) =>
        _edgeWeights.TryGetValue((startVertex, endVertex), out int weight) ? weight : 1;

    public void DepthFirstSearch(int startVertex)
    {
        bool[] visitedVertices = new bool[VerticesCount];

        DepthFirstSearch(startVertex, visitedVertices);
    }

    private void DepthFirstSearch(int vertex, IList<bool> visited)
    {
        visited[vertex] = true;

        VertexSelected?.Invoke(vertex);

        foreach (int neighbor in _adjacencyList[vertex].Where(neighbor => visited[neighbor] == false))
            DepthFirstSearch(neighbor, visited);
    }

    public void BreadthFirstSearch(int startVertex)
    {
        bool[] visitedVertices = new bool[VerticesCount];

        Queue<int> queue = new();

        queue.Enqueue(startVertex);
        visitedVertices[startVertex] = true;

        while (queue.Count > 0)
        {
            int currentVertex = queue.Dequeue();

            VertexSelected?.Invoke(currentVertex);

            foreach (int neighbor in GetNeighbors(currentVertex).Where(neighbor => visitedVertices[neighbor] == false))
            {
                visitedVertices[neighbor] = true;
                queue.Enqueue(neighbor);
            }
        }
    }

    public (int Distance, List<int> Path) DijkstraShortestPath(int startVertex, int endVertex) => DijkstraShortestPath(startVertex)[endVertex];

    private Dictionary<int, (int Distance, List<int> Path)> DijkstraShortestPath(int startVertex)
    {
        Dictionary<int, (int Distance, List<int> Path)> distances = new();

        for (int i = 0; i < VerticesCount; i++)
            distances[i] = (int.MaxValue, new List<int>());

        distances[startVertex] = (0, new List<int> { startVertex });
        DistancesChanged?.Invoke(distances);

        HashSet<int> unprocessedVertices = new();

        for (int i = 0; i < VerticesCount; i++)
            unprocessedVertices.Add(i);

        while (unprocessedVertices.Count > 0)
        {
            int currentVertex = -1;
            int minDistance = int.MaxValue;

            foreach (int vertex in unprocessedVertices.Where(vertex => distances[vertex].Distance < minDistance))
            {
                currentVertex = vertex;
                minDistance = distances[vertex].Distance;
            }

            unprocessedVertices.Remove(currentVertex);

            VertexSelected?.Invoke(currentVertex);

            foreach (int neighbor in GetNeighbors(currentVertex))
            {
                int edgeWeight = GetEdgeWeight(currentVertex, neighbor);
                int totalDistance = distances[currentVertex].Distance + edgeWeight;

                if (totalDistance < distances[neighbor].Distance)
                    distances[neighbor] = (totalDistance, new List<int>(distances[currentVertex].Path) { neighbor });
            }

            DistancesChanged?.Invoke(distances);
        }

        return distances;
    }
}