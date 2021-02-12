
namespace Nearest_Neighbors
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.x = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.z = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.Button();
            this.revenueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.SportoSakaTxt = new System.Windows.Forms.TextBox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SvorisTxt = new System.Windows.Forms.TextBox();
            this.PozicijaTxt = new System.Windows.Forms.TextBox();
            this.UgisTxt = new System.Windows.Forms.TextBox();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.point2DBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.point2DBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.x,
            this.y,
            this.z,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(45, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(531, 238);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // x
            // 
            this.x.Tag = "";
            this.x.Text = "Ūgis";
            this.x.Width = 85;
            // 
            // y
            // 
            this.y.Text = "Svoris";
            this.y.Width = 103;
            // 
            // z
            // 
            this.z.Text = "Sporto šaka";
            this.z.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pozicija";
            this.columnHeader4.Width = 116;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 77);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gauti „Mokymo Imtis“ iš „MySQL“";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mokymo Imtis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Objektai Klasifikavimui";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(46, 402);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(530, 154);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            this.listView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "Ūgis";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Svoris";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sporto Šaka";
            this.columnHeader3.Width = 141;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Pozicija";
            this.columnHeader5.Width = 133;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 562);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 77);
            this.button2.TabIndex = 5;
            this.button2.Text = "Objektu Klasifikavimas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(1574, 42);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(259, 204);
            this.listBox2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1266, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "7 Objekto Rezultatai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1570, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "8 Objekto Rezultatai";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(610, 297);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(637, 342);
            this.cartesianChart1.TabIndex = 12;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(606, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(469, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = " Math.Sqrt(((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)))";
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 25;
            this.listBox3.Location = new System.Drawing.Point(1270, 506);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(568, 129);
            this.listBox3.TabIndex = 15;
            // 
            // listBox4
            // 
            this.listBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 20;
            this.listBox4.Location = new System.Drawing.Point(1270, 301);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(259, 184);
            this.listBox4.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1266, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Pagal k-NN e7 Objekto Z = ";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(1270, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 204);
            this.listBox1.TabIndex = 19;
            // 
            // listBox6
            // 
            this.listBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 20;
            this.listBox6.Location = new System.Drawing.Point(1574, 301);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(259, 184);
            this.listBox6.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1570, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Pagal k-NN e8 Objekto Z = ";
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(263, 562);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(128, 77);
            this.Display.TabIndex = 22;
            this.Display.Text = "Atvaizduoti";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // revenueBindingSource1
            // 
            this.revenueBindingSource1.CurrentChanged += new System.EventHandler(this.revenueBindingSource1_CurrentChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(485, 361);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 35);
            this.button6.TabIndex = 26;
            this.button6.Text = "Pakeisti";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // SportoSakaTxt
            // 
            this.SportoSakaTxt.Location = new System.Drawing.Point(263, 361);
            this.SportoSakaTxt.Multiline = true;
            this.SportoSakaTxt.Name = "SportoSakaTxt";
            this.SportoSakaTxt.Size = new System.Drawing.Size(105, 35);
            this.SportoSakaTxt.TabIndex = 27;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(594, 53);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(322, 238);
            this.listView3.TabIndex = 28;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Tag = "";
            this.columnHeader6.Text = "Ūgis";
            this.columnHeader6.Width = 85;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Svoris";
            this.columnHeader7.Width = 103;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Sporto šaka";
            this.columnHeader8.Width = 128;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Pozicija";
            this.columnHeader9.Width = 116;
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listView4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(922, 53);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(325, 238);
            this.listView4.TabIndex = 29;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Tag = "";
            this.columnHeader10.Text = "Ūgis";
            this.columnHeader10.Width = 85;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Svoris";
            this.columnHeader11.Width = 103;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Sporto šaka";
            this.columnHeader12.Width = 128;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Pozicija";
            this.columnHeader13.Width = 116;
            // 
            // SvorisTxt
            // 
            this.SvorisTxt.Location = new System.Drawing.Point(152, 361);
            this.SvorisTxt.Multiline = true;
            this.SvorisTxt.Name = "SvorisTxt";
            this.SvorisTxt.Size = new System.Drawing.Size(105, 35);
            this.SvorisTxt.TabIndex = 30;
            // 
            // PozicijaTxt
            // 
            this.PozicijaTxt.Location = new System.Drawing.Point(374, 361);
            this.PozicijaTxt.Multiline = true;
            this.PozicijaTxt.Name = "PozicijaTxt";
            this.PozicijaTxt.Size = new System.Drawing.Size(105, 35);
            this.PozicijaTxt.TabIndex = 31;
            // 
            // UgisTxt
            // 
            this.UgisTxt.Location = new System.Drawing.Point(41, 361);
            this.UgisTxt.Multiline = true;
            this.UgisTxt.Name = "UgisTxt";
            this.UgisTxt.Size = new System.Drawing.Size(105, 35);
            this.UgisTxt.TabIndex = 32;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // point2DBindingSource
            // 
            this.point2DBindingSource.DataSource = typeof(Nearest_Neighbors.Point2D);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1850, 676);
            this.Controls.Add(this.UgisTxt);
            this.Controls.Add(this.PozicijaTxt);
            this.Controls.Add(this.SvorisTxt);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.SportoSakaTxt);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Objektų Klasifikavimas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.point2DBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader x;
        private System.Windows.Forms.ColumnHeader y;
        private System.Windows.Forms.ColumnHeader z;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource point2DBindingSource;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.BindingSource revenueBindingSource1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox SportoSakaTxt;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        public System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TextBox SvorisTxt;
        private System.Windows.Forms.TextBox PozicijaTxt;
        private System.Windows.Forms.TextBox UgisTxt;
        public System.Windows.Forms.ColumnHeader Id;
    }
}

