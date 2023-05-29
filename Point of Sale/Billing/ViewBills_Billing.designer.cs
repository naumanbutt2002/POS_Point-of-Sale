namespace Point_of_Sale
{
    partial class ViewBills_Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBills_Billing));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.SellsDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.BNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ResetPB = new System.Windows.Forms.PictureBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.BtnRest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 28);
            this.label7.TabIndex = 58;
            this.label7.Text = "View Bills";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(4, 8);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(44, 36);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 38;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.PictureBox11_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox11);
            this.panel1.Location = new System.Drawing.Point(677, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 52);
            this.panel1.TabIndex = 57;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(16, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 56;
            this.pictureBox5.TabStop = false;
            // 
            // SellsDGV
            // 
            this.SellsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SellsDGV.BackgroundColor = System.Drawing.Color.White;
            this.SellsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bernard MT Condensed", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.SellsDGV.ColumnHeadersHeight = 28;
            this.SellsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BNo,
            this.BDate,
            this.CustId,
            this.CustName,
            this.PName,
            this.Qty,
            this.Amount});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SellsDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.SellsDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SellsDGV.EnableHeadersVisualStyles = false;
            this.SellsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellsDGV.Location = new System.Drawing.Point(16, 123);
            this.SellsDGV.Name = "SellsDGV";
            this.SellsDGV.ReadOnly = true;
            this.SellsDGV.RowHeadersVisible = false;
            this.SellsDGV.RowTemplate.Height = 28;
            this.SellsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellsDGV.Size = new System.Drawing.Size(685, 462);
            this.SellsDGV.TabIndex = 68;
            this.SellsDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.SellsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty;
            this.SellsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SellsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SellsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SellsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SellsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SellsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gold;
            this.SellsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.SellsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bernard MT Condensed", 12F);
            this.SellsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.SellsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SellsDGV.ThemeStyle.HeaderStyle.Height = 28;
            this.SellsDGV.ThemeStyle.ReadOnly = true;
            this.SellsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Black;
            this.SellsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.SellsDGV.ThemeStyle.RowsStyle.Height = 28;
            this.SellsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gold;
            this.SellsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.SellsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellsDGV_CellContentClick);
            // 
            // BNo
            // 
            this.BNo.HeaderText = "BNo";
            this.BNo.Name = "BNo";
            this.BNo.ReadOnly = true;
            // 
            // BDate
            // 
            this.BDate.HeaderText = "BDate";
            this.BDate.Name = "BDate";
            this.BDate.ReadOnly = true;
            // 
            // CustId
            // 
            this.CustId.HeaderText = "CustId";
            this.CustId.Name = "CustId";
            this.CustId.ReadOnly = true;
            // 
            // CustName
            // 
            this.CustName.HeaderText = "CustName";
            this.CustName.Name = "CustName";
            this.CustName.ReadOnly = true;
            // 
            // PName
            // 
            this.PName.HeaderText = "PName";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // BackBtn
            // 
            this.BackBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackBtn.Location = new System.Drawing.Point(504, 591);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(82, 40);
            this.BackBtn.TabIndex = 136;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ResetPB
            // 
            this.ResetPB.Image = ((System.Drawing.Image)(resources.GetObject("ResetPB.Image")));
            this.ResetPB.Location = new System.Drawing.Point(402, 64);
            this.ResetPB.Name = "ResetPB";
            this.ResetPB.Size = new System.Drawing.Size(44, 40);
            this.ResetPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResetPB.TabIndex = 143;
            this.ResetPB.TabStop = false;
            this.ResetPB.Click += new System.EventHandler(this.ResetPB_Click);
            // 
            // searchTB
            // 
            this.searchTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchTB.Font = new System.Drawing.Font("Arial", 15F);
            this.searchTB.ForeColor = System.Drawing.Color.Silver;
            this.searchTB.Location = new System.Drawing.Point(16, 70);
            this.searchTB.Multiline = true;
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(270, 32);
            this.searchTB.TabIndex = 142;
            this.searchTB.Text = "Customer Name";
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
            this.btnSearch.Location = new System.Drawing.Point(292, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 40);
            this.btnSearch.TabIndex = 141;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // BtnRest
            // 
            this.BtnRest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnRest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnRest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRest.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnRest.Location = new System.Drawing.Point(615, 591);
            this.BtnRest.Name = "BtnRest";
            this.BtnRest.Size = new System.Drawing.Size(86, 40);
            this.BtnRest.TabIndex = 144;
            this.BtnRest.Text = "Reset";
            this.BtnRest.UseVisualStyleBackColor = true;
            this.BtnRest.Click += new System.EventHandler(this.BtnRest_Click);
            // 
            // ViewBills_Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(729, 674);
            this.ControlBox = false;
            this.Controls.Add(this.BtnRest);
            this.Controls.Add(this.ResetPB);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SellsDGV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBills_Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBills";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Guna.UI.WinForms.GunaDataGridView SellsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.PictureBox ResetPB;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button BtnRest;
    }
}