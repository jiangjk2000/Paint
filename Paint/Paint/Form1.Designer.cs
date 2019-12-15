namespace Paint
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CircleItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RectItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.penToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fillItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.PenColorStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.MousePointStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ComboBoxLineWidth = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(4, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1104, 485);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.plotPToolStripMenuItem,
            this.aboutAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 32);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNToolStripMenuItem,
            this.openOToolStripMenuItem,
            this.saveSToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitEToolStripMenuItem});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fileFToolStripMenuItem.Text = "File(&F)";
            // 
            // newNToolStripMenuItem
            // 
            this.newNToolStripMenuItem.Name = "newNToolStripMenuItem";
            this.newNToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newNToolStripMenuItem.Text = "New(&N)";
            this.newNToolStripMenuItem.Click += new System.EventHandler(this.newNToolStripMenuItem_Click);
            // 
            // openOToolStripMenuItem
            // 
            this.openOToolStripMenuItem.Name = "openOToolStripMenuItem";
            this.openOToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openOToolStripMenuItem.Text = "Open(&O)";
            this.openOToolStripMenuItem.Click += new System.EventHandler(this.openOToolStripMenuItem_Click);
            // 
            // saveSToolStripMenuItem
            // 
            this.saveSToolStripMenuItem.Name = "saveSToolStripMenuItem";
            this.saveSToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveSToolStripMenuItem.Text = "Save(&S)";
            this.saveSToolStripMenuItem.Click += new System.EventHandler(this.saveSToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitEToolStripMenuItem
            // 
            this.exitEToolStripMenuItem.Name = "exitEToolStripMenuItem";
            this.exitEToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitEToolStripMenuItem.Text = "Exit(&E)";
            this.exitEToolStripMenuItem.Click += new System.EventHandler(this.exitEToolStripMenuItem_Click);
            // 
            // plotPToolStripMenuItem
            // 
            this.plotPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CircleItem,
            this.RectItem,
            this.LineItem,
            this.clearCToolStripMenuItem,
            this.toolStripSeparator1,
            this.penToolStripMenuItem,
            this.toolStripSeparator2,
            this.fillItem,
            this.edgeItem});
            this.plotPToolStripMenuItem.Name = "plotPToolStripMenuItem";
            this.plotPToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.plotPToolStripMenuItem.Text = "Plot(&P)";
            // 
            // CircleItem
            // 
            this.CircleItem.Name = "CircleItem";
            this.CircleItem.Size = new System.Drawing.Size(185, 26);
            this.CircleItem.Text = "Elipse(&E)";
            this.CircleItem.Click += new System.EventHandler(this.CircleItem_Click);
            // 
            // RectItem
            // 
            this.RectItem.Name = "RectItem";
            this.RectItem.Size = new System.Drawing.Size(185, 26);
            this.RectItem.Text = "Rectangle(&R)";
            this.RectItem.Click += new System.EventHandler(this.RectItem_Click);
            // 
            // LineItem
            // 
            this.LineItem.Name = "LineItem";
            this.LineItem.Size = new System.Drawing.Size(185, 26);
            this.LineItem.Text = "Line(&L)";
            this.LineItem.Click += new System.EventHandler(this.LineItem_Click);
            // 
            // clearCToolStripMenuItem
            // 
            this.clearCToolStripMenuItem.Name = "clearCToolStripMenuItem";
            this.clearCToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.clearCToolStripMenuItem.Text = "Clear(&C)";
            this.clearCToolStripMenuItem.Click += new System.EventHandler(this.clearCToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // penToolStripMenuItem
            // 
            this.penToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem});
            this.penToolStripMenuItem.Name = "penToolStripMenuItem";
            this.penToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.penToolStripMenuItem.Text = "Pen(&P)";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // fillItem
            // 
            this.fillItem.Name = "fillItem";
            this.fillItem.Size = new System.Drawing.Size(185, 26);
            this.fillItem.Text = "Fill(&F)";
            this.fillItem.Click += new System.EventHandler(this.fillFToolStripMenuItem_Click);
            // 
            // edgeItem
            // 
            this.edgeItem.Name = "edgeItem";
            this.edgeItem.Size = new System.Drawing.Size(185, 26);
            this.edgeItem.Text = "Edge(&E)";
            this.edgeItem.Click += new System.EventHandler(this.edgeEToolStripMenuItem_Click);
            // 
            // aboutAToolStripMenuItem
            // 
            this.aboutAToolStripMenuItem.Name = "aboutAToolStripMenuItem";
            this.aboutAToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.aboutAToolStripMenuItem.Text = "About(&A)";
            this.aboutAToolStripMenuItem.Click += new System.EventHandler(this.aboutAToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PenColorStatus,
            this.MousePointStatus});
            this.statusStrip1.Location = new System.Drawing.Point(4, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1104, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // PenColorStatus
            // 
            this.PenColorStatus.Name = "PenColorStatus";
            this.PenColorStatus.Size = new System.Drawing.Size(145, 20);
            this.PenColorStatus.Text = "Pen Color:255, 0, 0";
            // 
            // MousePointStatus
            // 
            this.MousePointStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MousePointStatus.Margin = new System.Windows.Forms.Padding(350, 4, 0, 2);
            this.MousePointStatus.Name = "MousePointStatus";
            this.MousePointStatus.Size = new System.Drawing.Size(116, 20);
            this.MousePointStatus.Text = "Position:0, 0px";
            this.MousePointStatus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.ComboBoxLineWidth});
            this.toolStrip1.Location = new System.Drawing.Point(4, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1104, 28);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(83, 25);
            this.toolStripLabel1.Text = "LineWidth";
            // 
            // ComboBoxLineWidth
            // 
            this.ComboBoxLineWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.ComboBoxLineWidth.Name = "ComboBoxLineWidth";
            this.ComboBoxLineWidth.Size = new System.Drawing.Size(121, 28);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 549);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem plotPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CircleItem;
        private System.Windows.Forms.ToolStripMenuItem RectItem;
        private System.Windows.Forms.ToolStripMenuItem LineItem;
        private System.Windows.Forms.ToolStripStatusLabel PenColorStatus;
        private System.Windows.Forms.ToolStripStatusLabel MousePointStatus;
        private System.Windows.Forms.ToolStripMenuItem newNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem penToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox ComboBoxLineWidth;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fillItem;
        private System.Windows.Forms.ToolStripMenuItem edgeItem;
    }
}

