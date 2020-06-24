namespace lista_4zad3
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartArea = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.FirstFButton = new System.Windows.Forms.Button();
            this.SeccondFButton = new System.Windows.Forms.Button();
            this.AddA = new System.Windows.Forms.Button();
            this.AddB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartArea)).BeginInit();
            this.SuspendLayout();
            // 
            // chartArea
            // 
            chartArea2.Name = "ChartArea1";
            this.chartArea.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartArea.Legends.Add(legend2);
            this.chartArea.Location = new System.Drawing.Point(10, 11);
            this.chartArea.Margin = new System.Windows.Forms.Padding(2);
            this.chartArea.Name = "chartArea";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartArea.Series.Add(series2);
            this.chartArea.Size = new System.Drawing.Size(855, 416);
            this.chartArea.TabIndex = 0;
            this.chartArea.Text = "chart1";
            this.chartArea.Click += new System.EventHandler(this.chart1_Click);
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(6, 432);
            this.ATextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(104, 20);
            this.ATextBox.TabIndex = 1;
            this.ATextBox.Text = "A";
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(191, 431);
            this.BTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(104, 20);
            this.BTextBox.TabIndex = 3;
            this.BTextBox.Text = "B";
            this.BTextBox.TextChanged += new System.EventHandler(this.BTextBox_TextChanged);
            // 
            // FirstFButton
            // 
            this.FirstFButton.Location = new System.Drawing.Point(373, 433);
            this.FirstFButton.Margin = new System.Windows.Forms.Padding(2);
            this.FirstFButton.Name = "FirstFButton";
            this.FirstFButton.Size = new System.Drawing.Size(80, 19);
            this.FirstFButton.TabIndex = 7;
            this.FirstFButton.Text = "Kwadratowa";
            this.FirstFButton.UseVisualStyleBackColor = true;
            this.FirstFButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SeccondFButton
            // 
            this.SeccondFButton.Location = new System.Drawing.Point(457, 433);
            this.SeccondFButton.Margin = new System.Windows.Forms.Padding(2);
            this.SeccondFButton.Name = "SeccondFButton";
            this.SeccondFButton.Size = new System.Drawing.Size(64, 19);
            this.SeccondFButton.TabIndex = 8;
            this.SeccondFButton.Text = "Liniowa";
            this.SeccondFButton.UseVisualStyleBackColor = true;
            this.SeccondFButton.Click += new System.EventHandler(this.SeccondFButton_Click);
            // 
            // AddA
            // 
            this.AddA.Location = new System.Drawing.Point(114, 432);
            this.AddA.Margin = new System.Windows.Forms.Padding(2);
            this.AddA.Name = "AddA";
            this.AddA.Size = new System.Drawing.Size(70, 20);
            this.AddA.TabIndex = 9;
            this.AddA.Text = "Dodaj";
            this.AddA.UseVisualStyleBackColor = true;
            this.AddA.Click += new System.EventHandler(this.AddA_Click);
            // 
            // AddB
            // 
            this.AddB.Location = new System.Drawing.Point(299, 432);
            this.AddB.Margin = new System.Windows.Forms.Padding(2);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(70, 20);
            this.AddB.TabIndex = 10;
            this.AddB.Text = "Dodaj";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 462);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.AddA);
            this.Controls.Add(this.SeccondFButton);
            this.Controls.Add(this.FirstFButton);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.ATextBox);
            this.Controls.Add(this.chartArea);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Grafy";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartArea;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Button FirstFButton;
        private System.Windows.Forms.Button SeccondFButton;
        private System.Windows.Forms.Button AddA;
        private System.Windows.Forms.Button AddB;
    }
}

