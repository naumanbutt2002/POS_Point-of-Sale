namespace Point_of_Sale
{
    partial class AddProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PnameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.PCatCb = new System.Windows.Forms.ComboBox();
            this.supIdCb = new System.Windows.Forms.ComboBox();
            this.supp_ids = new System.Windows.Forms.Label();
            this.supNameTb = new System.Windows.Forms.TextBox();
            this.supp_name = new System.Windows.Forms.Label();
            this.SuppliersDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResetPB = new System.Windows.Forms.PictureBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ResetBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ResetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ResetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(430, 455);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(85, 40);
            this.ResetBtn.TabIndex = 52;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.SaveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.SaveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.SaveBtn.Location = new System.Drawing.Point(319, 455);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(82, 40);
            this.SaveBtn.TabIndex = 51;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 23);
            this.label4.TabIndex = 47;
            this.label4.Text = "Product Quantity:";
            // 
            // PriceTb
            // 
            this.PriceTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PriceTb.Font = new System.Drawing.Font("Arial", 15F);
            this.PriceTb.Location = new System.Drawing.Point(208, 206);
            this.PriceTb.Multiline = true;
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(308, 32);
            this.PriceTb.TabIndex = 46;
            this.PriceTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Product Price:";
            // 
            // PnameTb
            // 
            this.PnameTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnameTb.Font = new System.Drawing.Font("Arial", 15F);
            this.PnameTb.Location = new System.Drawing.Point(208, 83);
            this.PnameTb.Multiline = true;
            this.PnameTb.Name = "PnameTb";
            this.PnameTb.Size = new System.Drawing.Size(308, 32);
            this.PnameTb.TabIndex = 42;
            this.PnameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PnameTb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "Product Name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 28);
            this.label7.TabIndex = 40;
            this.label7.Text = "Add Products";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(10, 8);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(44, 36);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 38;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.PictureBox11_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "Product Category:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox11);
            this.panel1.Location = new System.Drawing.Point(1165, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 52);
            this.panel1.TabIndex = 39;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            // 
            // QtyTb
            // 
            this.QtyTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.QtyTb.Font = new System.Drawing.Font("Arial", 15F);
            this.QtyTb.Location = new System.Drawing.Point(208, 268);
            this.QtyTb.Multiline = true;
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(308, 32);
            this.QtyTb.TabIndex = 54;
            this.QtyTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QtyTb_KeyPress);
            // 
            // PCatCb
            // 
            this.PCatCb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PCatCb.Font = new System.Drawing.Font("Arial", 15F);
            this.PCatCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PCatCb.FormattingEnabled = true;
            this.PCatCb.Items.AddRange(new object[] {
            "Food",
            "Beverage",
            "Clothes",
            "Electrical",
            "Electronics",
            "Appliance"});
            this.PCatCb.Location = new System.Drawing.Point(208, 145);
            this.PCatCb.Name = "PCatCb";
            this.PCatCb.Size = new System.Drawing.Size(308, 31);
            this.PCatCb.TabIndex = 55;
            this.PCatCb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PCatCb_KeyPress);
            // 
            // supIdCb
            // 
            this.supIdCb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.supIdCb.Font = new System.Drawing.Font("Arial", 15F);
            this.supIdCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.supIdCb.FormattingEnabled = true;
            this.supIdCb.Location = new System.Drawing.Point(208, 330);
            this.supIdCb.Name = "supIdCb";
            this.supIdCb.Size = new System.Drawing.Size(308, 31);
            this.supIdCb.TabIndex = 57;
            this.supIdCb.SelectionChangeCommitted += new System.EventHandler(this.supIdCb_SelectionChangeCommitted);
            this.supIdCb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.supIdCb_KeyPress);
            // 
            // supp_ids
            // 
            this.supp_ids.AutoSize = true;
            this.supp_ids.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supp_ids.Location = new System.Drawing.Point(36, 335);
            this.supp_ids.Name = "supp_ids";
            this.supp_ids.Size = new System.Drawing.Size(119, 23);
            this.supp_ids.TabIndex = 56;
            this.supp_ids.Text = "Supplier ID: ";
            // 
            // supNameTb
            // 
            this.supNameTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.supNameTb.Enabled = false;
            this.supNameTb.Font = new System.Drawing.Font("Arial", 15F);
            this.supNameTb.Location = new System.Drawing.Point(208, 391);
            this.supNameTb.Multiline = true;
            this.supNameTb.Name = "supNameTb";
            this.supNameTb.Size = new System.Drawing.Size(308, 32);
            this.supNameTb.TabIndex = 59;
            // 
            // supp_name
            // 
            this.supp_name.AutoSize = true;
            this.supp_name.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supp_name.Location = new System.Drawing.Point(36, 396);
            this.supp_name.Name = "supp_name";
            this.supp_name.Size = new System.Drawing.Size(150, 23);
            this.supp_name.TabIndex = 58;
            this.supp_name.Text = "Supplier Name: ";
            // 
            // SuppliersDGV
            // 
            this.SuppliersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SuppliersDGV.BackgroundColor = System.Drawing.Color.White;
            this.SuppliersDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SuppliersDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SuppliersDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bernard MT Condensed", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SuppliersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SuppliersDGV.ColumnHeadersHeight = 28;
            this.SuppliersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Address,
            this.PhoneNo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SuppliersDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.SuppliersDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SuppliersDGV.EnableHeadersVisualStyles = false;
            this.SuppliersDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SuppliersDGV.Location = new System.Drawing.Point(560, 145);
            this.SuppliersDGV.Name = "SuppliersDGV";
            this.SuppliersDGV.ReadOnly = true;
            this.SuppliersDGV.RowHeadersVisible = false;
            this.SuppliersDGV.RowTemplate.Height = 28;
            this.SuppliersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SuppliersDGV.Size = new System.Drawing.Size(624, 350);
            this.SuppliersDGV.TabIndex = 89;
            this.SuppliersDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.SuppliersDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty;
            this.SuppliersDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SuppliersDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SuppliersDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SuppliersDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SuppliersDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SuppliersDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SuppliersDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gold;
            this.SuppliersDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.SuppliersDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bernard MT Condensed", 12F);
            this.SuppliersDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.SuppliersDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SuppliersDGV.ThemeStyle.HeaderStyle.Height = 28;
            this.SuppliersDGV.ThemeStyle.ReadOnly = true;
            this.SuppliersDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Black;
            this.SuppliersDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SuppliersDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliersDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.SuppliersDGV.ThemeStyle.RowsStyle.Height = 28;
            this.SuppliersDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gold;
            this.SuppliersDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.SuppliersDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SuppliersDGV_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // PhoneNo
            // 
            this.PhoneNo.HeaderText = "PhoneNo";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.ReadOnly = true;
            // 
            // ResetPB
            // 
            this.ResetPB.Image = ((System.Drawing.Image)(resources.GetObject("ResetPB.Image")));
            this.ResetPB.Location = new System.Drawing.Point(1030, 77);
            this.ResetPB.Name = "ResetPB";
            this.ResetPB.Size = new System.Drawing.Size(43, 40);
            this.ResetPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResetPB.TabIndex = 134;
            this.ResetPB.TabStop = false;
            this.ResetPB.Click += new System.EventHandler(this.ResetPB_Click);
            // 
            // searchTB
            // 
            this.searchTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchTB.Font = new System.Drawing.Font("Arial", 15F);
            this.searchTB.ForeColor = System.Drawing.Color.Silver;
            this.searchTB.Location = new System.Drawing.Point(644, 82);
            this.searchTB.Multiline = true;
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(270, 32);
            this.searchTB.TabIndex = 133;
            this.searchTB.Text = "Search Supplier By Name";
            this.searchTB.Enter += new System.EventHandler(this.searchTB_Enter);
            this.searchTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTB_KeyPress);
            this.searchTB.Leave += new System.EventHandler(this.searchTB_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(920, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 40);
            this.btnSearch.TabIndex = 132;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackBtn.Location = new System.Drawing.Point(208, 455);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(82, 40);
            this.BackBtn.TabIndex = 135;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1225, 549);
            this.ControlBox = false;
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ResetPB);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SuppliersDGV);
            this.Controls.Add(this.supNameTb);
            this.Controls.Add(this.supp_name);
            this.Controls.Add(this.supIdCb);
            this.Controls.Add(this.supp_ids);
            this.Controls.Add(this.PCatCb);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PnameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProducts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PnameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox QtyTb;
        private System.Windows.Forms.ComboBox PCatCb;
        private System.Windows.Forms.ComboBox supIdCb;
        private System.Windows.Forms.Label supp_ids;
        private System.Windows.Forms.TextBox supNameTb;
        private System.Windows.Forms.Label supp_name;
        private Guna.UI.WinForms.GunaDataGridView SuppliersDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.PictureBox ResetPB;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button BackBtn;
    }
}