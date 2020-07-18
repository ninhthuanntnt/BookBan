using System.Collections;
using System.Windows.Forms;

namespace BookBan
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnChangeTable = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.discountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.tbLayout2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbLayout3 = new System.Windows.Forms.TableLayoutPanel();
            this.tbLayout4 = new System.Windows.Forms.TableLayoutPanel();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbDish = new System.Windows.Forms.ComboBox();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.dtGridOrder = new System.Windows.Forms.DataGridView();
            this.nameDish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).BeginInit();
            this.tbLayout2.SuspendLayout();
            this.tbLayout3.SuspendLayout();
            this.tbLayout4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOrder)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.96777F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.86462F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.08703F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbLayout2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1241, 577);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutUsToolStripMenuItem.Text = "About us";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.pbLogo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnChangeTable, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnPay, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.discountNumericUpDown, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtTotalPrice, 0, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1093, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.67567F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.32433F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(145, 544);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 45);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tổng tiền";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.ErrorImage = global::BookBan.Properties.Resources.HVS_180x180;
            this.pbLogo.Image = global::BookBan.Properties.Resources.HVS_180x180;
            this.pbLogo.InitialImage = global::BookBan.Properties.Resources.HVS_180x180;
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(139, 117);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeTable.Location = new System.Drawing.Point(3, 126);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(139, 91);
            this.btnChangeTable.TabIndex = 4;
            this.btnChangeTable.Text = "Chuyển bàn";
            this.btnChangeTable.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 234);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // btnPay
            // 
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPay.Location = new System.Drawing.Point(3, 273);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(139, 76);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.payButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Giảm giá";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // discountNumericUpDown
            // 
            this.discountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.discountNumericUpDown.Location = new System.Drawing.Point(3, 406);
            this.discountNumericUpDown.Name = "discountNumericUpDown";
            this.discountNumericUpDown.Size = new System.Drawing.Size(139, 20);
            this.discountNumericUpDown.TabIndex = 8;
            this.discountNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(3, 498);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(139, 35);
            this.txtTotalPrice.TabIndex = 10;
            // 
            // tbLayout2
            // 
            this.tbLayout2.ColumnCount = 1;
            this.tbLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayout2.Controls.Add(this.tbLayout3, 0, 0);
            this.tbLayout2.Controls.Add(this.dtGridOrder, 0, 1);
            this.tbLayout2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayout2.Location = new System.Drawing.Point(499, 30);
            this.tbLayout2.Name = "tbLayout2";
            this.tbLayout2.RowCount = 2;
            this.tbLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tbLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayout2.Size = new System.Drawing.Size(588, 544);
            this.tbLayout2.TabIndex = 2;
            // 
            // tbLayout3
            // 
            this.tbLayout3.ColumnCount = 3;
            this.tbLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tbLayout3.Controls.Add(this.tbLayout4, 0, 0);
            this.tbLayout3.Controls.Add(this.btnAddDish, 1, 0);
            this.tbLayout3.Controls.Add(this.numAmount, 2, 0);
            this.tbLayout3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayout3.Location = new System.Drawing.Point(3, 3);
            this.tbLayout3.Name = "tbLayout3";
            this.tbLayout3.RowCount = 1;
            this.tbLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tbLayout3.Size = new System.Drawing.Size(582, 94);
            this.tbLayout3.TabIndex = 0;
            // 
            // tbLayout4
            // 
            this.tbLayout4.ColumnCount = 1;
            this.tbLayout4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayout4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLayout4.Controls.Add(this.cbFood, 0, 0);
            this.tbLayout4.Controls.Add(this.cbDish, 0, 1);
            this.tbLayout4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayout4.Location = new System.Drawing.Point(3, 3);
            this.tbLayout4.Name = "tbLayout4";
            this.tbLayout4.RowCount = 2;
            this.tbLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayout4.Size = new System.Drawing.Size(285, 88);
            this.tbLayout4.TabIndex = 0;
            // 
            // cbFood
            // 
            this.cbFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Items.AddRange(new object[] {
            "Thịt",
            "Cá",
            "Hải sản",
            "Bò",
            "Gà",
            "Vịt"});
            this.cbFood.Location = new System.Drawing.Point(0, 11);
            this.cbFood.Margin = new System.Windows.Forms.Padding(0);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(285, 21);
            this.cbFood.TabIndex = 0;
            this.cbFood.SelectedValueChanged += new System.EventHandler(this.cbFood_SelectedValueChanged);
            // 
            // cbDish
            // 
            this.cbDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDish.FormattingEnabled = true;
            this.cbDish.Items.AddRange(new object[] {
            "Hấp",
            "Nướng",
            "Luộc",
            "Xào",
            "Gỏi"});
            this.cbDish.Location = new System.Drawing.Point(0, 55);
            this.cbDish.Margin = new System.Windows.Forms.Padding(0);
            this.cbDish.Name = "cbDish";
            this.cbDish.Size = new System.Drawing.Size(285, 21);
            this.cbDish.TabIndex = 1;
            this.cbDish.SelectedValueChanged += new System.EventHandler(this.cbDish_SelectedValueChanged);
            // 
            // btnAddDish
            // 
            this.btnAddDish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddDish.Location = new System.Drawing.Point(301, 10);
            this.btnAddDish.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(96, 74);
            this.btnAddDish.TabIndex = 1;
            this.btnAddDish.Text = "Thêm món";
            this.btnAddDish.UseVisualStyleBackColor = true;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // numAmount
            // 
            this.numAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numAmount.Location = new System.Drawing.Point(417, 37);
            this.numAmount.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(155, 20);
            this.numAmount.TabIndex = 2;
            this.numAmount.ValueChanged += new System.EventHandler(this.numAmount_ValueChanged);
            // 
            // dtGridOrder
            // 
            this.dtGridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDish,
            this.priceDish,
            this.countDish,
            this.totalMoney});
            this.dtGridOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridOrder.Location = new System.Drawing.Point(3, 103);
            this.dtGridOrder.Name = "dtGridOrder";
            this.dtGridOrder.ReadOnly = true;
            this.dtGridOrder.Size = new System.Drawing.Size(582, 438);
            this.dtGridOrder.TabIndex = 1;
            // 
            // nameDish
            // 
            this.nameDish.HeaderText = "Tên món";
            this.nameDish.Name = "nameDish";
            this.nameDish.ReadOnly = true;
            // 
            // priceDish
            // 
            this.priceDish.HeaderText = "Giá";
            this.priceDish.Name = "priceDish";
            this.priceDish.ReadOnly = true;
            // 
            // countDish
            // 
            this.countDish.HeaderText = "Số lượng";
            this.countDish.Name = "countDish";
            this.countDish.ReadOnly = true;
            // 
            // totalMoney
            // 
            this.totalMoney.HeaderText = "Thành tiền";
            this.totalMoney.Name = "totalMoney";
            this.totalMoney.ReadOnly = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabFloor);
            this.tabControl.Controls.Add(this.tabAdd);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 30);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(490, 544);
            this.tabControl.TabIndex = 3;
            // 
            // tabFloor
            // 
            this.tabFloor.Location = new System.Drawing.Point(4, 22);
            this.tabFloor.Name = "tabFloor";
            this.tabFloor.Padding = new System.Windows.Forms.Padding(3);
            this.tabFloor.Size = new System.Drawing.Size(482, 518);
            this.tabFloor.TabIndex = 0;
            this.tabFloor.Text = "Tầng trệt";
            this.tabFloor.UseVisualStyleBackColor = true;
            // 
            // tabAdd
            // 
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(482, 518);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Thêm";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 577);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).EndInit();
            this.tbLayout2.ResumeLayout(false);
            this.tbLayout3.ResumeLayout(false);
            this.tbLayout4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOrder)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnChangeTable;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown discountNumericUpDown;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TableLayoutPanel tbLayout2;
        private System.Windows.Forms.TableLayoutPanel tbLayout3;
        private System.Windows.Forms.TableLayoutPanel tbLayout4;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbDish;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.DataGridView dtGridOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDish;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDish;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDish;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMoney;
        private ArrayList arrBtnTable;
        private ArrayList arrFloors;
        private TabControl tabControl;
        private TabFloor tabFloor;
        private TabPage tabAdd;
    }
}

