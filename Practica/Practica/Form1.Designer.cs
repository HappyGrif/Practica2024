namespace Practica
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_map = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_kyrs = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.BelWeb_USD_label = new System.Windows.Forms.Label();
            this.nbrb_USD_label = new System.Windows.Forms.Label();
            this.bb_USD_label = new System.Windows.Forms.Label();
            this.nbrb_EUR_label = new System.Windows.Forms.Label();
            this.nbrb_RUB_label = new System.Windows.Forms.Label();
            this.nbrb_CNY_label = new System.Windows.Forms.Label();
            this.nbrb_label = new System.Windows.Forms.Label();
            this.BelWeb_label = new System.Windows.Forms.Label();
            this.BelWeb_EUR_label = new System.Windows.Forms.Label();
            this.BelWeb_RUB_label = new System.Windows.Forms.Label();
            this.BelWeb_CNY_label = new System.Windows.Forms.Label();
            this.BB_label = new System.Windows.Forms.Label();
            this.bb_EUR_label = new System.Windows.Forms.Label();
            this.bb_RUB_label = new System.Windows.Forms.Label();
            this.bb_CNY_label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_map);
            this.panel1.Controls.Add(this.button_Exit);
            this.panel1.Controls.Add(this.button_kyrs);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 640);
            this.panel1.TabIndex = 0;
            // 
            // button_map
            // 
            this.button_map.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_map.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_map.Location = new System.Drawing.Point(0, 106);
            this.button_map.Name = "button_map";
            this.button_map.Size = new System.Drawing.Size(118, 81);
            this.button_map.TabIndex = 3;
            this.button_map.Text = "Карта Отделений";
            this.button_map.UseVisualStyleBackColor = true;
            this.button_map.Click += new System.EventHandler(this.button_map_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Location = new System.Drawing.Point(0, 557);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(118, 81);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_kyrs
            // 
            this.button_kyrs.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_kyrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kyrs.Location = new System.Drawing.Point(0, 25);
            this.button_kyrs.Name = "button_kyrs";
            this.button_kyrs.Size = new System.Drawing.Size(118, 81);
            this.button_kyrs.TabIndex = 2;
            this.button_kyrs.Text = "Курсы валют";
            this.button_kyrs.UseVisualStyleBackColor = true;
            this.button_kyrs.Click += new System.EventHandler(this.button_kyrs_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 25);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Practica2024";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(120, 251);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 389);
            this.panel2.TabIndex = 1;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(120, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1080, 251);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Visible = false;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // BelWeb_USD_label
            // 
            this.BelWeb_USD_label.AutoSize = true;
            this.BelWeb_USD_label.Location = new System.Drawing.Point(563, 90);
            this.BelWeb_USD_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BelWeb_USD_label.Name = "BelWeb_USD_label";
            this.BelWeb_USD_label.Size = new System.Drawing.Size(107, 20);
            this.BelWeb_USD_label.TabIndex = 2;
            this.BelWeb_USD_label.Text = "label_BelWeb";
            // 
            // nbrb_USD_label
            // 
            this.nbrb_USD_label.AutoSize = true;
            this.nbrb_USD_label.Location = new System.Drawing.Point(281, 90);
            this.nbrb_USD_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nbrb_USD_label.Name = "nbrb_USD_label";
            this.nbrb_USD_label.Size = new System.Drawing.Size(83, 20);
            this.nbrb_USD_label.TabIndex = 3;
            this.nbrb_USD_label.Text = "label_nbrb";
            // 
            // bb_USD_label
            // 
            this.bb_USD_label.AutoSize = true;
            this.bb_USD_label.Location = new System.Drawing.Point(862, 90);
            this.bb_USD_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bb_USD_label.Name = "bb_USD_label";
            this.bb_USD_label.Size = new System.Drawing.Size(73, 20);
            this.bb_USD_label.TabIndex = 4;
            this.bb_USD_label.Text = "label_BB";
            // 
            // nbrb_EUR_label
            // 
            this.nbrb_EUR_label.AutoSize = true;
            this.nbrb_EUR_label.Location = new System.Drawing.Point(281, 137);
            this.nbrb_EUR_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nbrb_EUR_label.Name = "nbrb_EUR_label";
            this.nbrb_EUR_label.Size = new System.Drawing.Size(83, 20);
            this.nbrb_EUR_label.TabIndex = 5;
            this.nbrb_EUR_label.Text = "label_nbrb";
            // 
            // nbrb_RUB_label
            // 
            this.nbrb_RUB_label.AutoSize = true;
            this.nbrb_RUB_label.Location = new System.Drawing.Point(281, 181);
            this.nbrb_RUB_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nbrb_RUB_label.Name = "nbrb_RUB_label";
            this.nbrb_RUB_label.Size = new System.Drawing.Size(83, 20);
            this.nbrb_RUB_label.TabIndex = 6;
            this.nbrb_RUB_label.Text = "label_nbrb";
            // 
            // nbrb_CNY_label
            // 
            this.nbrb_CNY_label.AutoSize = true;
            this.nbrb_CNY_label.Location = new System.Drawing.Point(281, 226);
            this.nbrb_CNY_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nbrb_CNY_label.Name = "nbrb_CNY_label";
            this.nbrb_CNY_label.Size = new System.Drawing.Size(83, 20);
            this.nbrb_CNY_label.TabIndex = 7;
            this.nbrb_CNY_label.Text = "label_nbrb";
            // 
            // nbrb_label
            // 
            this.nbrb_label.AutoSize = true;
            this.nbrb_label.Location = new System.Drawing.Point(281, 40);
            this.nbrb_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nbrb_label.Name = "nbrb_label";
            this.nbrb_label.Size = new System.Drawing.Size(53, 20);
            this.nbrb_label.TabIndex = 8;
            this.nbrb_label.Text = "НБРБ";
            // 
            // BelWeb_label
            // 
            this.BelWeb_label.AutoSize = true;
            this.BelWeb_label.Location = new System.Drawing.Point(563, 40);
            this.BelWeb_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BelWeb_label.Name = "BelWeb_label";
            this.BelWeb_label.Size = new System.Drawing.Size(68, 20);
            this.BelWeb_label.TabIndex = 9;
            this.BelWeb_label.Text = "БелВеб";
            // 
            // BelWeb_EUR_label
            // 
            this.BelWeb_EUR_label.AutoSize = true;
            this.BelWeb_EUR_label.Location = new System.Drawing.Point(563, 137);
            this.BelWeb_EUR_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BelWeb_EUR_label.Name = "BelWeb_EUR_label";
            this.BelWeb_EUR_label.Size = new System.Drawing.Size(107, 20);
            this.BelWeb_EUR_label.TabIndex = 10;
            this.BelWeb_EUR_label.Text = "label_BelWeb";
            // 
            // BelWeb_RUB_label
            // 
            this.BelWeb_RUB_label.AutoSize = true;
            this.BelWeb_RUB_label.Location = new System.Drawing.Point(563, 181);
            this.BelWeb_RUB_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BelWeb_RUB_label.Name = "BelWeb_RUB_label";
            this.BelWeb_RUB_label.Size = new System.Drawing.Size(107, 20);
            this.BelWeb_RUB_label.TabIndex = 11;
            this.BelWeb_RUB_label.Text = "label_BelWeb";
            // 
            // BelWeb_CNY_label
            // 
            this.BelWeb_CNY_label.AutoSize = true;
            this.BelWeb_CNY_label.Location = new System.Drawing.Point(563, 226);
            this.BelWeb_CNY_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BelWeb_CNY_label.Name = "BelWeb_CNY_label";
            this.BelWeb_CNY_label.Size = new System.Drawing.Size(107, 20);
            this.BelWeb_CNY_label.TabIndex = 12;
            this.BelWeb_CNY_label.Text = "label_BelWeb";
            // 
            // BB_label
            // 
            this.BB_label.AutoSize = true;
            this.BB_label.Location = new System.Drawing.Point(862, 40);
            this.BB_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BB_label.Name = "BB_label";
            this.BB_label.Size = new System.Drawing.Size(122, 20);
            this.BB_label.TabIndex = 13;
            this.BB_label.Text = "Беларусь Банк";
            // 
            // bb_EUR_label
            // 
            this.bb_EUR_label.AutoSize = true;
            this.bb_EUR_label.Location = new System.Drawing.Point(862, 137);
            this.bb_EUR_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bb_EUR_label.Name = "bb_EUR_label";
            this.bb_EUR_label.Size = new System.Drawing.Size(73, 20);
            this.bb_EUR_label.TabIndex = 14;
            this.bb_EUR_label.Text = "label_BB";
            // 
            // bb_RUB_label
            // 
            this.bb_RUB_label.AutoSize = true;
            this.bb_RUB_label.Location = new System.Drawing.Point(862, 181);
            this.bb_RUB_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bb_RUB_label.Name = "bb_RUB_label";
            this.bb_RUB_label.Size = new System.Drawing.Size(73, 20);
            this.bb_RUB_label.TabIndex = 15;
            this.bb_RUB_label.Text = "label_BB";
            // 
            // bb_CNY_label
            // 
            this.bb_CNY_label.AutoSize = true;
            this.bb_CNY_label.Location = new System.Drawing.Point(862, 226);
            this.bb_CNY_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bb_CNY_label.Name = "bb_CNY_label";
            this.bb_CNY_label.Size = new System.Drawing.Size(73, 20);
            this.bb_CNY_label.TabIndex = 16;
            this.bb_CNY_label.Text = "label_BB";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chart1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1080, 334);
            this.panel4.TabIndex = 0;
            // 
            // chart1
            // 
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1080, 334);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title3.Name = "Курс валют";
            this.chart1.Titles.Add(title3);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(989, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Неделя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(898, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Месяц";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(807, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "Год";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1200, 640);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.bb_CNY_label);
            this.Controls.Add(this.bb_RUB_label);
            this.Controls.Add(this.bb_EUR_label);
            this.Controls.Add(this.BB_label);
            this.Controls.Add(this.BelWeb_CNY_label);
            this.Controls.Add(this.BelWeb_RUB_label);
            this.Controls.Add(this.BelWeb_EUR_label);
            this.Controls.Add(this.BelWeb_label);
            this.Controls.Add(this.nbrb_label);
            this.Controls.Add(this.nbrb_CNY_label);
            this.Controls.Add(this.nbrb_RUB_label);
            this.Controls.Add(this.nbrb_EUR_label);
            this.Controls.Add(this.bb_USD_label);
            this.Controls.Add(this.nbrb_USD_label);
            this.Controls.Add(this.BelWeb_USD_label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label BelWeb_USD_label;
        private System.Windows.Forms.Label nbrb_USD_label;
        private System.Windows.Forms.Label bb_USD_label;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_map;
        private System.Windows.Forms.Button button_kyrs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nbrb_EUR_label;
        private System.Windows.Forms.Label nbrb_RUB_label;
        private System.Windows.Forms.Label nbrb_CNY_label;
        private System.Windows.Forms.Label nbrb_label;
        private System.Windows.Forms.Label BelWeb_label;
        private System.Windows.Forms.Label BelWeb_EUR_label;
        private System.Windows.Forms.Label BelWeb_RUB_label;
        private System.Windows.Forms.Label BelWeb_CNY_label;
        private System.Windows.Forms.Label BB_label;
        private System.Windows.Forms.Label bb_EUR_label;
        private System.Windows.Forms.Label bb_RUB_label;
        private System.Windows.Forms.Label bb_CNY_label;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

