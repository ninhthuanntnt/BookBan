using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBan
{
    class AddTableButton : Button
    {
        private Control container;
        public AddTableButton(Control container) : base()
        {
            this.container = container;

            this.Text = "+";
            this.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(439, 0);
            this.Size = new System.Drawing.Size(43, 35);
            this.Text = "+";
            this.UseVisualStyleBackColor = true;

        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if(e.Button == MouseButtons.Left)
            {
                AddTableForm newForm = new AddTableForm((Form1)this.FindForm(), this.container);
                this.FindForm().Enabled = false;
                newForm.Show();
            }
        }
    }
}
