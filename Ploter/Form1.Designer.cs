namespace Ploter
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PlotItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CircleItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RectItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LinePlotItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PenSetItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineWidthItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PenWidthItem = new System.Windows.Forms.ToolStripComboBox();
            this.AboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.PenColorStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.MousePositionItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.Plotlabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlotItem,
            this.SetItem,
            this.AboutItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PlotItem
            // 
            this.PlotItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CircleItem,
            this.RectItem,
            this.LinePlotItem});
            this.PlotItem.Name = "PlotItem";
            this.PlotItem.Size = new System.Drawing.Size(71, 24);
            this.PlotItem.Text = "Plot(&P)";
            // 
            // CircleItem
            // 
            this.CircleItem.Name = "CircleItem";
            this.CircleItem.Size = new System.Drawing.Size(224, 26);
            this.CircleItem.Text = "Circle";
            this.CircleItem.Click += new System.EventHandler(this.CircleItem_Click);
            // 
            // RectItem
            // 
            this.RectItem.Name = "RectItem";
            this.RectItem.Size = new System.Drawing.Size(224, 26);
            this.RectItem.Text = "Rectangle";
            this.RectItem.Click += new System.EventHandler(this.RectItem_Click);
            // 
            // LinePlotItem
            // 
            this.LinePlotItem.Name = "LinePlotItem";
            this.LinePlotItem.Size = new System.Drawing.Size(224, 26);
            this.LinePlotItem.Text = "Line";
            this.LinePlotItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click_1);
            // 
            // SetItem
            // 
            this.SetItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PenSetItem});
            this.SetItem.Name = "SetItem";
            this.SetItem.Size = new System.Drawing.Size(95, 24);
            this.SetItem.Text = "Setting(&S)";
            // 
            // PenSetItem
            // 
            this.PenSetItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.LineWidthItem});
            this.PenSetItem.Name = "PenSetItem";
            this.PenSetItem.Size = new System.Drawing.Size(224, 26);
            this.PenSetItem.Text = "Pen";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // LineWidthItem
            // 
            this.LineWidthItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PenWidthItem});
            this.LineWidthItem.Name = "LineWidthItem";
            this.LineWidthItem.Size = new System.Drawing.Size(224, 26);
            this.LineWidthItem.Text = "LineWidth";
            this.LineWidthItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // PenWidthItem
            // 
            this.PenWidthItem.Name = "PenWidthItem";
            this.PenWidthItem.Size = new System.Drawing.Size(121, 28);
            // 
            // AboutItem
            // 
            this.AboutItem.Name = "AboutItem";
            this.AboutItem.Size = new System.Drawing.Size(90, 24);
            this.AboutItem.Text = "About(&A)";
            this.AboutItem.Click += new System.EventHandler(this.AboutItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(26, 422);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PenColorStatus,
            this.MousePositionItem});
            this.statusStrip1.Location = new System.Drawing.Point(26, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(774, 26);
            this.statusStrip1.TabIndex = 2;
            // 
            // PenColorStatus
            // 
            this.PenColorStatus.LinkColor = System.Drawing.Color.Red;
            this.PenColorStatus.Name = "PenColorStatus";
            this.PenColorStatus.Size = new System.Drawing.Size(145, 20);
            this.PenColorStatus.Text = "Pen Color:255 0 0  ";
            // 
            // MousePositionItem
            // 
            this.MousePositionItem.Name = "MousePositionItem";
            this.MousePositionItem.Size = new System.Drawing.Size(148, 20);
            this.MousePositionItem.Text = "MousePosition:0, 0";
            // 
            // Plotlabel
            // 
            this.Plotlabel.BackColor = System.Drawing.Color.White;
            this.Plotlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plotlabel.Location = new System.Drawing.Point(26, 28);
            this.Plotlabel.Name = "Plotlabel";
            this.Plotlabel.Size = new System.Drawing.Size(774, 396);
            this.Plotlabel.TabIndex = 3;
            this.Plotlabel.Paint += new System.Windows.Forms.PaintEventHandler(this.Plotlabel_Paint);
            this.Plotlabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Plotlabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Plotlabel_MouseMove);
            this.Plotlabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Plotlabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Plot";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutItem;
        private System.Windows.Forms.ToolStripMenuItem PlotItem;
        private System.Windows.Forms.ToolStripMenuItem CircleItem;
        private System.Windows.Forms.ToolStripMenuItem RectItem;
        private System.Windows.Forms.ToolStripMenuItem SetItem;
        private System.Windows.Forms.ToolStripMenuItem PenSetItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LineWidthItem;
        private System.Windows.Forms.ToolStripComboBox PenWidthItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel PenColorStatus;
        private System.Windows.Forms.Label Plotlabel;
        private System.Windows.Forms.ToolStripStatusLabel MousePositionItem;
        private System.Windows.Forms.ToolStripMenuItem LinePlotItem;
    }
}

