
namespace SlopeMonitor.UserControlTools.VisulizationTool
{
    partial class DataGridViewSetTool
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyroX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyroY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyroZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angleX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angleY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angleZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 356);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accX,
            this.accY,
            this.accZ,
            this.gyroX,
            this.gyroY,
            this.gyroZ,
            this.angleX,
            this.angleY,
            this.angleZ,
            this.magX,
            this.magY,
            this.magZ,
            this.temperature,
            this.humidity});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(552, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // accX
            // 
            this.accX.HeaderText = "accX";
            this.accX.Name = "accX";
            // 
            // accY
            // 
            this.accY.HeaderText = "accY";
            this.accY.Name = "accY";
            // 
            // accZ
            // 
            this.accZ.HeaderText = "accZ";
            this.accZ.Name = "accZ";
            // 
            // gyroX
            // 
            this.gyroX.HeaderText = "gyroX";
            this.gyroX.Name = "gyroX";
            // 
            // gyroY
            // 
            this.gyroY.HeaderText = "gyroY";
            this.gyroY.Name = "gyroY";
            // 
            // gyroZ
            // 
            this.gyroZ.HeaderText = "gyroZ";
            this.gyroZ.Name = "gyroZ";
            // 
            // angleX
            // 
            this.angleX.HeaderText = "angleX";
            this.angleX.Name = "angleX";
            // 
            // angleY
            // 
            this.angleY.HeaderText = "angleY";
            this.angleY.Name = "angleY";
            // 
            // angleZ
            // 
            this.angleZ.HeaderText = "angleZ";
            this.angleZ.Name = "angleZ";
            // 
            // magX
            // 
            this.magX.HeaderText = "magX";
            this.magX.Name = "magX";
            // 
            // magY
            // 
            this.magY.HeaderText = "magY";
            this.magY.Name = "magY";
            // 
            // magZ
            // 
            this.magZ.HeaderText = "magZ";
            this.magZ.Name = "magZ";
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
            // DataGridViewSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "DataGridViewSet";
            this.Size = new System.Drawing.Size(555, 356);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accX;
        private System.Windows.Forms.DataGridViewTextBoxColumn accY;
        private System.Windows.Forms.DataGridViewTextBoxColumn accZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyroX;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyroY;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyroZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn angleX;
        private System.Windows.Forms.DataGridViewTextBoxColumn angleY;
        private System.Windows.Forms.DataGridViewTextBoxColumn angleZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn magX;
        private System.Windows.Forms.DataGridViewTextBoxColumn magY;
        private System.Windows.Forms.DataGridViewTextBoxColumn magZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidity;
    }
}
