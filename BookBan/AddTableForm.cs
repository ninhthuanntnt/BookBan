using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBan
{
    public partial class AddTableForm : Form
    {
        private Form1 formContainer;
        public AddTableForm(Form1 form)
        {
            InitializeComponent();
            formContainer = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tableName = this.tbTaFormNew.Text;
            if( tableName.Length == 0)
            {
                MessageBox.Show("Vui lòng ko bỏ trống!!!");
                this.tbTaFormNew.Focus();
            }
            else
            {
                formContainer.createNewTable(tableName);
                formContainer.Enabled = true;
                this.Close();
            }
        }
    }
}
