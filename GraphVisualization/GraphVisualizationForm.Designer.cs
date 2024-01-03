namespace GraphVisualization;

partial class GraphVisualizationForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>

      private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._graphPanel = new System.Windows.Forms.Panel();
            this._verticesInputGrid = new System.Windows.Forms.DataGridView();
            this.Vertex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neighbors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._verticesInputGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.50254F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.49746F));
            this.tableLayoutPanel1.Controls.Add(this._graphPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._verticesInputGrid, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.5287F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.4713F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 662);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _graphPanel
            // 
            this._graphPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._graphPanel.Location = new System.Drawing.Point(3, 3);
            this._graphPanel.Name = "_graphPanel";
            this.tableLayoutPanel1.SetRowSpan(this._graphPanel, 2);
            this._graphPanel.Size = new System.Drawing.Size(533, 656);
            this._graphPanel.TabIndex = 0;
            this._graphPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnGraphPanelPainted);
            // 
            // _verticesInputGrid
            // 
            this._verticesInputGrid.AllowUserToAddRows = false;
            this._verticesInputGrid.AllowUserToResizeColumns = false;
            this._verticesInputGrid.AllowUserToResizeRows = false;
            this._verticesInputGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._verticesInputGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._verticesInputGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Vertex, this.Neighbors });
            this._verticesInputGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._verticesInputGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this._verticesInputGrid.Location = new System.Drawing.Point(542, 3);
            this._verticesInputGrid.Name = "_verticesInputGrid";
            this._verticesInputGrid.Size = new System.Drawing.Size(463, 494);
            this._verticesInputGrid.TabIndex = 1;
            this._verticesInputGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.OnRowsAdded);
            // 
            // Vertex
            // 
            this.Vertex.HeaderText = "Вершина";
            this.Vertex.Name = "Vertex";
            this.Vertex.ReadOnly = true;
            // 
            // Neighbors
            // 
            this.Neighbors.HeaderText = "Связанные вершины";
            this.Neighbors.Name = "Neighbors";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(542, 503);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 156);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button7, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button6, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.button4, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button8, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(457, 137);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить вершину";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnAddVertexClicked);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(117, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 62);
            this.button2.TabIndex = 3;
            this.button2.Text = "Создать граф";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnCreateGraphClicked);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(231, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 62);
            this.button5.TabIndex = 7;
            this.button5.Text = "Поиск пути";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.FindShortestPathButtonClicked);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(345, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 62);
            this.button7.TabIndex = 9;
            this.button7.Text = "->";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.OnNextPathClicked);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(345, 71);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 63);
            this.button6.TabIndex = 8;
            this.button6.Text = "->";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.OnNextHistoryClicked);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(231, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 63);
            this.button4.TabIndex = 6;
            this.button4.Text = "Обход в ширину";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OnBFSButtonClicked);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(117, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 63);
            this.button3.TabIndex = 4;
            this.button3.Text = "Обход в глубину";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OnDFSButtonClicked);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(3, 71);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(108, 63);
            this.button8.TabIndex = 10;
            this.button8.Text = "Перезапустить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.OnRestartClicked);
            // 
            // GraphVisualizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "GraphVisualizationForm";
            this.Text = "Графы";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._verticesInputGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button8;

        private System.Windows.Forms.Button button7;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

        private System.Windows.Forms.Button button6;

        private System.Windows.Forms.Button button5;

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.DataGridViewTextBoxColumn Vertex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neighbors;

        private System.Windows.Forms.DataGridView _verticesInputGrid;

        private System.Windows.Forms.Panel _graphPanel;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    
    #endregion
}