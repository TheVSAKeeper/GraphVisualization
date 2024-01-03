namespace GraphVisualization;

internal partial class GraphVisualizationForm
{
    private readonly List<Dictionary<int, (int Distance, List<int> Path)>> _distanceHistory = new();
    private int _selectDistanceIndex = -1;

    private void GraphOnDistancesChanged(Dictionary<int, (int Distance, List<int> Path)> obj)
    {
        Dictionary<int, (int Distance, List<int> Path)> clone = new(obj);

        _distanceHistory.Add(clone);
    }

    private void SelectPath(int startVertex, List<int> shortestPath)
    {
        int prevVertex = startVertex;

        foreach (int vertex in shortestPath)
        {
            SelectVertex(vertex);
            SelectEdge(_vertexes[prevVertex], _vertexes[vertex]);
            prevVertex = vertex;
        }
    }

    private void OnNextPathClicked(object sender, EventArgs e)
    {
        if (_selectDistanceIndex > _graph.VerticesCount || _selectDistanceIndex == -1)
        {
            MessageBox.Show("Алгоритм Дейкстры завершен.");
            return;
        }

        DrawGraph();
        SelectAll(_selectHistoryIndex++);

        foreach (KeyValuePair<int, (int Distance, List<int> Path)> keyValuePair in _distanceHistory[_selectDistanceIndex++])
            DrawRedTextAboveVertex(keyValuePair.Key, keyValuePair.Value.Distance.ToString());
    }

    private void SelectAll(int i)
    {
        for (int j = 0; j < i; j++)
            SelectVertex(_selectHistory[j]);
    }

    private void FindShortestPathButtonClicked(object sender, EventArgs e)
    {
        if (_verticesInputGrid.SelectedRows.Count < 2)
            return;

        if (TryGetSelectedVertices(out int startVertex, out int endVertex) == false)
            return;

        DrawGraph();

        if (_graph.IsUnlinked(startVertex) || _graph.IsUnlinked(endVertex))
        {
            MessageBox.Show($"Между {startVertex + 1} и {endVertex + 1} не существует пути",
                "Алгоритм Дейкстры",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return;
        }

        _selectHistory.Clear();
        _distanceHistory.Clear();
        _selectHistoryIndex = 0;
        _selectDistanceIndex = 0;

        (int shortestDistance, List<int> shortestPath) = _graph.DijkstraShortestPath(startVertex, endVertex);
        SelectPath(startVertex, shortestPath);

        string pathText = string.Join(" -> ", shortestPath.Select(v => (v + 1).ToString()));
        MessageBox.Show($"Кратчайший путь от вершины {startVertex + 1} до вершины {endVertex + 1} равен {shortestDistance}: {pathText}");
    }

    private bool TryGetSelectedVertices(out int startVertex, out int endVertex)
    {
        startVertex = 0;
        endVertex = 0;

        int firstSelectedRowIndex = _verticesInputGrid.SelectedRows[0].Index;
        int secondSelectedRowIndex = _verticesInputGrid.SelectedRows[1].Index;

        object startVertexNumber = _verticesInputGrid.Rows[firstSelectedRowIndex].Cells[0].Value;
        object endVertexNumber = _verticesInputGrid.Rows[secondSelectedRowIndex].Cells[0].Value;

        if (startVertexNumber == null || endVertexNumber == null)
            return false;

        startVertex = int.Parse(startVertexNumber.ToString() ?? "0") - 1;
        endVertex = int.Parse(endVertexNumber.ToString() ?? "0") - 1;

        return startVertex >= 0 && endVertex >= 0;
    }
}