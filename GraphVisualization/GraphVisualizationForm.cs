namespace GraphVisualization;

internal partial class GraphVisualizationForm : Form
{
    public GraphVisualizationForm()
    {
        InitializeComponent();

        Graph.VertexSelected += GraphOnVertexSelected;
        Graph.DistancesChanged += GraphOnDistancesChanged;
    }

    private void OnAddVertexClicked(object sender, EventArgs e)
    {
        if (_verticesInputGrid.Rows.Count >= 50)
        {
            MessageBox.Show("Количество вершин слишком большое",
                "Добавление вершины",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return;
        }

        _verticesInputGrid.Rows.Add(new DataGridViewRow());
    }

    private void OnCreateGraphClicked(object sender, EventArgs e)
    {
        DrawGraph();
    }

    private void OnRestartClicked(object sender, EventArgs e)
    {
        Application.Restart();
    }

    private void OnGraphPanelPainted(object sender, PaintEventArgs e)
    {
        using Graphics g = e.Graphics;

        DrawEdges(g);
        DrawVertexes(g);
    }

    private void OnRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
        _verticesInputGrid[0, _verticesInputGrid.Rows.Count - 1].Value = _verticesInputGrid.Rows.Count;
        _verticesInputGrid.AutoResizeColumn(0);
    }
}