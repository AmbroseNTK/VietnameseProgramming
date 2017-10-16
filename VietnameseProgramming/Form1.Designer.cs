namespace VietnameseProgramming
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
            this.lbApplicationName = new System.Windows.Forms.Label();
            this.picIco = new System.Windows.Forms.PictureBox();
            this.TopDock = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbFunction = new System.Windows.Forms.TextBox();
            this.tbNativeCode = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbCPP = new System.Windows.Forms.RichTextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colExpression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colBreakpoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picIco)).BeginInit();
            this.TopDock.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbApplicationName
            // 
            this.lbApplicationName.AutoSize = true;
            this.lbApplicationName.BackColor = System.Drawing.Color.Orange;
            this.lbApplicationName.Font = new System.Drawing.Font("Myriad Hebrew", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbApplicationName.Location = new System.Drawing.Point(34, 6);
            this.lbApplicationName.Name = "lbApplicationName";
            this.lbApplicationName.Size = new System.Drawing.Size(103, 19);
            this.lbApplicationName.TabIndex = 1;
            this.lbApplicationName.Text = "Windows Title";
            // 
            // picIco
            // 
            this.picIco.BackColor = System.Drawing.Color.Transparent;
            this.picIco.Location = new System.Drawing.Point(3, 3);
            this.picIco.Name = "picIco";
            this.picIco.Size = new System.Drawing.Size(25, 25);
            this.picIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIco.TabIndex = 4;
            this.picIco.TabStop = false;
            // 
            // TopDock
            // 
            this.TopDock.BackColor = System.Drawing.Color.Orange;
            this.TopDock.Controls.Add(this.picIco);
            this.TopDock.Controls.Add(this.panel2);
            this.TopDock.Controls.Add(this.lbApplicationName);
            this.TopDock.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopDock.Location = new System.Drawing.Point(0, 0);
            this.TopDock.Name = "TopDock";
            this.TopDock.Size = new System.Drawing.Size(1050, 36);
            this.TopDock.TabIndex = 7;
            this.TopDock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopDock_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.tbFunction);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(629, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 36);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VietnameseProgramming.Properties.Resources.math_27248_640;
            this.pictureBox1.InitialImage = global::VietnameseProgramming.Properties.Resources.math_27248_640;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tbFunction
            // 
            this.tbFunction.BackColor = System.Drawing.Color.Orange;
            this.tbFunction.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFunction.Location = new System.Drawing.Point(39, 6);
            this.tbFunction.Name = "tbFunction";
            this.tbFunction.Size = new System.Drawing.Size(379, 27);
            this.tbFunction.TabIndex = 0;
            this.tbFunction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFunction_KeyDown);
            // 
            // tbNativeCode
            // 
            this.tbNativeCode.BackColor = System.Drawing.SystemColors.Window;
            this.tbNativeCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNativeCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNativeCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNativeCode.ForeColor = System.Drawing.Color.DimGray;
            this.tbNativeCode.Location = new System.Drawing.Point(0, 0);
            this.tbNativeCode.Name = "tbNativeCode";
            this.tbNativeCode.Size = new System.Drawing.Size(658, 547);
            this.tbNativeCode.TabIndex = 8;
            this.tbNativeCode.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 36);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbNativeCode);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1050, 549);
            this.splitContainer1.SplitterDistance = 660;
            this.splitContainer1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tbCPP);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(384, 547);
            this.splitContainer2.SplitterDistance = 436;
            this.splitContainer2.TabIndex = 0;
            // 
            // tbCPP
            // 
            this.tbCPP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCPP.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbCPP.Location = new System.Drawing.Point(0, 0);
            this.tbCPP.Name = "tbCPP";
            this.tbCPP.ReadOnly = true;
            this.tbCPP.Size = new System.Drawing.Size(384, 436);
            this.tbCPP.TabIndex = 0;
            this.tbCPP.Text = "";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer3.Size = new System.Drawing.Size(384, 107);
            this.splitContainer3.SplitterDistance = 127;
            this.splitContainer3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExpression,
            this.colValue,
            this.colDelete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(127, 107);
            this.dataGridView1.TabIndex = 0;
            // 
            // colExpression
            // 
            this.colExpression.Frozen = true;
            this.colExpression.HeaderText = "Biểu thức";
            this.colExpression.Name = "colExpression";
            // 
            // colValue
            // 
            this.colValue.Frozen = true;
            this.colValue.HeaderText = "Giá trị";
            this.colValue.Name = "colValue";
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Xóa";
            this.colDelete.Name = "colDelete";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBreakpoint,
            this.colCondition,
            this.btActive,
            this.btDelete});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(253, 107);
            this.dataGridView2.TabIndex = 0;
            // 
            // colBreakpoint
            // 
            this.colBreakpoint.HeaderText = "Điểm ngắt (Breakpoint)";
            this.colBreakpoint.Name = "colBreakpoint";
            // 
            // colCondition
            // 
            this.colCondition.HeaderText = "Điều kiện";
            this.colCondition.Name = "colCondition";
            // 
            // btActive
            // 
            this.btActive.HeaderText = "Kích hoạt";
            this.btActive.Name = "btActive";
            // 
            // btDelete
            // 
            this.btDelete.HeaderText = "Xóa";
            this.btDelete.Name = "btDelete";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1050, 585);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.TopDock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Vietnamese Programming IDE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIco)).EndInit();
            this.TopDock.ResumeLayout(false);
            this.TopDock.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbApplicationName;
        private System.Windows.Forms.PictureBox picIco;
        private System.Windows.Forms.Panel TopDock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox tbNativeCode;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox tbCPP;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpression;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBreakpoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCondition;
        private System.Windows.Forms.DataGridViewCheckBoxColumn btActive;
        private System.Windows.Forms.DataGridViewButtonColumn btDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbFunction;
    }
}

