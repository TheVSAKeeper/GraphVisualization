namespace GraphVisualization;

internal partial class GraphVisualizationForm
{
    private const int FirstWebColor = 28;
    private const int LastWebColor = 167;
    private readonly List<Color> _edgesColors = GenerateEdgeColors(LastWebColor - FirstWebColor);

    private static List<Color> GenerateEdgeColors(int capacity)
    {
        List<Color> edgesColors = new(capacity);
        Random random = new();

        for (int i = FirstWebColor; i < LastWebColor; i++)
        {
            KnownColor knownColor = (KnownColor)i;
            edgesColors.Add(Color.FromKnownColor(knownColor));
        }

        return edgesColors.OrderBy(_ => random.Next()).ToList();
    }

    private void SelectVertex(int index)
    {
        Graphics g = _graphPanel.CreateGraphics();
        Point vertex = _vertexes[index];

        int circleDiameter = 66;
        float circleX = vertex.X - circleDiameter / 2f;
        float circleY = vertex.Y - circleDiameter / 2f;

        Pen pen = new(Color.Red, 5);
        g.DrawEllipse(pen, circleX, circleY, circleDiameter, circleDiameter);
    }

    private void SelectEdge(Point startVertex, Point endVertex)
    {
        Graphics g = _graphPanel.CreateGraphics();

        Pen edgePen = new(Color.DarkGreen, 5);
        g.DrawLine(edgePen, startVertex, endVertex);
    }

    private void DrawEdges(Graphics g)
    {
        int colorIndex = 0;

        for (int i = 0; i < _graph.VerticesCount; i++)
            foreach (int neighbor in _graph.GetNeighbors(i))
            {
                Point startVertex = _vertexes[i];
                Point endVertex = _vertexes[neighbor];

                Pen edgePen = new(_edgesColors[colorIndex++ % _edgesColors.Count], 3);
                g.DrawLine(edgePen, startVertex, endVertex);

                int edgeWeight = _graph.GetEdgeWeight(i, neighbor);
                DrawWeight(g, edgeWeight, startVertex, endVertex);
            }
    }

    private static void DrawWeight(Graphics g, int edgeWeight, Point startVertex, Point endVertex)
    {
        if (edgeWeight <= 0)
            return;

        string weightText = edgeWeight.ToString();

        Font weightFont = new(FontFamily.GenericMonospace, 18f, FontStyle.Bold);
        SizeF weightSize = g.MeasureString(weightText, weightFont);

        float weightX = (startVertex.X + endVertex.X - weightSize.Width) / 2;
        float weightY = (startVertex.Y + endVertex.Y - weightSize.Height) / 2;

        g.DrawString(weightText, weightFont, Brushes.Black, weightX, weightY);
    }

    private void DrawVertexes(Graphics g)
    {
        for (int i = 0; i < _graph.VerticesCount; i++)
        {
            Point vertex = _vertexes[i];

            int circleDiameter = 60;
            float circleX = vertex.X - circleDiameter / 2f;
            float circleY = vertex.Y - circleDiameter / 2f;

            g.FillEllipse(Brushes.Blue, circleX, circleY, circleDiameter, circleDiameter);

            string text = (i + 1).ToString();

            Font textFont = new(FontFamily.GenericMonospace, 20f);
            SizeF textSize = g.MeasureString(text, textFont);

            float textX = circleX + (circleDiameter - textSize.Width) / 2;
            float textY = circleY + (circleDiameter - textSize.Height) / 2;

            g.DrawString(text, textFont, Brushes.White, textX, textY);
        }
    }

    private void DrawRedTextAboveVertex(int vertexIndex, string text)
    {
        if (vertexIndex < 0 || vertexIndex >= _vertexes.Count)
            return;

        using Graphics g = _graphPanel.CreateGraphics();

        Point vertex = _vertexes[vertexIndex];
        Font textFont = new(FontFamily.GenericMonospace, 14f);
        SizeF textSize = g.MeasureString(text, textFont);

        int offset = 20;
        float textX = vertex.X - textSize.Width / 2;
        float textY = vertex.Y - textSize.Height - offset;

        g.DrawString(text, textFont, Brushes.Red, textX, textY);
    }
}