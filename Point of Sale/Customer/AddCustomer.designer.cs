namespace Point_of_Sale
{
    partial class AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            this.CAddressTb = new System.Windows.Forms.TextBox();
            this.cusEmail = new System.Windows.Forms.Label();
            this.CPhoneTb = new System.Windows.Forms.TextBox();
            this.cusPhone = new System.Windows.Forms.Label();
            this.CNameTb = new System.Windows.Forms.TextBox();
            this.cusName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.CEmailTb = new System.Windows.Forms.TextBox();
            this.CAgeTb = new System.Windows.Forms.TextBox();
            this.cusAge = new System.Windows.Forms.Label();
            this.cusAddress = new System.Windows.Forms.Label();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // CAddressTb
            // 
            this.CAddressTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CAddressTb.Font = new System.Drawing.Font("Arial", 15F);
            this.CAddressTb.Location = new System.Drawing.Point(161, 301);
            this.CAddressTb.Multiline = true;
            this.CAddressTb.Name = "CAddressTb";
            this.CAddressTb.Size = new System.Drawing.Size(312, 88);
            this.CAddressTb.TabIndex = 40;
            // 
            // cusEmail
            // 
            this.cusEmail.AutoSize = true;
            this.cusEmail.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusEmail.Location = new System.Drawing.Point(85, 201);
            this.cusEmail.Name = "cusEmail";
            this.cusEmail.Size = new System.Drawing.Size(70, 23);
            this.cusEmail.TabIndex = 39;
            this.cusEmail.Text = "Email: ";
            // 
            // CPhoneTb
            // 
            this.CPhoneTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CPhoneTb.Font = new System.Drawing.Font("Arial", 15F);
            this.CPhoneTb.Location = new System.Drawing.Point(161, 144);
            this.CPhoneTb.Multiline = true;
            this.CPhoneTb.Name = "CPhoneTb";
            this.CPhoneTb.Size = new System.Drawing.Size(312, 32);
            this.CPhoneTb.TabIndex = 38;
            this.CPhoneTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CPhoneTb_KeyPress);
            // 
            // cusPhone
            // 
            this.cusPhone.AutoSize = true;
            this.cusPhone.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusPhone.Location = new System.Drawing.Point(48, 147);
            this.cusPhone.Name = "cusPhone";
            this.cusPhone.Size = new System.Drawing.Size(107, 23);
            this.cusPhone.TabIndex = 37;
            this.cusPhone.Text = "Phone No: ";
            // 
            // CNameTb
            // 
            this.CNameTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CNameTb.Font = new System.Drawing.Font("Arial", 15F);
            this.CNameTb.Location = new System.Drawing.Point(161, 88);
            this.CNameTb.Multiline = true;
            this.CNameTb.Name = "CNameTb";
            this.CNameTb.Size = new System.Drawing.Size(312, 32);
            this.CNameTb.TabIndex = 36;
            this.CNameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CNameTb_KeyPress);
            // 
            // cusName
            // 
            this.cusName.AutoSize = true;
            this.cusName.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusName.Location = new System.Drawing.Point(82, 91);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(73, 23);
            this.cusName.TabIndex = 35;
            this.cusName.Text = "Name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 28);
            this.label7.TabIndex = 34;
            this.label7.Text = "Add Customer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(437, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 52);
            this.panel1.TabIndex = 33;
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(10, 8);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(44, 36);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 38;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(5, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // CEmailTb
            // 
            this.CEmailTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CEmailTb.Font = new System.Drawing.Font("Arial", 15F);
            this.CEmailTb.Location = new System.Drawing.Point(161, 198);
            this.CEmailTb.Multiline = true;
            this.CEmailTb.Name = "CEmailTb";
            this.CEmailTb.Size = new System.Drawing.Size(312, 32);
            this.CEmailTb.TabIndex = 41;
            this.CEmailTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CEmailTb_KeyPress);
            this.CEmailTb.Leave += new System.EventHandler(this.CEmailTb_Leave);
            // 
            // CAgeTb
            // 
            this.CAgeTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CAgeTb.Font = new System.Drawing.Font("Arial", 15F);
            this.CAgeTb.Location = new System.Drawing.Point(161, 249);
            this.CAgeTb.Multiline = true;
            this.CAgeTb.Name = "CAgeTb";
            this.CAgeTb.Size = new System.Drawing.Size(312, 32);
            this.CAgeTb.TabIndex = 43;
            this.CAgeTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CAgeTb_KeyPress);
            // 
            // cusAge
            // 
            this.cusAge.AutoSize = true;
            this.cusAge.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusAge.Location = new System.Drawing.Point(104, 252);
            this.cusAge.Name = "cusAge";
            this.cusAge.Size = new System.Drawing.Size(51, 23);
            this.cusAge.TabIndex = 42;
            this.cusAge.Text = "Age:";
            // 
            // cusAddress
            // 
            this.cusAddress.AutoSize = true;
            this.cusAddress.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusAddress.Location = new System.Drawing.Point(66, 301);
            this.cusAddress.Name = "cusAddress";
            this.cusAddress.Size = new System.Drawing.Size(89, 23);
            this.cusAddress.TabIndex = 44;
            this.cusAddress.Text = "Address:";
            // 
            // Resetbtn
            // 
            this.Resetbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Resetbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Resetbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Resetbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Resetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resetbtn.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Resetbtn.ForeColor = System.Drawing.Color.White;
            this.Resetbtn.Location = new System.Drawing.Point(361, 454);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(112, 40);
            this.Resetbtn.TabIndex = 46;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.UseVisualStyleBackColor = false;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Savebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Savebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Savebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Savebtn.Location = new System.Drawing.Point(217, 454);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(112, 40);
            this.Savebtn.TabIndex = 45;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 523);
            this.ControlBox = false;
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.cusAddress);
            this.Controls.Add(this.CAgeTb);
            this.Controls.Add(this.cusAge);
            this.Controls.Add(this.CEmailTb);
            this.Controls.Add(this.CAddressTb);
            this.Controls.Add(this.cusEmail);
            this.Controls.Add(this.CPhoneTb);
            this.Controls.Add(this.cusPhone);
            this.Controls.Add(this.CNameTb);
            this.Controls.Add(this.cusName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCutomer";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CAddressTb;
        private System.Windows.Forms.Label cusEmail;
        private System.Windows.Forms.TextBox CPhoneTb;
        private System.Windows.Forms.Label cusPhone;
        private System.Windows.Forms.TextBox CNameTb;
        private System.Windows.Forms.Label cusName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox CEmailTb;
        private System.Windows.Forms.TextBox CAgeTb;
        private System.Windows.Forms.Label cusAge;
        private System.Windows.Forms.Label cusAddress;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.Button Savebtn;
    }
}