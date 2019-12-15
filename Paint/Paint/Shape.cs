using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class Shape
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        private Pen pen = new Pen(Color.Red);
        public Pen Pen
        {
            get { return pen; }
            set { pen = value; }
        }
        public int PaintStatus = 0;//0 = edge
    }
}
