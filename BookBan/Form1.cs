﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBan
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Dictionary<string, long>> DISH = new Dictionary<string, Dictionary<string, long>>();
        private String _food = "";
        private String _dish = "";
        private long _count = 0;

        private DataTable dtSrc;

        public Form1()
        {
            InitializeComponent();
            Init();
            
        }
        
        private void Init()
        {
            //
            //DISH.Add("Thịt", );
            Dictionary<string, long> price= new Dictionary<string, long>();
            price.Add("Xào", 20000);
            price.Add("Hấp", 30000);
            price.Add("Luộc", 1000000);
            DISH.Add("Thịt", price);


            //dtSrc = new DataTable();
            //dtSrc.Columns.Add("Tên món");
            //dtSrc.Columns.Add("Giá");
            //dtSrc.Columns.Add("Số lượng");
            //dtSrc.Columns.Add("Thành Tiền");
            //this.dtGridOrder.DataSource = dtSrc;
        }

        private void cbFood_SelectedValueChanged(object sender, EventArgs e)
        {
            _food = ((ComboBox)sender).SelectedItem.ToString();
        }

        private void cbDish_SelectedValueChanged(object sender, EventArgs e)
        {
            _dish = ((ComboBox)sender).SelectedItem.ToString();
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            if (_food.Length > 0 && _dish.Length > 0 && _count > 0)
            {
                object[] dr =
                {
                    _food + "(" + _dish + ")",
                    DISH[_food][_dish],
                    _count,
                    DISH[_food][_dish] * _count
                };
             
                this.dtGridOrder.Rows.Add(dr);

            } 
        }

        private void numAmount_ValueChanged(object sender, EventArgs e)
        {
            _count = (long)((NumericUpDown)sender).Value;
        }
    }
}
