using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CCWin;

namespace Paint
{
    public partial class Form1 : Skin_Mac

    {
        public bool IsDown { get; set; }
        public List<Shape> Shapes = new List<Shape>();
        public Shape Cur { get; set; }
        public string FileName { get; set; }
        private Pen pen = new Pen(Color.Red);
        private int PaintStatus;

        public Form1()
        {
            InitializeComponent();
            edgeItem.Checked = true;
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            IsDown = true;
            Cur = new Shape { Start = e.Location };
            if (CircleItem.Checked)
            {
                Cur = new Circle { Start = e.Location };
            }
            if (RectItem.Checked)
            {
                Cur = new Rect { Start = e.Location };
            }
            if (LineItem.Checked)
            {
                Cur = new Line { Start = e.Location };
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            IsDown = false;
            Cur.End = e.Location;
            Cur.Pen.Color = pen.Color;
            Cur.Pen.Width = int.Parse(ComboBoxLineWidth.Text);
            Cur.PaintStatus = PaintStatus;
            Shapes.Add(Cur);
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            MousePointStatus.Text = String.Format($"Position:{e.X}, {e.Y}");
            if (IsDown)
            {
                var cPos = e.Location;
                Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(b);
                Cur.End = e.Location;
                Cur.PaintStatus = PaintStatus;
                foreach (var item in Shapes)
                {
                    PaintShape(g, item.Pen, item);
                }
                if (ComboBoxLineWidth.Text == "")
                {
                    ComboBoxLineWidth.Text = "1";
                }
                pen.Width = int.Parse(ComboBoxLineWidth.Text);
                PaintShape(g, pen, Cur);
                pictureBox1.BackgroundImage = b;
                g.Dispose();
            }

        }
        private void aboutAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        public void PaintShape(Graphics g, Pen pen, Shape s)
        {
            var sPos = s.Start;
            var ePos = s.End;
            if (s.Start.X > s.End.X)
            {
                ePos.X = s.Start.X;
                sPos.X = s.End.X;
            }
            if (s.Start.Y > s.End.Y)
            {
                ePos.Y = s.Start.Y;
                sPos.Y = s.End.Y;
            }
            Size size = new Size(Math.Abs(sPos.X - ePos.X), Math.Abs(sPos.Y - ePos.Y));
            if (s is Circle)
            {
                Rectangle rect = new Rectangle(sPos, size);
                if (s.PaintStatus == 0)
                {
                    g.DrawEllipse(pen, rect);
                }
                if (s.PaintStatus == 1)
                {
                    SolidBrush solidBrush = new SolidBrush(pen.Color);
                    g.FillEllipse(solidBrush, rect);
                }
            }
            else if (s is Rect)
            {
                if (s.PaintStatus == 0)
                {
                    g.DrawRectangle(pen, new Rectangle(sPos, size));
                }
                if (s.PaintStatus == 1)
                {
                    SolidBrush solidBrush = new SolidBrush(pen.Color);
                    g.FillRectangle(solidBrush, new Rectangle(sPos, size));
                }
                
            }
            else if (s is Line)
            {
                g.DrawLine(pen, s.Start, s.End);
            }
            //else
            //{
            //    Image image = Image.FromFile(@"C:\Users\Jjk\Desktop\Source\Visual Studio\.NET Console\NotePad\WindowsFormsApp1\1.jpg");
            //    g.DrawImage(image,ePos);
            //}
        }
        public void SingleCheckToolStripMenu(object sender)
        {
            CircleItem.Checked = false;
            RectItem.Checked = false;
            LineItem.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;
        }
        private void CircleItem_Click(object sender, EventArgs e)
        {
            SingleCheckToolStripMenu(sender);
        }
        private void RectItem_Click(object sender, EventArgs e)
        {
            SingleCheckToolStripMenu(sender);
        }
        private void LineItem_Click(object sender, EventArgs e)
        {
            SingleCheckToolStripMenu(sender);
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }
        private void openOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*|jpg";
            ofd.FileName = "";
            ofd.DefaultExt = "jpg";
            ofd.AddExtension = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(ofd.FileName);
                pictureBox1.BackgroundImage = bitmap;
            }
            FileName = ofd.FileName;
        }
        private void newNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackgroundImage != null)
            {
                DialogResult result = MessageBox.Show("Do you want to save this picture?", "Paint", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveAs();
                }
                if (result == DialogResult.No)
                {
                    pictureBox1.BackgroundImage = null;
                    Shapes.Clear();
                }
            }
        }
        private void SaveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "*|.jpg";
            sfd.FileName = "New";
            sfd.DefaultExt = "jpg";
            sfd.AddExtension = true;
            FileName = sfd.FileName;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage.Save(FileName);
            }
        }
        private void saveSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void Save()
        {
            if (FileName != null)
            {
                pictureBox1.BackgroundImage.Save(FileName);
            }
            else
            {
                SaveAs();
            }
        }
        private void exitEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaintExit();
        }
        private void clearCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = null;
            Shapes.Clear();
        }
        private void PaintExit()
        {
            if (FileName != null)
            {
                if (pictureBox1.BackgroundImage != null)
                {
                    DialogResult result = MessageBox.Show("Do you want to save this picture?", "Paint", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    Save();
                }
            }
            else if (pictureBox1.BackgroundImage == null)
            {

            }
        }
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.FullOpen = true;                       //是否显示ColorDialog有半部分
            //colorDialog1.CustomColors = colorDialog1.Color;   //设置自定义颜色
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)                      //确定事件响应
            {
                Color color_from = colorDialog1.Color;
                pen.Color = color_from;
                PenColorStatus.Text = String.Format("Pen Color:{0}, {1}, {2}", pen.Color.R, pen.Color.G, pen.Color.B);
            }
        }
        public void SingleCheck2(object sender)
        {
            fillItem.Checked = false;
            edgeItem.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;
        }
        private void fillFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleCheck2(sender);
            PaintStatus = 1;
        }
        private void edgeEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleCheck2(sender);
            PaintStatus = 0;
        }
        private void eraserEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
