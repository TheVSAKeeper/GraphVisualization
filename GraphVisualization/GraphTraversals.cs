namespace GraphVisualization;

internal partial class GraphVisualizationForm
{
    private readonly List<int> _selectHistory = new();
    private int _selectHistoryIndex;

    private void GraphOnVertexSelected(int obj)
    {
        _selectHistory.Add(obj);
    }

    private void OnNextHistoryClicked(object sender, EventArgs e)
    {
        if (_selectHistoryIndex >= _selectHistory.Count)
        {
            MessageBox.Show("Обход завершён");
            return;
        }

        SelectVertex(_selectHistory[_selectHistoryIndex++]);
    }

    private void OnDFSButtonClicked(object sender, EventArgs e)
    {
        RunSearch(_graph.DepthFirstSearch, "DFS");
    }

    private void OnBFSButtonClicked(object sender, EventArgs e)
    {
        RunSearch(_graph.BreadthFirstSearch, "BFS");
    }

    private void RunSearch(Action<int> searchAlgorithm, string algorithmName)
    {
        if (_graph.VerticesCount == 0)
            return;

        _selectHistory.Clear();
        _selectHistoryIndex = 0;

        int startVertex = 0;
        searchAlgorithm(startVertex);

        DrawGraph();

        string message = $"Путь {algorithmName}: {string.Join(" -> ", _selectHistory.Select(v => v + 1))}";
        MessageBox.Show(message, $"Результат {algorithmName}");
    }
}