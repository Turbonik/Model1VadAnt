namespace Model1VadAnt
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LemerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LemerChart)).BeginInit();
            this.SuspendLayout();
            // 
            // LemerChart
            // 
            chartArea4.Name = "ChartArea1";
            this.LemerChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.LemerChart.Legends.Add(legend4);
            this.LemerChart.Location = new System.Drawing.Point(13, 59);
            this.LemerChart.Margin = new System.Windows.Forms.Padding(4);
            this.LemerChart.Name = "LemerChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.LemerChart.Series.Add(series4);
            this.LemerChart.Size = new System.Drawing.Size(659, 466);
            this.LemerChart.TabIndex = 0;
            this.LemerChart.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(779, 59);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(690, 178);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(0, 16);
            this.text.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 554);
            this.Controls.Add(this.text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LemerChart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LemerChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart LemerChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label text;
    }
}

