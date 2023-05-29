namespace Point_of_Sale
{
    partial class ViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpSalaryTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpPhoneTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EDesignationTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ENameTb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.editbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.EmployeesDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ViewEmp = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.AddEmployee = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.ViewCustomer2 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.AddCustomer = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.ViewSupplier = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.AddSupplier = new System.Windows.Forms.Label();
            this.ViewProduct = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.AddProduct = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ResetPB = new System.Windows.Forms.PictureBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 45);
            this.panel1.TabIndex = 68;
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
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(1120, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(31, 33);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 4;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "View Employees";
            // 
            // EmpSalaryTb
            // 
            this.EmpSalaryTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmpSalaryTb.Font = new System.Drawing.Font("Arial", 15F);
            this.EmpSalaryTb.Location = new System.Drawing.Point(804, 324);
            this.EmpSalaryTb.Multiline = true;
            this.EmpSalaryTb.Name = "EmpSalaryTb";
            this.EmpSalaryTb.Size = new System.Drawing.Size(312, 32);
            this.EmpSalaryTb.TabIndex = 99;
            this.EmpSalaryTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpSalaryTb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(721, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 98;
            this.label3.Text = "Salary: ";
            // 
            // EmpPhoneTb
            // 
            this.EmpPhoneTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmpPhoneTb.Font = new System.Drawing.Font("Arial", 15F);
            this.EmpPhoneTb.Location = new System.Drawing.Point(804, 272);
            this.EmpPhoneTb.Multiline = true;
            this.EmpPhoneTb.Name = "EmpPhoneTb";
            this.EmpPhoneTb.Size = new System.Drawing.Size(312, 32);
            this.EmpPhoneTb.TabIndex = 97;
            this.EmpPhoneTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpPhoneTb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(691, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 94;
            this.label1.Text = "Phone No: ";
            // 
            // EDesignationTb
            // 
            this.EDesignationTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EDesignationTb.Font = new System.Drawing.Font("Arial", 15F);
            this.EDesignationTb.Location = new System.Drawing.Point(804, 228);
            this.EDesignationTb.Multiline = true;
            this.EDesignationTb.Name = "EDesignationTb";
            this.EDesignationTb.Size = new System.Drawing.Size(312, 32);
            this.EDesignationTb.TabIndex = 93;
            this.EDesignationTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EDesignationTb_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(675, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 23);
            this.label12.TabIndex = 92;
            this.label12.Text = "Designation: ";
            // 
            // ENameTb
            // 
            this.ENameTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ENameTb.Font = new System.Drawing.Font("Arial", 15F);
            this.ENameTb.Location = new System.Drawing.Point(804, 177);
            this.ENameTb.Multiline = true;
            this.ENameTb.Name = "ENameTb";
            this.ENameTb.Size = new System.Drawing.Size(312, 32);
            this.ENameTb.TabIndex = 91;
            this.ENameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ENameTb_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(721, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 23);
            this.label13.TabIndex = 90;
            this.label13.Text = "Name: ";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel9.Location = new System.Drawing.Point(0, 634);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1176, 29);
            this.panel9.TabIndex = 100;
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.editbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.editbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.White;
            this.editbtn.Location = new System.Drawing.Point(706, 525);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(112, 40);
            this.editbtn.TabIndex = 103;
            this.editbtn.Text = "Update";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Location = new System.Drawing.Point(842, 525);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(112, 40);
            this.deletebtn.TabIndex = 101;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.backbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.backbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(978, 525);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(112, 40);
            this.backbtn.TabIndex = 102;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // EmployeesDGV
            // 
            this.EmployeesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeesDGV.BackgroundColor = System.Drawing.Color.White;
            this.EmployeesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeesDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bernard MT Condensed", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeesDGV.ColumnHeadersHeight = 28;
            this.EmployeesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Designation,
            this.PhoneNo,
            this.Salary});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeesDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeesDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EmployeesDGV.EnableHeadersVisualStyles = false;
            this.EmployeesDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeesDGV.Location = new System.Drawing.Point(33, 177);
            this.EmployeesDGV.Name = "EmployeesDGV";
            this.EmployeesDGV.ReadOnly = true;
            this.EmployeesDGV.RowHeadersVisible = false;
            this.EmployeesDGV.RowTemplate.Height = 28;
            this.EmployeesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeesDGV.Size = new System.Drawing.Size(624, 324);
            this.EmployeesDGV.TabIndex = 104;
            this.EmployeesDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.EmployeesDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty;
            this.EmployeesDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeesDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmployeesDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmployeesDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmployeesDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmployeesDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeesDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gold;
            this.EmployeesDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.EmployeesDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bernard MT Condensed", 12F);
            this.EmployeesDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.EmployeesDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeesDGV.ThemeStyle.HeaderStyle.Height = 28;
            this.EmployeesDGV.ThemeStyle.ReadOnly = true;
            this.EmployeesDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Black;
            this.EmployeesDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeesDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.EmployeesDGV.ThemeStyle.RowsStyle.Height = 28;
            this.EmployeesDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gold;
            this.EmployeesDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.EmployeesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeesDGV_CellContentClick);
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
            // Designation
            // 
            this.Designation.HeaderText = "Designation";
            this.Designation.Name = "Designation";
            this.Designation.ReadOnly = true;
            // 
            // PhoneNo
            // 
            this.PhoneNo.HeaderText = "PhoneNo";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.ViewEmp);
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Controls.Add(this.AddEmployee);
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Controls.Add(this.ViewCustomer2);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.AddCustomer);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.ViewSupplier);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.AddSupplier);
            this.panel2.Controls.Add(this.ViewProduct);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.AddProduct);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1151, 37);
            this.panel2.TabIndex = 105;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(270, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // ViewEmp
            // 
            this.ViewEmp.AutoSize = true;
            this.ViewEmp.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEmp.Location = new System.Drawing.Point(1009, 9);
            this.ViewEmp.Name = "ViewEmp";
            this.ViewEmp.Size = new System.Drawing.Size(107, 19);
            this.ViewEmp.TabIndex = 18;
            this.ViewEmp.Text = "View Employees";
            this.ViewEmp.Click += new System.EventHandler(this.ViewEmp_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(971, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 32);
            this.pictureBox10.TabIndex = 17;
            this.pictureBox10.TabStop = false;
            // 
            // AddEmployee
            // 
            this.AddEmployee.AutoSize = true;
            this.AddEmployee.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee.Location = new System.Drawing.Point(868, 9);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(97, 19);
            this.AddEmployee.TabIndex = 16;
            this.AddEmployee.Text = "Add Employee";
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(830, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 32);
            this.pictureBox9.TabIndex = 15;
            this.pictureBox9.TabStop = false;
            // 
            // ViewCustomer2
            // 
            this.ViewCustomer2.AutoSize = true;
            this.ViewCustomer2.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCustomer2.Location = new System.Drawing.Point(720, 9);
            this.ViewCustomer2.Name = "ViewCustomer2";
            this.ViewCustomer2.Size = new System.Drawing.Size(104, 19);
            this.ViewCustomer2.TabIndex = 14;
            this.ViewCustomer2.Text = "View Customers";
            this.ViewCustomer2.Click += new System.EventHandler(this.ViewCustomer2_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(682, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 32);
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            // 
            // AddCustomer
            // 
            this.AddCustomer.AutoSize = true;
            this.AddCustomer.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomer.Location = new System.Drawing.Point(582, 9);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(94, 19);
            this.AddCustomer.TabIndex = 11;
            this.AddCustomer.Text = "Add Customer";
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(544, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 32);
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            // 
            // ViewSupplier
            // 
            this.ViewSupplier.AutoSize = true;
            this.ViewSupplier.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSupplier.Location = new System.Drawing.Point(440, 9);
            this.ViewSupplier.Name = "ViewSupplier";
            this.ViewSupplier.Size = new System.Drawing.Size(98, 19);
            this.ViewSupplier.TabIndex = 9;
            this.ViewSupplier.Text = "View Suppliers";
            this.ViewSupplier.Click += new System.EventHandler(this.ViewSupplier_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(402, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // AddSupplier
            // 
            this.AddSupplier.AutoSize = true;
            this.AddSupplier.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSupplier.Location = new System.Drawing.Point(308, 9);
            this.AddSupplier.Name = "AddSupplier";
            this.AddSupplier.Size = new System.Drawing.Size(88, 19);
            this.AddSupplier.TabIndex = 7;
            this.AddSupplier.Text = "Add Supplier";
            this.AddSupplier.Click += new System.EventHandler(this.AddSupplier_Click);
            // 
            // ViewProduct
            // 
            this.ViewProduct.AutoSize = true;
            this.ViewProduct.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewProduct.Location = new System.Drawing.Point(168, 9);
            this.ViewProduct.Name = "ViewProduct";
            this.ViewProduct.Size = new System.Drawing.Size(96, 19);
            this.ViewProduct.TabIndex = 5;
            this.ViewProduct.Text = "View Products";
            this.ViewProduct.Click += new System.EventHandler(this.ViewProduct_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(130, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // AddProduct
            // 
            this.AddProduct.AutoSize = true;
            this.AddProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddProduct.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.Location = new System.Drawing.Point(38, 9);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(86, 19);
            this.AddProduct.TabIndex = 4;
            this.AddProduct.Text = "Add Product";
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // ResetPB
            // 
            this.ResetPB.Image = ((System.Drawing.Image)(resources.GetObject("ResetPB.Image")));
            this.ResetPB.Location = new System.Drawing.Point(419, 112);
            this.ResetPB.Name = "ResetPB";
            this.ResetPB.Size = new System.Drawing.Size(44, 40);
            this.ResetPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResetPB.TabIndex = 137;
            this.ResetPB.TabStop = false;
            this.ResetPB.Click += new System.EventHandler(this.ResetPB_Click);
            // 
            // searchTB
            // 
            this.searchTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchTB.Font = new System.Drawing.Font("Arial", 15F);
            this.searchTB.ForeColor = System.Drawing.Color.Silver;
            this.searchTB.Location = new System.Drawing.Point(33, 118);
            this.searchTB.Multiline = true;
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(270, 32);
            this.searchTB.TabIndex = 136;
            this.searchTB.Text = "Search Employee By Name";
            this.searchTB.Enter += new System.EventHandler(this.searchTB_Enter);
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
            this.btnSearch.Location = new System.Drawing.Point(309, 112);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 40);
            this.btnSearch.TabIndex = 135;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 660);
            this.ControlBox = false;
            this.Controls.Add(this.ResetPB);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.EmployeesDGV);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.EmpSalaryTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmpPhoneTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EDesignationTb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ENameTb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmpSalaryTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmpPhoneTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EDesignationTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ENameTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button backbtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI.WinForms.GunaDataGridView EmployeesDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ViewEmp;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label AddEmployee;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label ViewCustomer2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label AddCustomer;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label ViewSupplier;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label AddSupplier;
        private System.Windows.Forms.Label ViewProduct;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label AddProduct;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox ResetPB;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button btnSearch;
    }
}