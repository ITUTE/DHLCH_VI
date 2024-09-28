namespace FIT_Random
{
    partial class FrmDS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDS));
            this.pnShow = new System.Windows.Forms.FlowLayoutPanel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnTool = new System.Windows.Forms.Panel();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbSelectAll = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnTop.SuspendLayout();
            this.pnTool.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnShow
            // 
            this.pnShow.AutoScroll = true;
            this.pnShow.AutoSize = true;
            this.pnShow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnShow.BackgroundImage = global::FIT_Random.Properties.Resources.bg_1920x1080;
            this.pnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnShow.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnShow.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.pnShow.Location = new System.Drawing.Point(0, 172);
            this.pnShow.Name = "pnShow";
            this.pnShow.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnShow.Size = new System.Drawing.Size(1386, 545);
            this.pnShow.TabIndex = 10;
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.label2);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Font = new System.Drawing.Font("Segoe UI Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1386, 128);
            this.pnTop.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SandyBrown;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1386, 128);
            this.label2.TabIndex = 6;
            this.label2.Text = "DANH SÁCH ĐẠI BIỂU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTool
            // 
            this.pnTool.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnTool.Controls.Add(this.txtMax);
            this.pnTool.Controls.Add(this.label1);
            this.pnTool.Controls.Add(this.ckbSelectAll);
            this.pnTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTool.Location = new System.Drawing.Point(0, 128);
            this.pnTool.Name = "pnTool";
            this.pnTool.Size = new System.Drawing.Size(1386, 44);
            this.pnTool.TabIndex = 8;
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.SystemColors.Control;
            this.txtMax.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtMax.Location = new System.Drawing.Point(188, 0);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 41);
            this.txtMax.TabIndex = 6;
            this.txtMax.Text = "50";
            this.txtMax.TextChanged += new System.EventHandler(this.txtMax_TextChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số lượng tối đa:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ckbSelectAll
            // 
            this.ckbSelectAll.Checked = true;
            this.ckbSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSelectAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.ckbSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ckbSelectAll.Location = new System.Drawing.Point(1186, 0);
            this.ckbSelectAll.Name = "ckbSelectAll";
            this.ckbSelectAll.Size = new System.Drawing.Size(200, 44);
            this.ckbSelectAll.TabIndex = 0;
            this.ckbSelectAll.Text = "Hủy chọn tất cả  ";
            this.ckbSelectAll.UseVisualStyleBackColor = true;
            this.ckbSelectAll.CheckedChanged += new System.EventHandler(this.ckbSelectAll_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33555F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel1.Controls.Add(this.btnStart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 717);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1386, 71);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.PowderBlue;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.Crimson;
            this.btnStart.Location = new System.Drawing.Point(464, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(456, 65);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "<<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pnShow);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnTool);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnTop.ResumeLayout(false);
            this.pnTool.ResumeLayout(false);
            this.pnTool.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnShow;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnTool;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbSelectAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button2;
    }
}