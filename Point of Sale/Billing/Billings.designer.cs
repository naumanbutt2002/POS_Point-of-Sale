namespace Point_of_Sale
{
    partial class Billings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billings));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BillDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Closebtn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustNameTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.CustIdCb = new System.Windows.Forms.ComboBox();
            this.BDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.findCustomer = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.AddProductsbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search_refresh = new System.Windows.Forms.PictureBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.GrdTotalTb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DiscTotTb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DiscTb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TotTaxTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VARTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubTotalTb = new System.Windows.Forms.TextBox();
            this.PrintBill = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.ProductsDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closebtn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_refresh)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // BillDGV
            // 
            this.BillDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillDGV.BackgroundColor = System.Drawing.Color.White;
            this.BillDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bernard MT Condensed", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BillDGV.ColumnHeadersHeight = 28;
            this.BillDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.BillDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.BillDGV.EnableHeadersVisualStyles = false;
            this.BillDGV.GridColor = System.Drawing.Color.White;
            this.BillDGV.Location = new System.Drawing.Point(8, 384);
            this.BillDGV.Name = "BillDGV";
            this.BillDGV.ReadOnly = true;
            this.BillDGV.RowHeadersVisible = false;
            this.BillDGV.RowTemplate.Height = 28;
            this.BillDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillDGV.Size = new System.Drawing.Size(576, 236);
            this.BillDGV.TabIndex = 121;
            this.BillDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillDGV.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.BillDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gold;
            this.BillDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.BillDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bernard MT Condensed", 12F);
            this.BillDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.BillDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillDGV.ThemeStyle.HeaderStyle.Height = 28;
            this.BillDGV.ThemeStyle.ReadOnly = true;
            this.BillDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Black;
            this.BillDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.BillDGV.ThemeStyle.RowsStyle.Height = 28;
            this.BillDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gold;
            this.BillDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "QTY";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SubTotal";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.Closebtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 45);
            this.panel1.TabIndex = 106;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // Closebtn
            // 
            this.Closebtn.Image = ((System.Drawing.Image)(resources.GetObject("Closebtn.Image")));
            this.Closebtn.Location = new System.Drawing.Point(1112, 6);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(31, 33);
            this.Closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Closebtn.TabIndex = 4;
            this.Closebtn.TabStop = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Billings";
            // 
            // CustNameTb
            // 
            this.CustNameTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CustNameTb.Enabled = false;
            this.CustNameTb.Font = new System.Drawing.Font("Arial", 15F);
            this.CustNameTb.Location = new System.Drawing.Point(12, 180);
            this.CustNameTb.Multiline = true;
            this.CustNameTb.Name = "CustNameTb";
            this.CustNameTb.Size = new System.Drawing.Size(268, 32);
            this.CustNameTb.TabIndex = 110;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 23);
            this.label12.TabIndex = 109;
            this.label12.Text = "Customer Name: ";
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.Yellow;
            this.logOutBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logOutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.logOutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.Black;
            this.logOutBtn.Location = new System.Drawing.Point(1024, 568);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(112, 40);
            this.logOutBtn.TabIndex = 115;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel9.Location = new System.Drawing.Point(0, 632);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1176, 29);
            this.panel9.TabIndex = 108;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.pictureBox12);
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 37);
            this.panel2.TabIndex = 107;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(44, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 22);
            this.label18.TabIndex = 136;
            this.label18.Text = "View Bills";
            this.label18.Click += new System.EventHandler(this.ViewBills_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(8, 4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(32, 32);
            this.pictureBox12.TabIndex = 135;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.PictureBox12_Click);
            // 
            // CustIdCb
            // 
            this.CustIdCb.Font = new System.Drawing.Font("Bernard MT Condensed", 14F);
            this.CustIdCb.FormattingEnabled = true;
            this.CustIdCb.Location = new System.Drawing.Point(12, 120);
            this.CustIdCb.Name = "CustIdCb";
            this.CustIdCb.Size = new System.Drawing.Size(268, 30);
            this.CustIdCb.TabIndex = 124;
            this.CustIdCb.Text = "Customer ID";
            this.CustIdCb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustIdCb_KeyPress);
            // 
            // BDate
            // 
            this.BDate.Font = new System.Drawing.Font("Bernard MT Condensed", 14F);
            this.BDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BDate.Location = new System.Drawing.Point(12, 236);
            this.BDate.Name = "BDate";
            this.BDate.Size = new System.Drawing.Size(268, 30);
            this.BDate.TabIndex = 126;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.findCustomer);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.AddProductsbtn);
            this.panel3.Location = new System.Drawing.Point(295, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 146);
            this.panel3.TabIndex = 127;
            // 
            // findCustomer
            // 
            this.findCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.findCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.findCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.findCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.findCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findCustomer.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findCustomer.ForeColor = System.Drawing.Color.White;
            this.findCustomer.Location = new System.Drawing.Point(12, 8);
            this.findCustomer.Name = "findCustomer";
            this.findCustomer.Size = new System.Drawing.Size(104, 40);
            this.findCustomer.TabIndex = 130;
            this.findCustomer.Text = "Find";
            this.findCustomer.UseVisualStyleBackColor = false;
            this.findCustomer.Click += new System.EventHandler(this.findCustomer_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(12, 100);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 40);
            this.button5.TabIndex = 129;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // AddProductsbtn
            // 
            this.AddProductsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AddProductsbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddProductsbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AddProductsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AddProductsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductsbtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductsbtn.ForeColor = System.Drawing.Color.White;
            this.AddProductsbtn.Location = new System.Drawing.Point(12, 54);
            this.AddProductsbtn.Name = "AddProductsbtn";
            this.AddProductsbtn.Size = new System.Drawing.Size(104, 40);
            this.AddProductsbtn.TabIndex = 128;
            this.AddProductsbtn.Text = "Add ";
            this.AddProductsbtn.UseVisualStyleBackColor = false;
            this.AddProductsbtn.Click += new System.EventHandler(this.AddProductsbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.search_refresh);
            this.groupBox1.Controls.Add(this.searchbtn);
            this.groupBox1.Controls.Add(this.searchTB);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 15F);
            this.groupBox1.Location = new System.Drawing.Point(676, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 100);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By Product Name";
            // 
            // search_refresh
            // 
            this.search_refresh.Image = ((System.Drawing.Image)(resources.GetObject("search_refresh.Image")));
            this.search_refresh.Location = new System.Drawing.Point(408, 40);
            this.search_refresh.Name = "search_refresh";
            this.search_refresh.Size = new System.Drawing.Size(44, 40);
            this.search_refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.search_refresh.TabIndex = 23;
            this.search_refresh.TabStop = false;
            this.search_refresh.Click += new System.EventHandler(this.search_refresh_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.searchbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.searchbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.searchbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.Location = new System.Drawing.Point(300, 40);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(104, 40);
            this.searchbtn.TabIndex = 129;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchTB
            // 
            this.searchTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchTB.Font = new System.Drawing.Font("Arial", 15F);
            this.searchTB.Location = new System.Drawing.Point(8, 44);
            this.searchTB.Multiline = true;
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(276, 32);
            this.searchTB.TabIndex = 129;
            this.searchTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTB_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.GrdTotalTb);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.DiscTotTb);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.DiscTb);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.TotTaxTb);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.VARTb);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.SubTotalTb);
            this.panel4.Location = new System.Drawing.Point(608, 448);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(412, 172);
            this.panel4.TabIndex = 130;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 23);
            this.label16.TabIndex = 142;
            this.label16.Text = "Grand Total";
            // 
            // GrdTotalTb
            // 
            this.GrdTotalTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GrdTotalTb.Enabled = false;
            this.GrdTotalTb.Font = new System.Drawing.Font("Arial", 15F);
            this.GrdTotalTb.Location = new System.Drawing.Point(129, 125);
            this.GrdTotalTb.Multiline = true;
            this.GrdTotalTb.Name = "GrdTotalTb";
            this.GrdTotalTb.Size = new System.Drawing.Size(235, 32);
            this.GrdTotalTb.TabIndex = 143;
            this.GrdTotalTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GrdTotalTb_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(216, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 23);
            this.label14.TabIndex = 141;
            this.label14.Text = "%";
            // 
            // DiscTotTb
            // 
            this.DiscTotTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DiscTotTb.Enabled = false;
            this.DiscTotTb.Font = new System.Drawing.Font("Arial", 15F);
            this.DiscTotTb.Location = new System.Drawing.Point(264, 87);
            this.DiscTotTb.Multiline = true;
            this.DiscTotTb.Name = "DiscTotTb";
            this.DiscTotTb.Size = new System.Drawing.Size(100, 32);
            this.DiscTotTb.TabIndex = 140;
            this.DiscTotTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DiscTotTb_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 23);
            this.label15.TabIndex = 138;
            this.label15.Text = "Discount";
            // 
            // DiscTb
            // 
            this.DiscTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DiscTb.Font = new System.Drawing.Font("Arial", 15F);
            this.DiscTb.Location = new System.Drawing.Point(132, 87);
            this.DiscTb.Multiline = true;
            this.DiscTb.Name = "DiscTb";
            this.DiscTb.Size = new System.Drawing.Size(64, 32);
            this.DiscTb.TabIndex = 139;
            this.DiscTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DiscTb_KeyPress);
            this.DiscTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DiscTb_KeyUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(216, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 23);
            this.label13.TabIndex = 137;
            this.label13.Text = "%";
            // 
            // TotTaxTb
            // 
            this.TotTaxTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TotTaxTb.Enabled = false;
            this.TotTaxTb.Font = new System.Drawing.Font("Arial", 15F);
            this.TotTaxTb.Location = new System.Drawing.Point(264, 47);
            this.TotTaxTb.Multiline = true;
            this.TotTaxTb.Name = "TotTaxTb";
            this.TotTaxTb.Size = new System.Drawing.Size(100, 32);
            this.TotTaxTb.TabIndex = 136;
            this.TotTaxTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotTaxTb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 134;
            this.label3.Text = "VAST + ST";
            // 
            // VARTb
            // 
            this.VARTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.VARTb.Font = new System.Drawing.Font("Arial", 15F);
            this.VARTb.Location = new System.Drawing.Point(132, 47);
            this.VARTb.Multiline = true;
            this.VARTb.Name = "VARTb";
            this.VARTb.Size = new System.Drawing.Size(64, 32);
            this.VARTb.TabIndex = 135;
            this.VARTb.TextChanged += new System.EventHandler(this.VARTb_TextChanged);
            this.VARTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VARTb_KeyPress);
            this.VARTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VARTb_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 133;
            this.label1.Text = "SUB TOTAL";
            // 
            // SubTotalTb
            // 
            this.SubTotalTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SubTotalTb.Enabled = false;
            this.SubTotalTb.Font = new System.Drawing.Font("Arial", 15F);
            this.SubTotalTb.Location = new System.Drawing.Point(132, 8);
            this.SubTotalTb.Multiline = true;
            this.SubTotalTb.Name = "SubTotalTb";
            this.SubTotalTb.Size = new System.Drawing.Size(232, 32);
            this.SubTotalTb.TabIndex = 133;
            this.SubTotalTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SubTotalTb_KeyPress);
            // 
            // PrintBill
            // 
            this.PrintBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PrintBill.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PrintBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PrintBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintBill.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBill.ForeColor = System.Drawing.Color.White;
            this.PrintBill.Location = new System.Drawing.Point(1024, 464);
            this.PrintBill.Name = "PrintBill";
            this.PrintBill.Size = new System.Drawing.Size(112, 40);
            this.PrintBill.TabIndex = 131;
            this.PrintBill.Text = "PRINT";
            this.PrintBill.UseVisualStyleBackColor = false;
            this.PrintBill.Click += new System.EventHandler(this.PrintBill_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1024, 516);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 40);
            this.button4.TabIndex = 132;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // QtyTb
            // 
            this.QtyTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.QtyTb.Font = new System.Drawing.Font("Arial", 15F);
            this.QtyTb.Location = new System.Drawing.Point(112, 284);
            this.QtyTb.Multiline = true;
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(168, 32);
            this.QtyTb.TabIndex = 134;
            this.QtyTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QtyTb_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 292);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 23);
            this.label17.TabIndex = 133;
            this.label17.Text = "Quantity:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.PrintPreviewDialog1_Load);
            // 
            // ProductsDGV
            // 
            this.ProductsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsDGV.BackgroundColor = System.Drawing.Color.White;
            this.ProductsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bernard MT Condensed", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductsDGV.ColumnHeadersHeight = 28;
            this.ProductsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Name,
            this.Cat,
            this.Qty,
            this.Price});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsDGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.ProductsDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ProductsDGV.EnableHeadersVisualStyles = false;
            this.ProductsDGV.GridColor = System.Drawing.Color.White;
            this.ProductsDGV.Location = new System.Drawing.Point(612, 194);
            this.ProductsDGV.Name = "ProductsDGV";
            this.ProductsDGV.ReadOnly = true;
            this.ProductsDGV.RowHeadersVisible = false;
            this.ProductsDGV.RowTemplate.Height = 28;
            this.ProductsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDGV.Size = new System.Drawing.Size(524, 248);
            this.ProductsDGV.TabIndex = 135;
            this.ProductsDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ProductsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty;
            this.ProductsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductsDGV.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.ProductsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gold;
            this.ProductsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ProductsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bernard MT Condensed", 12F);
            this.ProductsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.ProductsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductsDGV.ThemeStyle.HeaderStyle.Height = 28;
            this.ProductsDGV.ThemeStyle.ReadOnly = true;
            this.ProductsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Black;
            this.ProductsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.ProductsDGV.ThemeStyle.RowsStyle.Height = 28;
            this.ProductsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gold;
            this.ProductsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDGV_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "PID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Cat
            // 
            this.Cat.HeaderText = "Cat";
            this.Cat.Name = "Cat";
            this.Cat.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Billings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 660);
            this.ControlBox = false;
            this.Controls.Add(this.ProductsDGV);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.PrintBill);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BDate);
            this.Controls.Add(this.CustIdCb);
            this.Controls.Add(this.BillDGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CustNameTb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billings";
            this.Load += new System.EventHandler(this.Billings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closebtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_refresh)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView BillDGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox Closebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustNameTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CustIdCb;
        private System.Windows.Forms.DateTimePicker BDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddProductsbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TotTaxTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VARTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SubTotalTb;
        private System.Windows.Forms.Button PrintBill;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox DiscTotTb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox DiscTb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox GrdTotalTb;
        private System.Windows.Forms.PictureBox search_refresh;
        private System.Windows.Forms.TextBox QtyTb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox12;
        private Guna.UI.WinForms.GunaDataGridView ProductsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button findCustomer;
        private System.Windows.Forms.Button button5;
    }
}