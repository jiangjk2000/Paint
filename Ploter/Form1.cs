using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Ploter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 事件函数
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pointOld.X = e.X;
            pointOld.Y = e.Y;
            circle.X = pointOld.X;
            circle.Y = pointOld.Y;
            rect.x = pointOld.X;
            rect.y = pointOld.Y;
            line.Old = pointOld;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            pointNew.X = e.X;
            pointNew.Y = e.Y;
            circle.width = pointNew.X - pointOld.X;
            circle.height = pointNew.Y - pointOld.Y;
            rect.height = pointNew.X - pointOld.X;
            rect.width = pointNew.Y - pointOld.Y;
            line.New = pointNew;
            circle.pen = this.pen;
            rect.pen = this.pen;
            line.pen = this.pen;
            if (plotCondition == 1)
            {
                StreamWriter sw = new StreamWriter("1.txt", true);
                sw.WriteLine(circle);
                sw.Close();
            }
            if (plotCondition == 2)
            {
                StreamWriter sw = new StreamWriter("1.txt", true);
                sw.WriteLine(rect);
                sw.Close();
            }
            if(plotCondition == 3)
            {
                StreamWriter sw = new StreamWriter("1.txt", true);
                sw.WriteLine(line);
                sw.Close();
            }
            Plotlabel.Invalidate();
        }
        private void Plotlabel_Paint(object sender, PaintEventArgs e)
        {
            circle.Draw(e, pen);
            rect.Draw(e, pen);
            line.Draw(e, pen);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("1.txt", false);
            sw.Close();
        }
        private void CircleItem_Click(object sender, EventArgs e)
        {
            plotCondition = 1;
            //1为Circle
            SingleCheck(sender);
        }
        private void RectItem_Click(object sender, EventArgs e)
        {
            plotCondition = 2;
            SingleCheck(sender);
        }
        private void lineToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            plotCondition = 3;
            SingleCheck(sender);
        }
        private void SingleCheck(object sender)
        {
            CircleItem.Checked = false;
            RectItem.Checked = false;
            LinePlotItem.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;
        }
        private void AboutItem_Click(object sender, EventArgs e)
        {
            (new FormAbout()).ShowDialog();
        }
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.FullOpen = true;                       //是否显示ColorDialog有半部分
            //colorDialog1.CustomColors = colorDialog1.Color;   //设置自定义颜色
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)                      //确定事件响应
            {
                Color color_from = colorDialog1.Color;
                pen.Color = color_from;
                PenColorStatus.Text = String.Format("Pen Color:{0} {1} {2}", pen.Color.R, pen.Color.G, pen.Color.B);
            }
        }
        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void Plotlabel_MouseMove(object sender, MouseEventArgs e)
        {
            MousePositionItem.Text = String.Format("MousePositin:{0}, {1}", e.X, e.Y);
        }
        #endregion
        #region 全局变量
        Point pointOld = new Point();
        Point pointNew = new Point();
        Circle circle = new Circle();
        Rect rect = new Rect();
        Line line = new Line();
        private int plotCondition = -1;
        private Pen pen = new Pen(Color.Red);
        #endregion
        //Graphics g;
        //private void Form1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    g = this.CreateGraphics();
        //    Pen p = new Pen(Color.Blue, 2);
        //    if (plotCondition == 1)
        //    {
        //        g.DrawEllipse(Pens.Black, 20, 30, 40, 50);
        //    }
        //}
    }
    public class Graphical
    {
        public void PenDataUpdate(string[] a, Pen pen)
        {
            int R = int.Parse(a[5]);
            int G = int.Parse(a[6]);
            int B = int.Parse(a[7]);
            float penWidth = float.Parse(a[8]);
            pen.Width = penWidth;
            pen.Color = Color.FromArgb(R, G, B);
        }
    }
    interface IGraphicalPlot
    {
        void Draw(PaintEventArgs e,Pen pen);
    }
    public class Circle : Graphical, IGraphicalPlot
    {
        public int X;
        public int Y;
        public int height;
        public int width;
        public Pen pen;
        public Circle()
        { }
        public Circle(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return String.Format("c,{0},{1},{2},{3},{4},{5},{6},{7}", X, Y, height, width,pen.Color.R, pen.Color.G, pen.Color.B, pen.Width);
        }
        public void Draw(PaintEventArgs e, Pen pen)
        {
            using (StreamReader sr = new StreamReader("1.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] a = line.Split(',');
                    if (a[0] == "c")
                    {
                        float x = float.Parse(a[1]);
                        float y = float.Parse(a[2]);
                        float width = float.Parse(a[3]);
                        float height = float.Parse(a[4]);
                        this.PenDataUpdate(a, pen);
                        e.Graphics.DrawEllipse(pen, x, y, height, width);
                    }
                }
            }
        }
    }
    public class Rect : Graphical, IGraphicalPlot
    {
        public int x;
        public int y;
        public int height;
        public int width;
        public Pen pen;
        public override string ToString()
        {
            return string.Format("r,{0},{1},{2},{3},{4},{5},{6},{7}", x, y, height, width, pen.Color.R, pen.Color.G, pen.Color.B, pen.Width);
        }
        public void Draw(PaintEventArgs e,Pen pen)
        {
            using (StreamReader sr = new StreamReader("1.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] a = line.Split(',');
                    if (a[0] == "r")
                    {
                        int x = int.Parse(a[1]);
                        int y = int.Parse(a[2]);
                        int height = int.Parse(a[3]);
                        int width = int.Parse(a[4]);
                        this.PenDataUpdate(a, pen);
                        e.Graphics.DrawRectangle(pen, x, y, height, width);
                    }
                }
            }
        }
    }
    public class Line : Graphical, IGraphicalPlot
    {
        public Point Old;
        public Point New;
        public Pen pen;
        public override string ToString()
        {
            return String.Format("l,{0},{1},{2},{3},{4},{5},{6},{7}", Old.X, Old.Y, New.X, New.Y, pen.Color.R, pen.Color.G, pen.Color.B, pen.Width);
        }
        public void Draw(PaintEventArgs e, Pen pen)
        {
            using (StreamReader sr = new StreamReader("1.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] a = line.Split(',');
                    if (a[0] == "l")
                    {
                        int x1 = int.Parse(a[1]);
                        int y1 = int.Parse(a[2]);
                        int x2 = int.Parse(a[3]);
                        int y2 = int.Parse(a[4]);
                        this.PenDataUpdate(a, pen);
                        e.Graphics.DrawLine(pen, x1, y1, x2, y2);
                    }
                }
            }
        }
    }
}
