using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }
        private void Drawing(object sender, PaintEventArgs e) {
            //all values are changeable
            int w = Size.Width;
            int h = Size.Height;
            int s = 30;
            int g = 10;
            int half = w/2;
            int both = s + g;

            Graphics form = e.Graphics;
            SolidBrush black = new SolidBrush(Color.Black);
            SolidBrush gray = new SolidBrush(Color.LightGray);
            form.FillRectangle(black, new Rectangle(w/2, 0, w/2, h));
            //left side of the display
            int curx = half - s;
            int cury = h - both;
            for (int x = (half -s); x > 0; x-=g) {
                curx = half - s;
                cury -= both;
                for (int y = h; y > 0; y -= both) {
                    if (curx < both)
                        break;
                    if (cury < both)
                        break;
                    form.FillRectangle(gray, curx, cury, s, s);
                    curx -= both;
                }
            }
            //right side of the display
            int currx = half;
            int curry = h - both;
            for (int x = half; x < w; x += g) {
                currx = half;
                curry -= both;
                for (int y = h; y > 0; y -= both) {               
                    if (currx >= w - both)
                        break;
                    if (curry < both)
                        break;
                    form.FillRectangle(gray, currx, curry, s, s);
                    currx += both;
                }
            }
            form.Dispose();
        }
    }
}
