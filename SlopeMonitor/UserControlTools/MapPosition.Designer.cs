
namespace SlopeMonitor.UserControlTools
{
    partial class MapPosition
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anglex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angley = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anglez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyrox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyroy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyroz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(217, 0);
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
            this.gMapControl1.Size = new System.Drawing.Size(523, 356);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accx,
            this.magx,
            this.magy,
            this.magz,
            this.temperature,
            this.humidity,
            this.anglex,
            this.angley,
            this.anglez,
            this.gyrox,
            this.gyroy,
            this.gyroz,
            this.accy,
            this.accz});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(216, 416);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // accx
            // 
            this.accx.HeaderText = "accx";
            this.accx.Name = "accx";
            // 
            // magx
            // 
            this.magx.HeaderText = "magx";
            this.magx.Name = "magx";
            // 
            // magy
            // 
            this.magy.HeaderText = "magy";
            this.magy.Name = "magy";
            // 
            // magz
            // 
            this.magz.HeaderText = "magz";
            this.magz.Name = "magz";
            // 
            // temperature
            // 
            this.temperature.HeaderText = "temperature";
            this.temperature.Name = "temperature";
            // 
            // humidity
            // 
            this.humidity.HeaderText = "humidity";
            this.humidity.Name = "humidity";
            // 
            // anglex
            // 
            this.anglex.HeaderText = "anglex";
            this.anglex.Name = "anglex";
            // 
            // angley
            // 
            this.angley.HeaderText = "angley";
            this.angley.Name = "angley";
            // 
            // anglez
            // 
            this.anglez.HeaderText = "anglez";
            this.anglez.Name = "anglez";
            // 
            // gyrox
            // 
            this.gyrox.HeaderText = "gyrox";
            this.gyrox.Name = "gyrox";
            // 
            // gyroy
            // 
            this.gyroy.HeaderText = "gyroy";
            this.gyroy.Name = "gyroy";
            // 
            // gyroz
            // 
            this.gyroz.HeaderText = "gyroz";
            this.gyroz.Name = "gyroz";
            // 
            // accy
            // 
            this.accy.HeaderText = "accy";
            this.accy.Name = "accy";
            // 
            // accz
            // 
            this.accz.HeaderText = "accz";
            this.accz.Name = "accz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select sensor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sensor position";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 362);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 21);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(416, 392);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 21);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(357, 392);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(44, 21);
            this.textBox3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(483, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add to map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(596, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add point";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(648, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 24);
            this.button3.TabIndex = 9;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(596, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 24);
            this.button4.TabIndex = 10;
            this.button4.Text = "Load";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MapPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gMapControl1);
            this.Name = "MapPosition";
            this.Size = new System.Drawing.Size(740, 416);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accx;
        private System.Windows.Forms.DataGridViewTextBoxColumn magx;
        private System.Windows.Forms.DataGridViewTextBoxColumn magy;
        private System.Windows.Forms.DataGridViewTextBoxColumn magz;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn anglex;
        private System.Windows.Forms.DataGridViewTextBoxColumn angley;
        private System.Windows.Forms.DataGridViewTextBoxColumn anglez;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyrox;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyroy;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyroz;
        private System.Windows.Forms.DataGridViewTextBoxColumn accy;
        private System.Windows.Forms.DataGridViewTextBoxColumn accz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
