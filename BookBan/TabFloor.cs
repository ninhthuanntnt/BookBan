using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBan
{
    class TabFloor : TabPage
    {
        private AddTableButton addTableBtn;
        public TabFloor(string text) : base()
        {
            this.addTableBtn = new AddTableButton(this);

            this.Location = new System.Drawing.Point(4, 22);
            this.Padding = new Padding(3);
            this.Size = new System.Drawing.Size(482, 518);
            this.TabIndex = 0;
            this.Text = text;
            this.UseVisualStyleBackColor = true;
            this.Controls.Add(this.addTableBtn);
        }

    }
}
