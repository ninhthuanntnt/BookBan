using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBan
{
    class MyButton: Button
    {
        private Point flagLocation;
        private Control container;
        private int maxX, maxY, minX, minY;
        public MyButton(Control container, string text)
        {
            this.Text = text;
            this.Location = new System.Drawing.Point(0, 0);
            this.Size = new Size(111, 111);
            this.container = container;
            this.maxX = this.container.Size.Width - (int)this.Width;
            this.maxY = this.container.Size.Height - (int)this.Height;
            this.minX = 0;
            this.minY = 0;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);

            if (mevent.Button == MouseButtons.Left)
            {
                
                flagLocation = mevent.Location;
            }
            
        }

        protected override void OnMouseLeave(EventArgs e)
        {

            //base.OnMouseLeave(e);
            //isDown = true;
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            base.OnMouseMove(mevent);
            
            if (mevent.Button == MouseButtons.Left)
            {
                int curX, curY;
                curX = this.Left + mevent.X - flagLocation.X;
                curY = this.Top + mevent.Y - flagLocation.Y;
                if (curX > minX && curY > minY && curX < maxX && curY < maxY)
                {
                    this.Left = curX;
                    this.Top = curY;
                }
            }
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            
        }
    }
}
