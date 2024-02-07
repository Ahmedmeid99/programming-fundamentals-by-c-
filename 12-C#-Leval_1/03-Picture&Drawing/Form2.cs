using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Picture_Drawing
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void frm2_Load(object sender, EventArgs e)
        {
            
            
        }

        private void frm2_Paint(object sender, PaintEventArgs e)
        {
            Color Black = Color.FromArgb(255, 0, 0, 0);
            Pen pen = new Pen(Black);
            pen.Width = 5;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen,100,100,100,200);          // x1,,y1,x2,y2
            e.Graphics.DrawRectangle(pen, 200, 200, 300, 300); // x,y,width,height
            e.Graphics.DrawEllipse(pen, 200, 50, 100, 120);    // x,y,width,height
        }
    }
}
