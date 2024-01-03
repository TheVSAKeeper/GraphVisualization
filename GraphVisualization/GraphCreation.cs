namespace GraphVisualization;

internal partial class GraphVisualizationForm
{
    private readonly List<Point> _vertexes = new();
    private Graph _graph = new(0);

    private void DrawGraph()
    {
        int vertexCount = _verticesInputGrid.Rows.Count;
        _graph = new Graph(vertexCount);

        if (FillGraphWithValidation() == false)
            return;

        GenerateVertexes(vertexCount);
        _graphPanel.Refresh();

        ClearCellHighlights();
    }

    private void GenerateVertexes(int vertexesCount)
    {
        _vertexes.Clear();
        
        for (int i = 0; i < vertexesCount; i++)
            AddVertex(i);
    }

    private void AddVertex(int i)
    {
        int radius = Math.Min(_graphPanel.Width / 2 - 30, _graphPanel.Height / 2 - 30);
        int vertexX = (int)(Math.Cos(2 * Math.PI * i / _graph.VerticesCount) * radius) + _graphPanel.Width / 2;
        int vertexY = (int)(Math.Sin(2 * Math.PI * i / _graph.VerticesCount) * radius) + _graphPanel.Height / 2;


        _vertexes.Add(new Point(vertexX, vertexY));
    }

    private void ClearCellHighlights()
    {
        foreach (DataGridViewRow row in _verticesInputGrid.Rows)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                cell.Style.BackColor = Color.Empty;
                cell.Style.ForeColor = Color.Empty;
            }
        }
    }

    private bool FillGraphWithValidation()
    {
        bool isValid = true;

        for (int i = 0; i < _verticesInputGrid.Rows.Count; i++)
        {
            DataGridViewRow row = _verticesInputGrid.Rows[i];

            if (row.Cells.Count < 2)
                continue;

            if (TryParseCellToInt(row.Cells[0], out int vertex))
            {
                vertex--;

                if (vertex < 0 || vertex >= _graph.VerticesCount)
                {
                    HighlightErrorCell(row.Cells[0]);
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(row.Cells[1].Value?.ToString()))
                    continue;

                if (ProcessNeighborData(row.Cells[1], vertex))
                    continue;

                HighlightErrorCell(row.Cells[1]);
                isValid = false;
            }
            else
            {
                HighlightErrorCell(row.Cells[0]);
                isValid = false;
            }
        }

        if (isValid == false)
            MessageBox.Show("Произошла ошибка ввода. Пожалуйста, исправьте неверные ячейки.",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

        return isValid;
    }

    private static bool TryParseCellToInt(DataGridViewCell cell, out int value) => int.TryParse(cell.Value?.ToString(), out value);

    private bool ProcessNeighborData(DataGridViewCell cell, int vertex)
    {
        string[] neighbors = cell.Value.ToString().Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

        foreach (string neighbor in neighbors)
        {
            if (TryParseNeighborData(neighbor, out int neighborVertex, out int edgeWeight) == false)
                return false;

            if (neighborVertex >= _graph.VerticesCount)
                return false;

            _graph.AddEdgeWithWeight(vertex, neighborVertex, edgeWeight);
        }

        return true;
    }

    private static bool TryParseNeighborData(string data, out int neighborVertex, out int edgeWeight)
    {
        neighborVertex = 0;
        edgeWeight = 0;

        if (int.TryParse(data, out neighborVertex))
        {
            neighborVertex--;
            return true;
        }

        if (data.Contains('/') == false)
            return false;

        string[] parts = data.Split('/', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length != 2 || int.TryParse(parts[0], out neighborVertex) == false || int.TryParse(parts[1], out edgeWeight) == false)
            return false;

        neighborVertex--;
        return true;
    }

    private static void HighlightErrorCell(DataGridViewCell cell)
    {
        cell.Style.BackColor = Color.Red;
        cell.Style.ForeColor = Color.White;
    }
}